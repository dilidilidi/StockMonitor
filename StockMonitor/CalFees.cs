using System;
using System.Globalization;
using System.Windows.Forms;

namespace StockMonitor
{
    public partial class CalFees : Form
    {
        public CalFees()
        {
            InitializeComponent();
        }

        private void CalFeesButton_Click(object sender, EventArgs e)
        {
            Decimal price = Convert.ToDecimal(StockPriceTb.Text);
            Decimal feeRate = Convert.ToDecimal(FeeRateTb.Text);
            Decimal fee = Convert.ToDecimal(FeeTb.Text);

            Decimal number = fee/(feeRate*price);

            StockNumberTb.Text = Math.Round(number).ToString(CultureInfo.InvariantCulture);









        }
    }
}
