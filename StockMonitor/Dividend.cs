using System;
using System.Data;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using Npgsql;
using StockMonitor.Properties;

namespace StockMonitor
{
    public partial class Dividend : Form
    {
        public Dividend()
        {
            InitializeComponent();
        }

        public void DividendDataGridViewBindData()
        {
            var conn = new NpgsqlConnection(MdiMain.ConnStr);
            conn.Open();
            var da = new NpgsqlDataAdapter("SELECT * FROM dividend WHERE sid = " + StockCB.SelectedValue + "ORDER BY id DESC", conn);
            var ds = new DataSet();
            da.Fill(ds);
            DividendDataGridView.DataSource = ds.Tables[0].DefaultView;
        }
        public void StockCbBind()
        {
            var conn = new NpgsqlConnection(MdiMain.ConnStr);
            conn.Open();
            var da = new NpgsqlDataAdapter("select * from stocksite_stock", conn);
            var ds = new DataSet();
            da.Fill(ds);
            StockCB.DataSource = ds.Tables[0].DefaultView;
            StockCB.DisplayMember = "sname";
            StockCB.ValueMember = "id";
            ExDividendDateTb.Text = DateTime.Now.ToString(@"yyyy-MM-dd");
            DateOfDeclarationTb.Text = DateTime.Now.ToString(@"yyyy-MM-dd");
            DateOfRecordTb.Text = DateTime.Now.ToString(@"yyyy-MM-dd");
        }

        private void Dividend_Load(object sender, EventArgs e)
        {
            StockCbBind();
            DividendDataGridViewBindData();
        }

        private void InsertDividentBtn_Click(object sender, EventArgs e)
        {
            //验证输入
            if (!Validator())
            {
                MessageBox.Show(@"输入格式错误");
                return;
            }
            //确认对话框
            const MessageBoxButtons messButton = MessageBoxButtons.OKCancel;
            DialogResult dr = MessageBox.Show(Resources.WannaSave, Resources.Save, messButton);
            if (dr == DialogResult.OK)
            {
                //股票ID
                int sid = Convert.ToInt32(StockCB.SelectedValue);
                //每10股红利
                decimal sDividend = Convert.ToDecimal(DividentTb.Text);
                //公告日期
                String dateOfDeclaration = DateOfDeclarationTb.Text;
                //股权登记日
                String dateOfRecord = DateOfRecordTb.Text;
                //除息日
                String exDividendDate = ExDividendDateTb.Text;
                //                if (Utils.StockMarketTools.GetStockMarket(sid) == "sh")
                //                {
                //                    stransferfee = Utils.CostCalTools.TransferFeeCal(snumber);
                //                }

                String sqlStr =
                    "INSERT INTO dividend ( sid , dividend , dateofrecord , exdividenddate , dateofdeclaration ) VALUES (" +
                    sid + "," + sDividend + ",'" + dateOfRecord + "','" + exDividendDate + "','" + dateOfDeclaration +
                    "')";
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
                DividendDataGridViewBindData();
            }
        }

        public Boolean Validator()
        {
            var rx1 = new Regex(pattern: @"^\d{4}-\d{1,2}-\d{1,2}$");
            var rx = new Regex(pattern: @"^\d{1,2}.\d{1,2}$|^\d{1,2}$");
            Match ma1 = rx1.Match(DateOfDeclarationTb.Text);
            Match ma2 = rx1.Match(DateOfRecordTb.Text);
            Match ma3 = rx1.Match(ExDividendDateTb.Text);
            Match ma4 = rx.Match(DividentTb.Text);
            return ma1.Success && ma2.Success && ma3.Success && ma4.Success;
        }

        private void StockCB_SelectionChangeCommitted(object sender, EventArgs e)
        {
            DividendDataGridViewBindData();
        }


    }
}
