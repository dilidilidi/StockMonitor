namespace StockMonitor
{
    partial class Dividend
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
            this.StockCB = new System.Windows.Forms.ComboBox();
            this.DividendDataGridView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.DividentTb = new System.Windows.Forms.TextBox();
            this.DateOfDeclarationTb = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.DateOfRecordTb = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ExDividendDateTb = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.InsertDividentBtn = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.DividendDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // StockCB
            // 
            this.StockCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.StockCB.FormattingEnabled = true;
            this.StockCB.Location = new System.Drawing.Point(12, 12);
            this.StockCB.Name = "StockCB";
            this.StockCB.Size = new System.Drawing.Size(90, 20);
            this.StockCB.TabIndex = 0;
            this.StockCB.SelectionChangeCommitted += new System.EventHandler(this.StockCB_SelectionChangeCommitted);
            // 
            // DividendDataGridView
            // 
            this.DividendDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DividendDataGridView.Location = new System.Drawing.Point(12, 282);
            this.DividendDataGridView.Name = "DividendDataGridView";
            this.DividendDataGridView.RowTemplate.Height = 23;
            this.DividendDataGridView.Size = new System.Drawing.Size(855, 294);
            this.DividendDataGridView.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(108, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "每10股红利：";
            // 
            // DividentTb
            // 
            this.DividentTb.Location = new System.Drawing.Point(191, 11);
            this.DividentTb.Name = "DividentTb";
            this.DividentTb.Size = new System.Drawing.Size(100, 21);
            this.DividentTb.TabIndex = 3;
            // 
            // DateOfDeclarationTb
            // 
            this.DateOfDeclarationTb.Location = new System.Drawing.Point(356, 9);
            this.DateOfDeclarationTb.Name = "DateOfDeclarationTb";
            this.DateOfDeclarationTb.Size = new System.Drawing.Size(151, 21);
            this.DateOfDeclarationTb.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(297, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "公告日：";
            // 
            // DateOfRecordTb
            // 
            this.DateOfRecordTb.Location = new System.Drawing.Point(631, 6);
            this.DateOfRecordTb.Name = "DateOfRecordTb";
            this.DateOfRecordTb.Size = new System.Drawing.Size(100, 21);
            this.DateOfRecordTb.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(548, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 12);
            this.label3.TabIndex = 6;
            this.label3.Text = "股权登记日：";
            // 
            // ExDividendDateTb
            // 
            this.ExDividendDateTb.Location = new System.Drawing.Point(796, 6);
            this.ExDividendDateTb.Name = "ExDividendDateTb";
            this.ExDividendDateTb.Size = new System.Drawing.Size(100, 21);
            this.ExDividendDateTb.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(737, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 8;
            this.label4.Text = "除息日：";
            // 
            // InsertDividentBtn
            // 
            this.InsertDividentBtn.Location = new System.Drawing.Point(902, 6);
            this.InsertDividentBtn.Name = "InsertDividentBtn";
            this.InsertDividentBtn.Size = new System.Drawing.Size(75, 23);
            this.InsertDividentBtn.TabIndex = 10;
            this.InsertDividentBtn.Text = "输入";
            this.InsertDividentBtn.UseVisualStyleBackColor = true;
            this.InsertDividentBtn.Click += new System.EventHandler(this.InsertDividentBtn_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(51, 89);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 21);
            this.textBox1.TabIndex = 11;
            this.textBox1.Text = "4.19";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(191, 88);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 21);
            this.textBox2.TabIndex = 12;
            this.textBox2.Text = "100";
            // 
            // Dividend
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1103, 432);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.InsertDividentBtn);
            this.Controls.Add(this.ExDividendDateTb);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.DateOfRecordTb);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.DateOfDeclarationTb);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DividentTb);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DividendDataGridView);
            this.Controls.Add(this.StockCB);
            this.Name = "Dividend";
            this.Text = "Dividend";
            this.Load += new System.EventHandler(this.Dividend_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DividendDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox StockCB;
        private System.Windows.Forms.DataGridView DividendDataGridView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox DividentTb;
        private System.Windows.Forms.TextBox DateOfDeclarationTb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox DateOfRecordTb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox ExDividendDateTb;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button InsertDividentBtn;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
    }
}