namespace Sales_Inventory_System.TransactionFolder
{
    partial class StockOut_Record
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
            this.delete_btn = new System.Windows.Forms.Button();
            this.Date = new System.Windows.Forms.DateTimePicker();
            this.StockOut_dgv = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.StockOut_dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // delete_btn
            // 
            this.delete_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.delete_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.delete_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delete_btn.ForeColor = System.Drawing.SystemColors.Control;
            this.delete_btn.Location = new System.Drawing.Point(12, 467);
            this.delete_btn.Name = "delete_btn";
            this.delete_btn.Size = new System.Drawing.Size(98, 36);
            this.delete_btn.TabIndex = 5;
            this.delete_btn.Text = "Delete";
            this.delete_btn.UseVisualStyleBackColor = false;
            this.delete_btn.Click += new System.EventHandler(this.delete_btn_Click);
            // 
            // Date
            // 
            this.Date.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Date.Location = new System.Drawing.Point(780, 45);
            this.Date.Name = "Date";
            this.Date.Size = new System.Drawing.Size(200, 20);
            this.Date.TabIndex = 18;
            this.Date.ValueChanged += new System.EventHandler(this.Date_ValueChanged);
            // 
            // StockOut_dgv
            // 
            this.StockOut_dgv.AllowUserToAddRows = false;
            this.StockOut_dgv.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.StockOut_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.StockOut_dgv.Location = new System.Drawing.Point(12, 84);
            this.StockOut_dgv.Name = "StockOut_dgv";
            this.StockOut_dgv.ReadOnly = true;
            this.StockOut_dgv.RowHeadersVisible = false;
            this.StockOut_dgv.Size = new System.Drawing.Size(968, 377);
            this.StockOut_dgv.TabIndex = 19;
            // 
            // StockOut_Record
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.ClientSize = new System.Drawing.Size(992, 532);
            this.ControlBox = false;
            this.Controls.Add(this.StockOut_dgv);
            this.Controls.Add(this.Date);
            this.Controls.Add(this.delete_btn);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "StockOut_Record";
            ((System.ComponentModel.ISupportInitialize)(this.StockOut_dgv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button delete_btn;
        private System.Windows.Forms.DateTimePicker Date;
        private System.Windows.Forms.DataGridView StockOut_dgv;
    }
}