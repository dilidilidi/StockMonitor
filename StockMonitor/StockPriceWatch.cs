using System;
using System.Data;
using System.Globalization;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.IO;
using System.IO.Compression;
using System.Timers;
using Npgsql;
using StockMonitor.Properties;
using StockMonitor.Utils;

namespace StockMonitor
{
    public partial class StockPriceWatch : Form
    {

        private static System.Timers.Timer _aTimer;

        Boolean _timeFlag = true;

        delegate void GetPriceDelegateCallback(object sender, ElapsedEventArgs e);

        public StockPriceWatch()
        {
            InitializeComponent();
        }
        //绑定股票
        public void StockCbBind()
        {
            //绑定StockCb
            var conn = new NpgsqlConnection(MdiMain.ConnStr);
            conn.Open();
            var da = new NpgsqlDataAdapter("select * from stocksite_stock", conn);
            var ds = new DataSet();
            da.Fill(ds);
            StockCb.DataSource = ds.Tables[0].DefaultView;
            StockCb.DisplayMember = "sname";
            StockCb.ValueMember = "scode";

            //绑定WatchTypeCb
            object[] x = { "大于", "小于" };
            WatchTypeCb.Items.AddRange(x);
            WatchTypeCb.SelectedItem = x[0];

        }


        private void button1_Click(object sender, EventArgs e)
        {
            if (_timeFlag)
            {
                _aTimer = new System.Timers.Timer { Interval = 5000, Enabled = true };
                _aTimer.Elapsed += GetPriceDelegate;
                button1.Text = Resources.StopWatch;
                _timeFlag = false;
                SoundUtil.Playable = true;
            }
            else
            {
                button1.Text = Resources.StartWatch;
                _timeFlag = true;
                _aTimer.Enabled = false;
                SoundUtil.Playable = false;
                SoundUtil.IsPlaying = false;
                SoundUtil.SndPlayer.Stop();
            }
        }

        private void GetPriceDelegate(object sender, ElapsedEventArgs e)
        {
            var gpd = new GetPriceDelegateCallback(GetPrice);
            Invoke(gpd, new[] { sender, e });

        }

        private void GetPrice(object sender, ElapsedEventArgs e)
        {

            string strurl = @"http://hq.sinajs.cn/list=" + StockCb.SelectedValue.ToString().ToLower();
            var content = new StringBuilder();
            try
            {

                var request = (HttpWebRequest)WebRequest.Create(strurl.ToLower());
                //request.CookieContainer = new CookieContainer();  
                //CookieContainer cookie = request.CookieContainer;//如果用不到Cookie，删去即可  
                request.Referer = "http://localhost/index.html";
                request.Accept = "Accept:text/html,application/xhtml+xml,application/xml;q=0.9,*/*;q=0.8";
                request.Headers["Accept-Language"] = "zh-CN,zh;q=0.";
                request.Headers["Accept-Charset"] = "GBK,utf-8;q=0.7,*;q=0.3";
                request.UserAgent = "User-Agent:Mozilla/5.0 (Windows NT 5.1) AppleWebKit/535.1 (KHTML, like Gecko) Chrome/14.0.835.202 Safari/535.1";
                request.KeepAlive = false;
                request.ContentType = "application/x-www-form-urlencoded";
                request.Method = "GET";
                //传递参数
                // 获取对应HTTP请求的响应
                var response = (HttpWebResponse)request.GetResponse();
                // 获取响应流
                Stream responseStream = response.GetResponseStream();
                if (responseStream != null)
                {
                    if (response.Headers["Content-Encoding"] != null && response.Headers["Content-Encoding"].ToLower().Contains("gzip"))
                    {
                        responseStream = new GZipStream(responseStream, CompressionMode.Decompress);
                    }
                    // 对接响应流(以"utf-8"字符集)
                    var sReader = new StreamReader(responseStream, Encoding.GetEncoding("utf-8"));
                    // 开始读取数据
                    var sReaderBuffer = new Char[256];
                    int count = sReader.Read(sReaderBuffer, 0, 256);
                    while (count > 0)
                    {
                        var tempStr = new String(sReaderBuffer, 0, count);
                        content.Append(tempStr);
                        count = sReader.Read(sReaderBuffer, 0, 256);
                    }
                    // 读取结束
                    sReader.Close();
                    responseStream.Close();
                }
            }
            catch (Exception)
            {
                content = new StringBuilder("Runtime Error");
            }
            string sprice = content.ToString().Split(new[] { '\"' })[1].Split(new[] { ',' })[3];

            currentStocePriceTb.Text = sprice;
            //当前价格
            Decimal currentStockPrice = Convert.ToDecimal(sprice);

            //监控价格
            Decimal priceOfWatch = Convert.ToDecimal(PriceOfWatchTb.Text);


            if (WatchTypeCb.SelectedItem.ToString() == "大于")
            {
                if (currentStockPrice >= priceOfWatch)
                {
                    SoundUtil.StartPlaySound(@"/sound/dog.wav");
                }
            }
            else
            {
                if (currentStockPrice <= priceOfWatch)
                {
                    SoundUtil.StartPlaySound(@"/sound/dog.wav");
                }
            }
        }

