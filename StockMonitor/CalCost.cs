using System;
using System.Data;
using System.Windows.Forms;
using Npgsql;

namespace StockMonitor
{
    public partial class CalCost : Form
    {

        public CalCost()
        {
            InitializeComponent();
        }

        private void calCostButton_Click(object sender, EventArgs e)
        {
            var conn = new NpgsqlConnection(MdiMain.ConnStr);
            conn.Open();
            String sqlStr = "select snumber,sprice,sop,commission,stamptax,transferfee from stocksite_mystock where uid_id=1 and sid_id=" + calCostStockCB.SelectedValue;
            var da = new NpgsqlDataAdapter(sqlStr, conn);
            var ds = new DataSet();
            da.Fill(ds);
            DataTable myStockDatatable = ds.Tables[0];

            int totelNumberOfBuy = 0;
            int totelNumberOfSell = 0;
            Decimal totelMoneyOfBuy = 0;
            Decimal totelMoneyOfSell = 0;

            foreach (DataRow row in myStockDatatable.Rows)
            {
                int snumber = Convert.ToInt32(row["snumber"]);
                Decimal sprice = Convert.ToDecimal(row["sprice"]);
                Decimal scommission = Convert.ToDecimal(row["commission"]);
                Decimal sstamptax = Convert.ToDecimal(row["stamptax"]);
                Decimal stransferfee = Convert.ToDecimal(row["transferfee"]);
                Boolean sop = Convert.ToBoolean(row["sop"]);

                if (sop)
                {
                    totelNumberOfBuy = totelNumberOfBuy + snumber;
                    totelMoneyOfBuy = totelMoneyOfBuy + snumber * sprice + scommission + sstamptax + stransferfee;
                }
                else
                {
                    totelNumberOfSell = totelNumberOfSell + snumber;
                    totelMoneyOfSell = totelMoneyOfSell + snumber * sprice + scommission + sstamptax + stransferfee;
                }
            }
            int sTotelNumber = totelNumberOfBuy - totelNumberOfSell;
            stockNumberTB.Text = Convert.ToString(sTotelNumber);
            decimal sTotelMoney = totelMoneyOfBuy - totelMoneyOfSell;
            stockTotelCostTB.Text = Convert.ToString(sTotelMoney);
            switch (sTotelNumber)
            {
                case 0:
                    stockPerCostTB.Text = @"0";
                    break;
                default:
                    stockPerCostTB.Text = Convert.ToString(Math.Round(sTotelMoney/sTotelNumber, 3));
                    break;
            }
        }

        private void CalCost_Load(object sender, EventArgs e)
        {
            CalCostStockCbBindData();
            CalCostdataGridViewBindData();
        }
        public void CalCostStockCbBindData()
        {
            var conn = new NpgsqlConnection(MdiMain.ConnStr);
            conn.Open();
            var da = new NpgsqlDataAdapter("select * from stocksite_stock", conn);
            var ds = new DataSet();
            da.Fill(ds);
            calCostStockCB.DataSource = ds.Tables[0].DefaultView;
            calCostStockCB.DisplayMember = "sname";
            calCostStockCB.ValueMember = "id";

        }

        public void CalCostdataGridViewBindData()
        {
            var conn = new NpgsqlConnection(MdiMain.ConnStr);
            conn.Open();
            var da = new NpgsqlDataAdapter("SELECT * FROM stocksite_mystock ORDER BY id DESC", conn);
            var ds = new DataSet();
            da.Fill(ds);
            calCostdataGridView.DataSource = ds.Tables[0].DefaultView;
        }
    }
}
