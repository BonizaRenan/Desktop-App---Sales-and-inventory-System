namespace Sales_Inventory_System.SalesFolder
{
    partial class Daily_Sale
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Daily_Sale));
            this.Transact_dgv = new System.Windows.Forms.DataGridView();
            this.TotalAmount_lbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Transact_dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // Transact_dgv
            // 
            this.Transact_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Transact_dgv.Location = new System.Drawing.Point(11, 23);
            this.Transact_dgv.Name = "Transact_dgv";
            this.Transact_dgv.ReadOnly = true;
            this.Transact_dgv.RowHeadersVisible = false;
            this.Transact_dgv.Size = new System.Drawing.Size(970, 356);
            this.Transact_dgv.TabIndex = 8;
            // 
            // TotalAmount_lbl
            // 
            this.TotalAmount_lbl.AutoSize = true;
            this.TotalAmount_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalAmount_lbl.ForeColor = System.Drawing.Color.Black;
            this.TotalAmount_lbl.Location = new System.Drawing.Point(176, 395);
            this.TotalAmount_lbl.Name = "TotalAmount_lbl";
            this.TotalAmount_lbl.Size = new System.Drawing.Size(57, 25);
            this.TotalAmount_lbl.TabIndex = 12;
            this.TotalAmount_lbl.Text = "*****";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 395);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 25);
            this.label1.TabIndex = 11;
            this.label1.Text = "Total Amount:";
            // 
            // Daily_Sale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.ClientSize = new System.Drawing.Size(994, 538);
            this.ControlBox = false;
            this.Controls.Add(this.TotalAmount_lbl);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Transact_dgv);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Daily_Sale";
            this.Load += new System.EventHandler(this.Daily_Sale_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Transact_dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView Transact_dgv;
        private System.Windows.Forms.Label TotalAmount_lbl;
        private System.Windows.Forms.Label label1;
    }
}