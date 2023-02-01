namespace Sales_Inventory_System.TransactionFolder
{
    partial class StockIn_Record
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StockIn_Record));
            this.StockInTotal_dgv = new System.Windows.Forms.DataGridView();
            this.Insert_btn = new System.Windows.Forms.Button();
            this.Update_btn = new System.Windows.Forms.Button();
            this.delete_btn = new System.Windows.Forms.Button();
            this.ProductRecord_btn = new System.Windows.Forms.Button();
            this.Date = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.StockInTotal_dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // StockInTotal_dgv
            // 
            this.StockInTotal_dgv.AllowUserToAddRows = false;
            this.StockInTotal_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.StockInTotal_dgv.Location = new System.Drawing.Point(12, 46);
            this.StockInTotal_dgv.Name = "StockInTotal_dgv";
            this.StockInTotal_dgv.ReadOnly = true;
            this.StockInTotal_dgv.RowHeadersVisible = false;
            this.StockInTotal_dgv.Size = new System.Drawing.Size(968, 390);
            this.StockInTotal_dgv.TabIndex = 0;
            this.StockInTotal_dgv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.StockInTotal_dgv_CellContentClick);
            // 
            // Insert_btn
            // 
            this.Insert_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Insert_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Insert_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Insert_btn.ForeColor = System.Drawing.SystemColors.Control;
            this.Insert_btn.Location = new System.Drawing.Point(13, 443);
            this.Insert_btn.Name = "Insert_btn";
            this.Insert_btn.Size = new System.Drawing.Size(74, 28);
            this.Insert_btn.TabIndex = 1;
            this.Insert_btn.Text = "Insert";
            this.Insert_btn.UseVisualStyleBackColor = false;
            this.Insert_btn.Click += new System.EventHandler(this.Insert_btn_Click);
            // 
            // Update_btn
            // 
            this.Update_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Update_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Update_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Update_btn.ForeColor = System.Drawing.SystemColors.Control;
            this.Update_btn.Location = new System.Drawing.Point(93, 443);
            this.Update_btn.Name = "Update_btn";
            this.Update_btn.Size = new System.Drawing.Size(85, 28);
            this.Update_btn.TabIndex = 2;
            this.Update_btn.Text = "Update";
            this.Update_btn.UseVisualStyleBackColor = false;
            this.Update_btn.Click += new System.EventHandler(this.Update_btn_Click);
            // 
            // delete_btn
            // 
            this.delete_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.delete_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.delete_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delete_btn.ForeColor = System.Drawing.SystemColors.Control;
            this.delete_btn.Location = new System.Drawing.Point(184, 443);
            this.delete_btn.Name = "delete_btn";
            this.delete_btn.Size = new System.Drawing.Size(85, 28);
            this.delete_btn.TabIndex = 3;
            this.delete_btn.Text = "Delete";
            this.delete_btn.UseVisualStyleBackColor = false;
            this.delete_btn.Click += new System.EventHandler(this.delete_btn_Click);
            // 
            // ProductRecord_btn
            // 
            this.ProductRecord_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ProductRecord_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ProductRecord_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductRecord_btn.ForeColor = System.Drawing.SystemColors.Control;
            this.ProductRecord_btn.Location = new System.Drawing.Point(798, 443);
            this.ProductRecord_btn.Name = "ProductRecord_btn";
            this.ProductRecord_btn.Size = new System.Drawing.Size(182, 52);
            this.ProductRecord_btn.TabIndex = 4;
            this.ProductRecord_btn.Text = "Product Record";
            this.ProductRecord_btn.UseVisualStyleBackColor = false;
            this.ProductRecord_btn.Click += new System.EventHandler(this.ProductRecord_btn_Click);
            // 
            // Date
            // 
            this.Date.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Date.Location = new System.Drawing.Point(780, 21);
            this.Date.Name = "Date";
            this.Date.Size = new System.Drawing.Size(200, 20);
            this.Date.TabIndex = 17;
            this.Date.ValueChanged += new System.EventHandler(this.Date_ValueChanged);
            // 
            // StockIn_Record
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.ClientSize = new System.Drawing.Size(992, 532);
            this.ControlBox = false;
            this.Controls.Add(this.Date);
            this.Controls.Add(this.ProductRecord_btn);
            this.Controls.Add(this.delete_btn);
            this.Controls.Add(this.Update_btn);
            this.Controls.Add(this.Insert_btn);
            this.Controls.Add(this.StockInTotal_dgv);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "StockIn_Record";
            ((System.ComponentModel.ISupportInitialize)(this.StockInTotal_dgv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView StockInTotal_dgv;
        private System.Windows.Forms.Button Insert_btn;
        private System.Windows.Forms.Button Update_btn;
        private System.Windows.Forms.Button delete_btn;
        private System.Windows.Forms.Button ProductRecord_btn;
        private System.Windows.Forms.DateTimePicker Date;
    }
}