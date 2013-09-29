using System;
using System.Windows.Forms;

namespace StockMonitor
{
    public partial class MdiMain : Form
    {
        public static String ConnStr = "Server=localhost;Port=6432;UserId=stockdbuser;Password=790705;Database=stockdb;";
        public static String TimeFormat = @"yyyy-MM-dd HH:mm:ss z";
        public MdiMain()
        {
            InitializeComponent();

        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            var stockPriceWatch = new StockPriceWatch { MdiParent = this, WindowState = FormWindowState.Maximized };
            stockPriceWatch.Show();

        }

        //菜单--->计算成本
        private void 计算成本ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var calCost = new CalCost { MdiParent = this, WindowState = FormWindowState.Maximized };
            calCost.Show();
        }

        //菜单--->股票购入
        private void 股票购入ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var inputStock = new InputStock { MdiParent = this, WindowState = FormWindowState.Maximized };
            inputStock.Show();
        }

        private void 股票卖出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var outputStock = new OutputStock { MdiParent = this, WindowState = FormWindowState.Maximized };
            outputStock.Show();
        }

        private void 个股设定ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var stockSettings = new StockSettings { MdiParent = this, WindowState = FormWindowState.Maximized };
            stockSettings.Show();
        }

        private void 现金明细ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var cashDetail = new CashDetail { MdiParent = this, WindowState = FormWindowState.Maximized };
            cashDetail.Show();

        }

        private void 手续费边际分析ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var calFees = new CalFees() { MdiParent = this, WindowState = FormWindowState.Maximized };
            calFees.Show();
        }

        private void 红利计算ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var dividend = new Dividend() { MdiParent = this, WindowState = FormWindowState.Maximized };
            dividend.Show();

        }

        private void MdiMain_Load(object sender, EventArgs e)
        {
            var stockPriceWatch = new StockPriceWatch { MdiParent = this, WindowState = FormWindowState.Maximized };
            stockPriceWatch.Show();
        }

        private void 国债逆回购ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var reverseRepo = new ReverseRepo { MdiParent = this, WindowState = FormWindowState.Maximized };
            reverseRepo.Show();
        }

 
    }
}
