namespace Sales_Inventory_System.Employee_Record
{
    partial class Employee_StockIn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Employee_StockIn));
            this.Transaction_dgv = new System.Windows.Forms.DataGridView();
            this.Date = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.Transaction_dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // Transaction_dgv
            // 
            this.Transaction_dgv.AllowUserToAddRows = false;
            this.Transaction_dgv.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Transaction_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Transaction_dgv.Location = new System.Drawing.Point(2, 58);
            this.Transaction_dgv.Name = "Transaction_dgv";
            this.Transaction_dgv.ReadOnly = true;
            this.Transaction_dgv.RowHeadersVisible = false;
            this.Transaction_dgv.Size = new System.Drawing.Size(1153, 443);
            this.Transaction_dgv.TabIndex = 18;
            // 
            // Date
            // 
            this.Date.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Date.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Date.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Date.Location = new System.Drawing.Point(916, 26);
            this.Date.Name = "Date";
            this.Date.Size = new System.Drawing.Size(235, 22);
            this.Date.TabIndex = 19;
            this.Date.ValueChanged += new System.EventHandler(this.Date_ValueChanged);
            // 
            // Employee_StockIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.ClientSize = new System.Drawing.Size(1157, 559);
            this.ControlBox = false;
            this.Controls.Add(this.Transaction_dgv);
            this.Controls.Add(this.Date);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Employee_StockIn";
            ((System.ComponentModel.ISupportInitialize)(this.Transaction_dgv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView Transaction_dgv;
        private System.Windows.Forms.DateTimePicker Date;
    }
}