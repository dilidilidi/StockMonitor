using System;
using System.Data;
using System.Windows.Forms;
using Npgsql;
using StockMonitor.Properties;

namespace StockMonitor
{
    public partial class OutputStock : Form
    {

        public OutputStock()
        {
            InitializeComponent();
        }

        public void OutputStockCbBindData()
        {
            var conn = new NpgsqlConnection(MdiMain.ConnStr);
            conn.Open();
            var da = new NpgsqlDataAdapter("select * from stocksite_stock", conn);
            var ds = new DataSet();
            da.Fill(ds);
            outputStockCB.DataSource = ds.Tables[0].DefaultView;
            outputStockCB.DisplayMember = "sname";
            outputStockCB.ValueMember = "id";
        }

        private void OutputStock_Load(object sender, EventArgs e)
        {
            OutputStockCbBindData();
            OutputStockDataGridViewCbBindData();

        }

        //卖出股票
        private void outputMyStockButton_Click(object sender, EventArgs e)
        {
            //确认对话框
            const MessageBoxButtons messButton = MessageBoxButtons.OKCancel;
            DialogResult dr = MessageBox.Show(Resources.WannaSave, Resources.Save, messButton);
            if (dr == DialogResult.OK)
            {
                //股票ID
                int sid = Convert.ToInt32(outputStockCB.SelectedValue);
                //股票数量
                int snumber = Convert.ToInt32(numberOfSellStockTB.Text);
                //股票价格
                decimal sprice = Convert.ToDecimal(priceOfSellStockTB.Text);
                //日期时间
                String sdatetime = DateTime.Now.ToString(MdiMain.TimeFormat);
                //买入=true 卖出=false
                //Boolean sop = false;
                //佣金
                decimal scommission = Utils.CostCalTools.CommissionCal(snumber, sprice);
                //印花税
                decimal sstamptax = Utils.CostCalTools.StampTaxCal(snumber, sprice);
                //过户费
                decimal stransferfee = 0m;
                if (Utils.StockMarketTools.GetStockMarket(sid) == "sh")
                {
                    stransferfee = Utils.CostCalTools.TransferFeeCal(snumber);
                }

                String sqlStr = "INSERT INTO stocksite_mystock ( uid_id , sid_id , snumber , sprice , datetime , sop , commission , stamptax , transferfee ) VALUES ( 1 , " + sid + "," + snumber + "," + sprice + ",'" + sdatetime + "'," + false + "," + scommission + "," + sstamptax + "," + stransferfee + ")";
                var conn = new NpgsqlConnection(MdiMain.ConnStr);
                conn.Open();
                var command = new NpgsqlCommand(sqlStr, conn);
                try
                {
                    command.ExecuteNonQuery();
                }
                finally
                {
                    conn.Close();
                }
                OutputStockDataGridViewCbBindData();
            }
        }

        public void OutputStockDataGridViewCbBindData()
        {
            var conn = new NpgsqlConnection(MdiMain.ConnStr);
            conn.Open();
            var da = new NpgsqlDataAdapter("SELECT * FROM stocksite_mystock WHERE sop = FALSE ORDER BY id DESC", conn);
            var ds = new DataSet();
            da.Fill(ds);
            outputStockDataGridView.DataSource = ds.Tables[0].DefaultView;
        }
    }
}

