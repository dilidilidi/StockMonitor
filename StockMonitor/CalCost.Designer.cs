namespace StockMonitor
{
    partial class CalCost
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
            this.stockNameLabel = new System.Windows.Forms.Label();
            this.stockNumberLabel = new System.Windows.Forms.Label();
            this.stockPerCostLabel = new System.Windows.Forms.Label();
            this.stockNumberTB = new System.Windows.Forms.TextBox();
            this.stockPerCostTB = new System.Windows.Forms.TextBox();
            this.stockTotelCostLabel = new System.Windows.Forms.Label();
            this.stockTotelCostTB = new System.Windows.Forms.TextBox();
            this.calCostButton = new System.Windows.Forms.Button();
            this.calCostStockCB = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.calCostdataGridView = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.calCostdataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // stockNameLabel
            // 
            this.stockNameLabel.AutoSize = true;
            this.stockNameLabel.Location = new System.Drawing.Point(6, 18);
            this.stockNameLabel.Name = "stockNameLabel";
            this.stockNameLabel.Size = new System.Drawing.Size(65, 12);
            this.stockNameLabel.TabIndex = 0;
            this.stockNameLabel.Text = "股票名称：";
            // 
            // stockNumberLabel
            // 
            this.stockNumberLabel.AutoSize = true;
            this.stockNumberLabel.Location = new System.Drawing.Point(200, 13);
            this.stockNumberLabel.Name = "stockNumberLabel";
            this.stockNumberLabel.Size = new System.Drawing.Size(65, 12);
            this.stockNumberLabel.TabIndex = 1;
            this.stockNumberLabel.Text = "持有数量：";
            // 
            // stockPerCostLabel
            // 
            this.stockPerCostLabel.AutoSize = true;
            this.stockPerCostLabel.Location = new System.Drawing.Point(369, 12);
            this.stockPerCostLabel.Name = "stockPerCostLabel";
            this.stockPerCostLabel.Size = new System.Drawing.Size(65, 12);
            this.stockPerCostLabel.TabIndex = 2;
            this.stockPerCostLabel.Text = "平均成本：";
            // 
            // stockNumberTB
            // 
            this.stockNumberTB.Location = new System.Drawing.Point(263, 9);
            this.stockNumberTB.Name = "stockNumberTB";
            this.stockNumberTB.Size = new System.Drawing.Size(100, 21);
            this.stockNumberTB.TabIndex = 4;
            // 
            // stockPerCostTB
            // 
            this.stockPerCostTB.Location = new System.Drawing.Point(440, 4);
            this.stockPerCostTB.Name = "stockPerCostTB";
            this.stockPerCostTB.Size = new System.Drawing.Size(100, 21);
            this.stockPerCostTB.TabIndex = 5;
            // 
            // stockTotelCostLabel
            // 
            this.stockTotelCostLabel.AutoSize = true;
            this.stockTotelCostLabel.Location = new System.Drawing.Point(546, 10);
            this.stockTotelCostLabel.Name = "stockTotelCostLabel";
            this.stockTotelCostLabel.Size = new System.Drawing.Size(71, 12);
            this.stockTotelCostLabel.TabIndex = 6;
            this.stockTotelCostLabel.Text = "持有总金额:";
            // 
            // stockTotelCostTB
            // 
            this.stockTotelCostTB.Location = new System.Drawing.Point(623, 4);
            this.stockTotelCostTB.Name = "stockTotelCostTB";
            this.stockTotelCostTB.Size = new System.Drawing.Size(100, 21);
            this.stockTotelCostTB.TabIndex = 7;
            // 
            // calCostButton
            // 
            this.calCostButton.Location = new System.Drawing.Point(729, 2);
            this.calCostButton.Name = "calCostButton";
            this.calCostButton.Size = new System.Drawing.Size(103, 28);
            this.calCostButton.TabIndex = 8;
            this.calCostButton.Text = "成本查询";
            this.calCostButton.UseVisualStyleBackColor = true;
            this.calCostButton.Click += new System.EventHandler(this.calCostButton_Click);
            // 
            // calCostStockCB
            // 
            this.calCostStockCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.calCostStockCB.FormattingEnabled = true;
            this.calCostStockCB.Location = new System.Drawing.Point(70, 10);
            this.calCostStockCB.Name = "calCostStockCB";
            this.calCostStockCB.Size = new System.Drawing.Size(121, 20);
            this.calCostStockCB.TabIndex = 9;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.stockNameLabel);
            this.panel1.Controls.Add(this.calCostButton);
            this.panel1.Controls.Add(this.calCostStockCB);
            this.panel1.Controls.Add(this.stockTotelCostTB);
            this.panel1.Controls.Add(this.stockNumberLabel);
            this.panel1.Controls.Add(this.stockTotelCostLabel);
            this.panel1.Controls.Add(this.stockNumberTB);
            this.panel1.Controls.Add(this.stockPerCostTB);
            this.panel1.Controls.Add(this.stockPerCostLabel);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(869, 47);
            this.panel1.TabIndex = 10;
            // 
            // calCostdataGridView
            // 
            this.calCostdataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.calCostdataGridView.Location = new System.Drawing.Point(12, 66);
            this.calCostdataGridView.Name = "calCostdataGridView";
            this.calCostdataGridView.RowTemplate.Height = 23;
            this.calCostdataGridView.Size = new System.Drawing.Size(1077, 266);
            this.calCostdataGridView.TabIndex = 11;
            // 
            // CalCost
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1071, 356);
            this.Controls.Add(this.calCostdataGridView);
            this.Controls.Add(this.panel1);
            this.Name = "CalCost";
            this.Text = "成本计算";
            this.Load += new System.EventHandler(this.CalCost_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.calCostdataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label stockNameLabel;
        private System.Windows.Forms.Label stockNumberLabel;
        private System.Windows.Forms.Label stockPerCostLabel;
        private System.Windows.Forms.TextBox stockNumberTB;
        private System.Windows.Forms.TextBox stockPerCostTB;
        private System.Windows.Forms.Label stockTotelCostLabel;
        private System.Windows.Forms.TextBox stockTotelCostTB;
        private System.Windows.Forms.Button calCostButton;
        private System.Windows.Forms.ComboBox calCostStockCB;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView calCostdataGridView;
    }
}