namespace StockMonitor
{
    partial class InputStock
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
            this.inputStockCB = new System.Windows.Forms.ComboBox();
            this.stockName = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.numberOfBuyStockTB = new System.Windows.Forms.TextBox();
            this.numberOfBuyStockLabel = new System.Windows.Forms.Label();
            this.priceOfBuyStockTB = new System.Windows.Forms.TextBox();
            this.priceOfBuyStockLabel = new System.Windows.Forms.Label();
            this.inputMyStockButton = new System.Windows.Forms.Button();
            this.myStockDataGridView = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.myStockDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // inputStockCB
            // 
            this.inputStockCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.inputStockCB.FormattingEnabled = true;
            this.inputStockCB.Location = new System.Drawing.Point(95, 21);
            this.inputStockCB.Name = "inputStockCB";
            this.inputStockCB.Size = new System.Drawing.Size(121, 20);
            this.inputStockCB.TabIndex = 2;
            // 
            // stockName
            // 
            this.stockName.AutoSize = true;
            this.stockName.Location = new System.Drawing.Point(24, 29);
            this.stockName.Name = "stockName";
            this.stockName.Size = new System.Drawing.Size(65, 12);
            this.stockName.TabIndex = 3;
            this.stockName.Text = "股票名称：";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.numberOfBuyStockTB);
            this.panel1.Controls.Add(this.numberOfBuyStockLabel);
            this.panel1.Controls.Add(this.priceOfBuyStockTB);
            this.panel1.Controls.Add(this.priceOfBuyStockLabel);
            this.panel1.Controls.Add(this.inputMyStockButton);
            this.panel1.Controls.Add(this.stockName);
            this.panel1.Controls.Add(this.inputStockCB);
            this.panel1.Location = new System.Drawing.Point(12, 10);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(811, 55);
            this.panel1.TabIndex = 4;
            // 
            // numberOfBuyStockTB
            // 
            this.numberOfBuyStockTB.Location = new System.Drawing.Point(307, 20);
            this.numberOfBuyStockTB.Name = "numberOfBuyStockTB";
            this.numberOfBuyStockTB.Size = new System.Drawing.Size(100, 21);
            this.numberOfBuyStockTB.TabIndex = 10;
            // 
            // numberOfBuyStockLabel
            // 
            this.numberOfBuyStockLabel.AutoSize = true;
            this.numberOfBuyStockLabel.Location = new System.Drawing.Point(236, 29);
            this.numberOfBuyStockLabel.Name = "numberOfBuyStockLabel";
            this.numberOfBuyStockLabel.Size = new System.Drawing.Size(65, 12);
            this.numberOfBuyStockLabel.TabIndex = 9;
            this.numberOfBuyStockLabel.Text = "买入数量：";
            // 
            // priceOfBuyStockTB
            // 
            this.priceOfBuyStockTB.Location = new System.Drawing.Point(505, 18);
            this.priceOfBuyStockTB.Name = "priceOfBuyStockTB";
            this.priceOfBuyStockTB.Size = new System.Drawing.Size(100, 21);
            this.priceOfBuyStockTB.TabIndex = 8;
            // 
            // priceOfBuyStockLabel
            // 
            this.priceOfBuyStockLabel.AutoSize = true;
            this.priceOfBuyStockLabel.Location = new System.Drawing.Point(434, 29);
            this.priceOfBuyStockLabel.Name = "priceOfBuyStockLabel";
            this.priceOfBuyStockLabel.Size = new System.Drawing.Size(65, 12);
            this.priceOfBuyStockLabel.TabIndex = 5;
            this.priceOfBuyStockLabel.Text = "买入价格：";
            // 
            // inputMyStockButton
            // 
            this.inputMyStockButton.Location = new System.Drawing.Point(629, 18);
            this.inputMyStockButton.Name = "inputMyStockButton";
            this.inputMyStockButton.Size = new System.Drawing.Size(125, 23);
            this.inputMyStockButton.TabIndex = 4;
            this.inputMyStockButton.Text = "保存";
            this.inputMyStockButton.UseVisualStyleBackColor = true;
            this.inputMyStockButton.Click += new System.EventHandler(this.inputMyStockButton_Click);
            // 
            // myStockDataGridView
            // 
            this.myStockDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.myStockDataGridView.Location = new System.Drawing.Point(12, 71);
            this.myStockDataGridView.Name = "myStockDataGridView";
            this.myStockDataGridView.RowTemplate.Height = 23;
            this.myStockDataGridView.Size = new System.Drawing.Size(1019, 355);
            this.myStockDataGridView.TabIndex = 6;
            // 
            // InputStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1031, 466);
            this.Controls.Add(this.myStockDataGridView);
            this.Controls.Add(this.panel1);
            this.Name = "InputStock";
            this.Text = "股票购入";
            this.Load += new System.EventHandler(this.InputStock_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.myStockDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox inputStockCB;
        private System.Windows.Forms.Label stockName;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button inputMyStockButton;
        private System.Windows.Forms.TextBox numberOfBuyStockTB;
        private System.Windows.Forms.Label numberOfBuyStockLabel;
        private System.Windows.Forms.TextBox priceOfBuyStockTB;
        private System.Windows.Forms.Label priceOfBuyStockLabel;
        private System.Windows.Forms.DataGridView myStockDataGridView;
    }
}