namespace StockMonitor
{
    partial class OutputStock
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.outputStockCB = new System.Windows.Forms.ComboBox();
            this.stockName = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.numberOfSellStockTB = new System.Windows.Forms.TextBox();
            this.numberOfSellStockLabel = new System.Windows.Forms.Label();
            this.priceOfSellStockTB = new System.Windows.Forms.TextBox();
            this.priceOfSellStockLabel = new System.Windows.Forms.Label();
            this.outputMyStockButton = new System.Windows.Forms.Button();
            this.outputStockDataGridView = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.outputStockDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // outputStockCB
            // 
            this.outputStockCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.outputStockCB.FormattingEnabled = true;
            this.outputStockCB.Location = new System.Drawing.Point(100, 20);
            this.outputStockCB.Name = "outputStockCB";
            this.outputStockCB.Size = new System.Drawing.Size(121, 20);
            this.outputStockCB.TabIndex = 2;
            // 
            // stockName
            // 
            this.stockName.AutoSize = true;
            this.stockName.Location = new System.Drawing.Point(10, 20);
            this.stockName.Name = "stockName";
            this.stockName.Size = new System.Drawing.Size(65, 12);
            this.stockName.TabIndex = 3;
            this.stockName.Text = "股票名称：";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.numberOfSellStockTB);
            this.panel1.Controls.Add(this.numberOfSellStockLabel);
            this.panel1.Controls.Add(this.priceOfSellStockTB);
            this.panel1.Controls.Add(this.priceOfSellStockLabel);
            this.panel1.Controls.Add(this.outputMyStockButton);
            this.panel1.Controls.Add(this.stockName);
            this.panel1.Controls.Add(this.outputStockCB);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(813, 50);
            this.panel1.TabIndex = 4;
            // 
            // numberOfSellStockTB
            // 
            this.numberOfSellStockTB.Location = new System.Drawing.Point(341, 20);
            this.numberOfSellStockTB.Name = "numberOfSellStockTB";
            this.numberOfSellStockTB.Size = new System.Drawing.Size(100, 21);
            this.numberOfSellStockTB.TabIndex = 10;
            // 
            // numberOfSellStockLabel
            // 
            this.numberOfSellStockLabel.AutoSize = true;
            this.numberOfSellStockLabel.Location = new System.Drawing.Point(243, 20);
            this.numberOfSellStockLabel.Name = "numberOfSellStockLabel";
            this.numberOfSellStockLabel.Size = new System.Drawing.Size(65, 12);
            this.numberOfSellStockLabel.TabIndex = 9;
            this.numberOfSellStockLabel.Text = "卖出数量：";
            // 
            // priceOfSellStockTB
            // 
            this.priceOfSellStockTB.Location = new System.Drawing.Point(566, 20);
            this.priceOfSellStockTB.Name = "priceOfSellStockTB";
            this.priceOfSellStockTB.Size = new System.Drawing.Size(100, 21);
            this.priceOfSellStockTB.TabIndex = 8;
            // 
            // priceOfSellStockLabel
            // 
            this.priceOfSellStockLabel.AutoSize = true;
            this.priceOfSellStockLabel.Location = new System.Drawing.Point(479, 20);
            this.priceOfSellStockLabel.Name = "priceOfSellStockLabel";
            this.priceOfSellStockLabel.Size = new System.Drawing.Size(65, 12);
            this.priceOfSellStockLabel.TabIndex = 5;
            this.priceOfSellStockLabel.Text = "卖出价格：";
            // 
            // outputMyStockButton
            // 
            this.outputMyStockButton.Location = new System.Drawing.Point(685, 20);
            this.outputMyStockButton.Name = "outputMyStockButton";
            this.outputMyStockButton.Size = new System.Drawing.Size(125, 23);
            this.outputMyStockButton.TabIndex = 4;
            this.outputMyStockButton.Text = "卖出";
            this.outputMyStockButton.UseVisualStyleBackColor = true;
            this.outputMyStockButton.Click += new System.EventHandler(this.outputMyStockButton_Click);
            // 
            // outputStockDataGridView
            // 
            this.outputStockDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.outputStockDataGridView.Location = new System.Drawing.Point(12, 68);
            this.outputStockDataGridView.Name = "outputStockDataGridView";
            this.outputStockDataGridView.RowTemplate.Height = 23;
            this.outputStockDataGridView.Size = new System.Drawing.Size(1017, 347);
            this.outputStockDataGridView.TabIndex = 5;
            // 
            // OutputStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1031, 466);
            this.Controls.Add(this.outputStockDataGridView);
            this.Controls.Add(this.panel1);
            this.Name = "OutputStock";
            this.Text = "股票卖出";
            this.Load += new System.EventHandler(this.OutputStock_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.outputStockDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox outputStockCB;
        private System.Windows.Forms.Label stockName;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button outputMyStockButton;
        private System.Windows.Forms.TextBox numberOfSellStockTB;
        private System.Windows.Forms.Label numberOfSellStockLabel;
        private System.Windows.Forms.TextBox priceOfSellStockTB;
        private System.Windows.Forms.Label priceOfSellStockLabel;
        private System.Windows.Forms.DataGridView outputStockDataGridView;
    }
}