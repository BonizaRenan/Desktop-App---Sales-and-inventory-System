namespace Sales_Inventory_System.SalesFolder
{
    partial class Sales_Export
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Sales_Export));
            this.label3 = new System.Windows.Forms.Label();
            this.Print_btn = new System.Windows.Forms.Button();
            this.TotalAmount_lbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Export_dgv = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.Profit_lbl = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Income_lbl = new System.Windows.Forms.TextBox();
            this.Selection_btn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.Export_dgv)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Elephant", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(-2, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(284, 51);
            this.label3.TabIndex = 9;
            this.label3.Text = "Export Data";
            // 
            // Print_btn
            // 
            this.Print_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Print_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Print_btn.ForeColor = System.Drawing.Color.White;
            this.Print_btn.Location = new System.Drawing.Point(880, 450);
            this.Print_btn.Name = "Print_btn";
            this.Print_btn.Size = new System.Drawing.Size(76, 52);
            this.Print_btn.TabIndex = 8;
            this.Print_btn.Text = "Print";
            this.Print_btn.UseVisualStyleBackColor = false;
            this.Print_btn.Click += new System.EventHandler(this.Print_btn_Click);
            // 
            // TotalAmount_lbl
            // 
            this.TotalAmount_lbl.AutoSize = true;
            this.TotalAmount_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalAmount_lbl.ForeColor = System.Drawing.Color.Black;
            this.TotalAmount_lbl.Location = new System.Drawing.Point(323, 450);
            this.TotalAmount_lbl.Name = "TotalAmount_lbl";
            this.TotalAmount_lbl.Size = new System.Drawing.Size(111, 25);
            this.TotalAmount_lbl.TabIndex = 7;
            this.TotalAmount_lbl.Text = "***********";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 450);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(290, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "Total Inventory Sell Value:";
            // 
            // Export_dgv
            // 
            this.Export_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Export_dgv.Location = new System.Drawing.Point(32, 74);
            this.Export_dgv.Name = "Export_dgv";
            this.Export_dgv.ReadOnly = true;
            this.Export_dgv.Size = new System.Drawing.Size(925, 363);
            this.Export_dgv.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(155, 495);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(162, 25);
            this.label4.TabIndex = 10;
            this.label4.Text = "Total Grocery:";
            // 
            // Profit_lbl
            // 
            this.Profit_lbl.AutoSize = true;
            this.Profit_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Profit_lbl.ForeColor = System.Drawing.Color.Black;
            this.Profit_lbl.Location = new System.Drawing.Point(323, 539);
            this.Profit_lbl.Name = "Profit_lbl";
            this.Profit_lbl.Size = new System.Drawing.Size(111, 25);
            this.Profit_lbl.TabIndex = 13;
            this.Profit_lbl.Text = "***********";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(242, 539);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 25);
            this.label6.TabIndex = 12;
            this.label6.Text = "Profit:";
            // 
            // Income_lbl
            // 
            this.Income_lbl.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.Income_lbl.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Income_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Income_lbl.ForeColor = System.Drawing.Color.Black;
            this.Income_lbl.Location = new System.Drawing.Point(323, 495);
            this.Income_lbl.Multiline = true;
            this.Income_lbl.Name = "Income_lbl";
            this.Income_lbl.ReadOnly = true;
            this.Income_lbl.Size = new System.Drawing.Size(160, 23);
            this.Income_lbl.TabIndex = 15;
            this.Income_lbl.Text = "***********";
            // 
            // Selection_btn
            // 
            this.Selection_btn.Location = new System.Drawing.Point(323, 495);
            this.Selection_btn.Name = "Selection_btn";
            this.Selection_btn.Size = new System.Drawing.Size(138, 23);
            this.Selection_btn.TabIndex = 16;
            this.Selection_btn.Text = "Select Total Grocery";
            this.Selection_btn.UseVisualStyleBackColor = true;
            this.Selection_btn.Click += new System.EventHandler(this.Selection_btn_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(-3, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(959, 64);
            this.panel1.TabIndex = 17;
            // 
            // Sales_Export
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(995, 607);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Selection_btn);
            this.Controls.Add(this.Income_lbl);
            this.Controls.Add(this.Profit_lbl);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Print_btn);
            this.Controls.Add(this.TotalAmount_lbl);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Export_dgv);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Sales_Export";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sales_Export";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Sales_Export_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.Export_dgv)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Print_btn;
        private System.Windows.Forms.Label TotalAmount_lbl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView Export_dgv;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label Profit_lbl;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox Income_lbl;
        private System.Windows.Forms.Button Selection_btn;
        private System.Windows.Forms.Panel panel1;
    }
}