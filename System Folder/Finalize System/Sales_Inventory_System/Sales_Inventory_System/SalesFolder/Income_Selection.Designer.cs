namespace Sales_Inventory_System.SalesFolder
{
    partial class Income_Selection
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Income_Selection));
            this.TotalAmount_tb = new System.Windows.Forms.TextBox();
            this.StockInTotal_dgv = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.StockInTotal_dgv)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TotalAmount_tb
            // 
            this.TotalAmount_tb.BackColor = System.Drawing.SystemColors.Control;
            this.TotalAmount_tb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TotalAmount_tb.Location = new System.Drawing.Point(19, 52);
            this.TotalAmount_tb.Name = "TotalAmount_tb";
            this.TotalAmount_tb.ReadOnly = true;
            this.TotalAmount_tb.Size = new System.Drawing.Size(135, 13);
            this.TotalAmount_tb.TabIndex = 2;
            // 
            // StockInTotal_dgv
            // 
            this.StockInTotal_dgv.AllowUserToAddRows = false;
            this.StockInTotal_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.StockInTotal_dgv.Location = new System.Drawing.Point(19, 71);
            this.StockInTotal_dgv.Name = "StockInTotal_dgv";
            this.StockInTotal_dgv.ReadOnly = true;
            this.StockInTotal_dgv.RowHeadersVisible = false;
            this.StockInTotal_dgv.Size = new System.Drawing.Size(433, 325);
            this.StockInTotal_dgv.TabIndex = 1;
            this.StockInTotal_dgv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.StockInTotal_dgv_CellClick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.StockInTotal_dgv);
            this.panel1.Controls.Add(this.TotalAmount_tb);
            this.panel1.Location = new System.Drawing.Point(23, 40);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(473, 414);
            this.panel1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Elephant", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(283, 31);
            this.label1.TabIndex = 3;
            this.label1.Text = "Select Total Grocery";
            // 
            // Income_Selection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.ClientSize = new System.Drawing.Size(523, 476);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Income_Selection";
            this.Text = "Income_Selection";
            this.Load += new System.EventHandler(this.Income_Selection_Load);
            ((System.ComponentModel.ISupportInitialize)(this.StockInTotal_dgv)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        public System.Windows.Forms.TextBox TotalAmount_tb;
        private System.Windows.Forms.DataGridView StockInTotal_dgv;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
    }
}