namespace StockMonitor
{
    partial class ReverseRepo
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
            this.label1 = new System.Windows.Forms.Label();
            this.PrincipalTb = new System.Windows.Forms.TextBox();
            this.DailyInterestRateTb = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.InterestPerDiemTb = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.AnnualInterestRateTb = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.CalBtn = new System.Windows.Forms.Button();
            this.AnnualCompoundRateTb = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(74, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "本金：";
            // 
            // PrincipalTb
            // 
            this.PrincipalTb.Location = new System.Drawing.Point(133, 43);
            this.PrincipalTb.Name = "PrincipalTb";
            this.PrincipalTb.Size = new System.Drawing.Size(100, 21);
            this.PrincipalTb.TabIndex = 1;
            this.PrincipalTb.Text = "10000";
            // 
            // DailyInterestRateTb
            // 
            this.DailyInterestRateTb.Location = new System.Drawing.Point(360, 184);
            this.DailyInterestRateTb.Name = "DailyInterestRateTb";
            this.DailyInterestRateTb.Size = new System.Drawing.Size(100, 21);
            this.DailyInterestRateTb.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(301, 184);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "日利率：";
            // 
            // InterestPerDiemTb
            // 
            this.InterestPerDiemTb.Location = new System.Drawing.Point(144, 184);
            this.InterestPerDiemTb.Name = "InterestPerDiemTb";
            this.InterestPerDiemTb.Size = new System.Drawing.Size(100, 21);
            this.InterestPerDiemTb.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(85, 184);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "日息：";
            // 
            // AnnualInterestRateTb
            // 
            this.AnnualInterestRateTb.Location = new System.Drawing.Point(133, 87);
            this.AnnualInterestRateTb.Name = "AnnualInterestRateTb";
            this.AnnualInterestRateTb.Size = new System.Drawing.Size(100, 21);
            this.AnnualInterestRateTb.TabIndex = 7;
            this.AnnualInterestRateTb.Text = "0.07";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(74, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 12);
            this.label4.TabIndex = 6;
            this.label4.Text = "年化利率：";
            // 
            // CalBtn
            // 
            this.CalBtn.Location = new System.Drawing.Point(133, 134);
            this.CalBtn.Name = "CalBtn";
            this.CalBtn.Size = new System.Drawing.Size(75, 23);
            this.CalBtn.TabIndex = 8;
            this.CalBtn.Text = "计算";
            this.CalBtn.UseVisualStyleBackColor = true;
            this.CalBtn.Click += new System.EventHandler(this.CalBtn_Click);
            // 
            // AnnualCompoundRateTb
            // 
            this.AnnualCompoundRateTb.Location = new System.Drawing.Point(156, 260);
            this.AnnualCompoundRateTb.Name = "AnnualCompoundRateTb";
            this.AnnualCompoundRateTb.Size = new System.Drawing.Size(421, 21);
            this.AnnualCompoundRateTb.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(85, 263);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 12);
            this.label5.TabIndex = 9;
            this.label5.Text = "年复利率：";
            // 
            // ReverseRepo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(772, 382);
            this.Controls.Add(this.AnnualCompoundRateTb);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.CalBtn);
            this.Controls.Add(this.AnnualInterestRateTb);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.InterestPerDiemTb);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.DailyInterestRateTb);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.PrincipalTb);
            this.Controls.Add(this.label1);
            this.Name = "ReverseRepo";
            this.Text = "ReverseRepo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox PrincipalTb;
        private System.Windows.Forms.TextBox DailyInterestRateTb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox InterestPerDiemTb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox AnnualInterestRateTb;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button CalBtn;
        private System.Windows.Forms.TextBox AnnualCompoundRateTb;
        private System.Windows.Forms.Label label5;
    }
}