        private void StockPriceWatch_Load(object sender, EventArgs e)
        {
            StockCbBind();
        }

        private void CalFeesButton_Click(object sender, EventArgs e)
        {
            Decimal price = Convert.ToDecimal(currentStocePriceTb.Text);
            Decimal feeRate = Convert.ToDecimal(FeeRateTb.Text);
            Decimal fee = Convert.ToDecimal(FeeTb.Text);
            Decimal number = fee / (feeRate * price);
            PriceTb.Text = currentStocePriceTb.Text;
            StockNumberTb.Text = ((Math.Round(number / 100) + 1) * 100).ToString(CultureInfo.InvariantCulture);
        }

        private void CalPureProfit_Click(object sender, EventArgs e)
        {
            PriceOfSellTb.Text = PriceTb.Text;
            //获取股票数量
            decimal stockNumber = Convert.ToDecimal(StockNumberTb.Text);
            //获取买入成本-->已包含买入佣金，印花税，过户费
            decimal costOfBuy = Convert.ToDecimal(CostOfBuyTb.Text);
            //获取预期卖出价格
            decimal priceOfSell = Convert.ToDecimal(PriceOfSellTb.Text);
            //获取每10红利（含税）
            decimal tenDividend = Convert.ToDecimal(TenDividendTb.Text);
            //获取佣金率
            decimal commissionRate = Convert.ToDecimal(CommissionRateTb.Text);
            //获取印花税率
            decimal stampTaxRate = Convert.ToDecimal(StampTaxRateTb.Text);
            //获取过户费率
            decimal transferFeeRate = Convert.ToDecimal(TransferFeeRateTb.Text);
            //获取红利税率
            decimal dividendTaxRate = Convert.ToDecimal(DividendTaxRateTb.Text);

            //总支出--->公式：数量*买入成本
            decimal outOfAll = stockNumber * costOfBuy;
            //总收入--->公式：数量*预期卖出单价（1-佣金率-印花税率）-数量*过户费率
            decimal inOfAll = stockNumber * priceOfSell * (1 - commissionRate - stampTaxRate) - stockNumber * transferFeeRate;
            //红利--->公式：数量*每10红利（1-红利税率）
            decimal dividend = stockNumber / 10 * tenDividend * (1 - dividendTaxRate);
            //纯利润--->公式：总收入-总支出+红利
            decimal pureProfit = inOfAll - outOfAll + dividend;

            PureprofitTb.Text = pureProfit.ToString("#0.00");
            NeedMoneyTb.Text = outOfAll.ToString("#0.00");
            PureprofitRateTb.Text = (pureProfit / outOfAll).ToString("p2");
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void TenDividendTb_TextChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void PriceOfSellTb_TextChanged(object sender, EventArgs e)
        {

        }


    }
}
