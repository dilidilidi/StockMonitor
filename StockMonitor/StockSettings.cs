using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace StockMonitor
{
    public partial class StockSettings : Form
    {
        public StockSettings()
        {
            InitializeComponent();
        }

        private void inputStockButton_Click(object sender, EventArgs e)
        {
            MessageBoxButtons messButton = MessageBoxButtons.OKCancel;
            DialogResult dr = MessageBox.Show("确定要保存吗?", "保存", messButton);
            if (dr == DialogResult.OK)
            {

                String sqlStr = "INSERT INTO stocksite_stock ( sname , scode ) VALUES ('" + stockNameTB.Text + "','" +
                                stockCodeTB.Text + "')";
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
                StockSettingsDataGridViewCbBindData();
            }
        }
        public void StockSettingsDataGridViewCbBindData()
        {
            var conn = new NpgsqlConnection(MdiMain.ConnStr);
            conn.Open();
            var da = new NpgsqlDataAdapter("select * from stocksite_stock order by id desc", conn);
            var ds = new DataSet();
            da.Fill(ds);
            stockSettingsDataGridView.DataSource = ds.Tables[0].DefaultView;
        }

        private void StockSettings_Load(object sender, EventArgs e)
        {
            StockSettingsDataGridViewCbBindData();
        }
    }
}
