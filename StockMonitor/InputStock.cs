using System;
using System.Data;
using System.Windows.Forms;
using Npgsql;
using StockMonitor.Properties;

namespace StockMonitor
{
    public partial class InputStock : Form
    {



        public InputStock()
        {
            InitializeComponent();
        }

        //买入股票
        private void inputMyStockButton_Click(object sender, EventArgs e)
        {
            //确认对话框
            const MessageBoxButtons messButton = MessageBoxButtons.OKCancel;
            DialogResult dr = MessageBox.Show(Resources.WannaSave, Resources.Save, messButton);
            if (dr == DialogResult.OK)
            {
                //股票ID
                int sid = Convert.ToInt32(inputStockCB.SelectedValue);
                //股票数量
                int snumber = Convert.ToInt32(numberOfBuyStockTB.Text);
                //股票价格
                decimal sprice = Convert.ToDecimal(priceOfBuyStockTB.Text);
                //日期时间
                String sdatetime = DateTime.Now.ToString(MdiMain.TimeFormat);
                //买入=true 卖出=false
                //Boolean sop = true;
                //佣金
                decimal scommission = Utils.CostCalTools.CommissionCal(snumber, sprice);
                //印花税
                decimal sstamptax = 0m;
                //过户费
                decimal stransferfee = 0m;
                if (Utils.StockMarketTools.GetStockMarket(sid) == "sh")
                {
                    stransferfee = Utils.CostCalTools.TransferFeeCal(snumber);
                }

                String sqlStr = "INSERT INTO stocksite_mystock ( uid_id , sid_id , snumber , sprice , datetime , sop , commission , stamptax , transferfee ) VALUES ( 1 , " + sid + "," + snumber + "," + sprice + ",'" + sdatetime + "'," + true + "," + scommission + "," + sstamptax + "," + stransferfee + ")";
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
                MyStockDataGridViewCbBindData();
            }
        }

        private void InputStock_Load(object sender, EventArgs e)
        {
            InputStockCbBindData();
            MyStockDataGridViewCbBindData();
        }

        public void InputStockCbBindData()
        {
            var conn = new NpgsqlConnection(MdiMain.ConnStr);
            conn.Open();
            var da = new NpgsqlDataAdapter("select * from stocksite_stock", conn);
            var ds = new DataSet();
            da.Fill(ds);
            inputStockCB.DataSource = ds.Tables[0].DefaultView;
            inputStockCB.DisplayMember = "sname";
            inputStockCB.ValueMember = "id";
        }

        public void MyStockDataGridViewCbBindData()
        {
            var conn = new NpgsqlConnection(MdiMain.ConnStr);
            conn.Open();
            var da = new NpgsqlDataAdapter("SELECT * FROM stocksite_mystock WHERE sop = TRUE ORDER BY id DESC", conn);
            var ds = new DataSet();
            da.Fill(ds);
            myStockDataGridView.DataSource = ds.Tables[0].DefaultView;
        }
    }
}

