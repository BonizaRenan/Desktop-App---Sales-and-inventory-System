namespace Sales_Inventory_System.SalesFolder
{
    partial class Customize_Sale
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Customize_Sale));
            this.Transact_dgv = new System.Windows.Forms.DataGridView();
            this.search_btn = new System.Windows.Forms.Button();
            this.rodate = new System.Windows.Forms.Label();
            this.From = new System.Windows.Forms.Label();
            this.Date2 = new System.Windows.Forms.DateTimePicker();
            this.Date1 = new System.Windows.Forms.DateTimePicker();
            this.Export_btn = new System.Windows.Forms.Button();
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
            this.Transact_dgv.TabIndex = 0;
            // 
            // search_btn
            // 
            this.search_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.search_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.search_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search_btn.ForeColor = System.Drawing.SystemColors.Control;
            this.search_btn.Location = new System.Drawing.Point(785, 447);
            this.search_btn.Name = "search_btn";
            this.search_btn.Size = new System.Drawing.Size(145, 34);
            this.search_btn.TabIndex = 15;
            this.search_btn.Text = "Search Date";
            this.search_btn.UseVisualStyleBackColor = false;
            this.search_btn.Click += new System.EventHandler(this.search_btn_Click);
            // 
            // rodate
            // 
            this.rodate.AutoSize = true;
            this.rodate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rodate.Location = new System.Drawing.Point(574, 427);
            this.rodate.Name = "rodate";
            this.rodate.Size = new System.Drawing.Size(78, 20);
            this.rodate.TabIndex = 14;
            this.rodate.Text = "To Date:";
            // 
            // From
            // 
            this.From.AutoSize = true;
            this.From.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.From.Location = new System.Drawing.Point(197, 427);
            this.From.Name = "From";
            this.From.Size = new System.Drawing.Size(99, 20);
            this.From.TabIndex = 13;
            this.From.Text = "From Date:";
            // 
            // Date2
            // 
            this.Date2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Date2.Location = new System.Drawing.Point(476, 450);
            this.Date2.Name = "Date2";
            this.Date2.Size = new System.Drawing.Size(284, 26);
            this.Date2.TabIndex = 12;
            // 
            // Date1
            // 
            this.Date1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Date1.Location = new System.Drawing.Point(104, 450);
            this.Date1.Name = "Date1";
            this.Date1.Size = new System.Drawing.Size(300, 26);
            this.Date1.TabIndex = 11;
            // 
            // Export_btn
            // 
            this.Export_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Export_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Export_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Export_btn.ForeColor = System.Drawing.SystemColors.Control;
            this.Export_btn.Location = new System.Drawing.Point(12, 385);
            this.Export_btn.Name = "Export_btn";
            this.Export_btn.Size = new System.Drawing.Size(70, 41);
            this.Export_btn.TabIndex = 10;
            this.Export_btn.Text = "Export";
            this.Export_btn.UseVisualStyleBackColor = false;
            this.Export_btn.Click += new System.EventHandler(this.Export_btn_Click);
            // 
            // Customize_Sale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.ClientSize = new System.Drawing.Size(994, 538);
            this.ControlBox = false;
            this.Controls.Add(this.search_btn);
            this.Controls.Add(this.rodate);
            this.Controls.Add(this.From);
            this.Controls.Add(this.Date2);
            this.Controls.Add(this.Date1);
            this.Controls.Add(this.Export_btn);
            this.Controls.Add(this.Transact_dgv);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Customize_Sale";
            ((System.ComponentModel.ISupportInitialize)(this.Transact_dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView Transact_dgv;
        private System.Windows.Forms.Button search_btn;
        private System.Windows.Forms.Label rodate;
        private System.Windows.Forms.Label From;
        private System.Windows.Forms.DateTimePicker Date2;
        private System.Windows.Forms.DateTimePicker Date1;
        private System.Windows.Forms.Button Export_btn;
    }
}