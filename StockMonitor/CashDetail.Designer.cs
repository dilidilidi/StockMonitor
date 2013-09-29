namespace StockMonitor
{
    partial class CashDetail
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
            this.cashDetailDataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.cashDetailDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // cashDetailDataGridView
            // 
            this.cashDetailDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.cashDetailDataGridView.Location = new System.Drawing.Point(29, 51);
            this.cashDetailDataGridView.Name = "cashDetailDataGridView";
            this.cashDetailDataGridView.RowTemplate.Height = 23;
            this.cashDetailDataGridView.Size = new System.Drawing.Size(899, 391);
            this.cashDetailDataGridView.TabIndex = 0;
            // 
            // CashDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(994, 464);
            this.Controls.Add(this.cashDetailDataGridView);
            this.Name = "CashDetail";
            this.Text = "CashDetail";
            this.Load += new System.EventHandler(this.CashDetail_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cashDetailDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView cashDetailDataGridView;
    }
}