namespace StockMonitor
{
    partial class StockSettings
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.stockCodeTB = new System.Windows.Forms.TextBox();
            this.inputStockButton = new System.Windows.Forms.Button();
            this.stockCodeLabel = new System.Windows.Forms.Label();
            this.stockNameTB = new System.Windows.Forms.TextBox();
            this.stockNameLabel = new System.Windows.Forms.Label();
            this.stockSettingsDataGridView = new System.Windows.Forms.DataGridView();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stockSettingsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.stockCodeTB);
            this.panel2.Controls.Add(this.inputStockButton);
            this.panel2.Controls.Add(this.stockCodeLabel);
            this.panel2.Controls.Add(this.stockNameTB);
            this.panel2.Controls.Add(this.stockNameLabel);
            this.panel2.Location = new System.Drawing.Point(36, 21);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(654, 59);
            this.panel2.TabIndex = 6;
            // 
            // stockCodeTB
            // 
            this.stockCodeTB.Location = new System.Drawing.Point(287, 15);
            this.stockCodeTB.Name = "stockCodeTB";
            this.stockCodeTB.Size = new System.Drawing.Size(100, 21);
            this.stockCodeTB.TabIndex = 7;
            // 
            // inputStockButton
            // 
            this.inputStockButton.Location = new System.Drawing.Point(432, 11);
            this.inputStockButton.Name = "inputStockButton";
            this.inputStockButton.Size = new System.Drawing.Size(127, 25);
            this.inputStockButton.TabIndex = 1;
            this.inputStockButton.Text = "输入个股";
            this.inputStockButton.UseVisualStyleBackColor = true;
            this.inputStockButton.Click += new System.EventHandler(this.inputStockButton_Click);
            // 
            // stockCodeLabel
            // 
            this.stockCodeLabel.AutoSize = true;
            this.stockCodeLabel.Location = new System.Drawing.Point(216, 24);
            this.stockCodeLabel.Name = "stockCodeLabel";
            this.stockCodeLabel.Size = new System.Drawing.Size(65, 12);
            this.stockCodeLabel.TabIndex = 6;
            this.stockCodeLabel.Text = "股票代码：";
            // 
            // stockNameTB
            // 
            this.stockNameTB.Location = new System.Drawing.Point(95, 15);
            this.stockNameTB.Name = "stockNameTB";
            this.stockNameTB.Size = new System.Drawing.Size(100, 21);
            this.stockNameTB.TabIndex = 5;
            // 
            // stockNameLabel
            // 
            this.stockNameLabel.AutoSize = true;
            this.stockNameLabel.Location = new System.Drawing.Point(24, 20);
            this.stockNameLabel.Name = "stockNameLabel";
            this.stockNameLabel.Size = new System.Drawing.Size(65, 12);
            this.stockNameLabel.TabIndex = 4;
            this.stockNameLabel.Text = "股票名称：";
            // 
            // stockSettingsDataGridView
            // 
            this.stockSettingsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.stockSettingsDataGridView.Location = new System.Drawing.Point(36, 96);
            this.stockSettingsDataGridView.Name = "stockSettingsDataGridView";
            this.stockSettingsDataGridView.RowTemplate.Height = 23;
            this.stockSettingsDataGridView.Size = new System.Drawing.Size(660, 295);
            this.stockSettingsDataGridView.TabIndex = 7;
            // 
            // StockSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(847, 413);
            this.Controls.Add(this.stockSettingsDataGridView);
            this.Controls.Add(this.panel2);
            this.Name = "StockSettings";
            this.Text = "个股设定";
            this.Load += new System.EventHandler(this.StockSettings_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stockSettingsDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox stockCodeTB;
        private System.Windows.Forms.Button inputStockButton;
        private System.Windows.Forms.Label stockCodeLabel;
        private System.Windows.Forms.TextBox stockNameTB;
        private System.Windows.Forms.Label stockNameLabel;
        private System.Windows.Forms.DataGridView stockSettingsDataGridView;
    }
}