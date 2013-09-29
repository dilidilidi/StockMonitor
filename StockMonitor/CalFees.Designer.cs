namespace StockMonitor
{
    partial class CalFees
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.CalFeesButton = new System.Windows.Forms.Button();
            this.StockNumberTb = new System.Windows.Forms.TextBox();
            this.StockPriceTb = new System.Windows.Forms.TextBox();
            this.FeeRateTb = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.FeeTb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.CalFeesButton);
            this.panel1.Controls.Add(this.StockNumberTb);
            this.panel1.Controls.Add(this.StockPriceTb);
            this.panel1.Controls.Add(this.FeeRateTb);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.FeeTb);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(242, 213);
            this.panel1.TabIndex = 0;
            // 
            // CalFeesButton
            // 
            this.CalFeesButton.Location = new System.Drawing.Point(41, 157);
            this.CalFeesButton.Name = "CalFeesButton";
            this.CalFeesButton.Size = new System.Drawing.Size(103, 29);
            this.CalFeesButton.TabIndex = 8;
            this.CalFeesButton.Text = "计算";
            this.CalFeesButton.UseVisualStyleBackColor = true;
            this.CalFeesButton.Click += new System.EventHandler(this.CalFeesButton_Click);
            // 
            // StockNumberTb
            // 
            this.StockNumberTb.Location = new System.Drawing.Point(118, 121);
            this.StockNumberTb.Name = "StockNumberTb";
            this.StockNumberTb.Size = new System.Drawing.Size(91, 21);
            this.StockNumberTb.TabIndex = 7;
            // 
            // StockPriceTb
            // 
            this.StockPriceTb.Location = new System.Drawing.Point(118, 84);
            this.StockPriceTb.Name = "StockPriceTb";
            this.StockPriceTb.Size = new System.Drawing.Size(91, 21);
            this.StockPriceTb.TabIndex = 6;
            this.StockPriceTb.Text = "12.00";
            // 
            // FeeRateTb
            // 
            this.FeeRateTb.Location = new System.Drawing.Point(118, 48);
            this.FeeRateTb.Name = "FeeRateTb";
            this.FeeRateTb.Size = new System.Drawing.Size(91, 21);
            this.FeeRateTb.TabIndex = 5;
            this.FeeRateTb.Text = "0.0008";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(39, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 4;
            this.label4.Text = "数量：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 3;
            this.label3.Text = "价格：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "手续费费率：";
            // 
            // FeeTb
            // 
            this.FeeTb.Location = new System.Drawing.Point(118, 19);
            this.FeeTb.Name = "FeeTb";
            this.FeeTb.Size = new System.Drawing.Size(91, 21);
            this.FeeTb.TabIndex = 1;
            this.FeeTb.Text = "5.00";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "固定手续费：";
            // 
            // CalFees
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(744, 337);
            this.Controls.Add(this.panel1);
            this.Name = "CalFees";
            this.Text = "CalFees";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button CalFeesButton;
        private System.Windows.Forms.TextBox StockNumberTb;
        private System.Windows.Forms.TextBox StockPriceTb;
        private System.Windows.Forms.TextBox FeeRateTb;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox FeeTb;
        private System.Windows.Forms.Label label1;
    }
}