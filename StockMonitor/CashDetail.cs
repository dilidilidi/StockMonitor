using System;
using System.Data;
using System.Windows.Forms;
using Npgsql;

namespace StockMonitor
{
    public partial class CashDetail : Form
    {
      
        public CashDetail()
        {
            InitializeComponent();
        }

        private void CashDetail_Load(object sender, EventArgs e)
        {

            CashDetailDataGridViewBindData();

        }

        public void CashDetailDataGridViewBindData()
        {
            var conn = new NpgsqlConnection(MdiMain.ConnStr);
            conn.Open();
            var da = new NpgsqlDataAdapter("SELECT * FROM stocksite_mycash ORDER BY id DESC", conn);
            var ds = new DataSet();
            da.Fill(ds);
            cashDetailDataGridView.DataSource = ds.Tables[0].DefaultView;

        }
    }
}
