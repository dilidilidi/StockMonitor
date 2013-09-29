using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StockMonitor
{
    public partial class ReverseRepo : Form
    {
        public ReverseRepo()
        {
            InitializeComponent();
        }

        private void CalBtn_Click(object sender, EventArgs e)
        {
            double annualInterestRate = Convert.ToDouble(this.AnnualInterestRateTb.Text);
            double principal = Convert.ToDouble(PrincipalTb.Text);
            DailyInterestRateTb.Text = (annualInterestRate / 360).ToString("p4");
            InterestPerDiemTb.Text = (principal * annualInterestRate / 360).ToString("#0.00");
            //AnnualCompoundRateTb.Text = Math.Pow(1 + annualInterestRate/360, 100).ToString("p4");
            AnnualCompoundRateTb.Text = calFee(principal, annualInterestRate / 360).ToString("#0.00");
        }

        public double calFee( double p ,double r)
        {
            double principal = p;
            double rate = r;
            for (int i = 0; i < 359; i++)
            {
                principal = principal+Math.Truncate(principal/1000)*1000*rate;
            }
            return principal;
        }
    }
}
