namespace Sales_Inventory_System
{
    partial class Employee_SellProduct
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.Searchbar_tb = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.unitPrice_lbl = new System.Windows.Forms.TextBox();
            this.quantity_lbl = new System.Windows.Forms.TextBox();
            this.Category_lbl = new System.Windows.Forms.TextBox();
            this.itemName_lbl = new System.Windows.Forms.TextBox();
            this.barcode_lbl = new System.Windows.Forms.TextBox();
            this.Save_btn = new System.Windows.Forms.Button();
            this.Minusquantity_tb = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.amount_lbl = new System.Windows.Forms.Label();
            this.SellProduct_dgv = new System.Windows.Forms.DataGridView();
            this.Date = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.Amount = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.TIme_lbl = new System.Windows.Forms.Label();
            this.Time = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SellProduct_dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1179, 58);
            this.panel1.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Elephant", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(2, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(233, 51);
            this.label1.TabIndex = 0;
            this.label1.Text = "Stock-Out";
            // 
            // Searchbar_tb
            // 
            this.Searchbar_tb.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Searchbar_tb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Searchbar_tb.Location = new System.Drawing.Point(103, 76);
            this.Searchbar_tb.Multiline = true;
            this.Searchbar_tb.Name = "Searchbar_tb";
            this.Searchbar_tb.Size = new System.Drawing.Size(283, 29);
            this.Searchbar_tb.TabIndex = 10;
            this.Searchbar_tb.TextChanged += new System.EventHandler(this.Searchbar_tb_TextChanged);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Elephant", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(10, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 27);
            this.label2.TabIndex = 11;
            this.label2.Text = "Search:";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(190)))), ((int)(((byte)(195)))));
            this.groupBox1.Controls.Add(this.unitPrice_lbl);
            this.groupBox1.Controls.Add(this.quantity_lbl);
            this.groupBox1.Controls.Add(this.Category_lbl);
            this.groupBox1.Controls.Add(this.itemName_lbl);
            this.groupBox1.Controls.Add(this.barcode_lbl);
            this.groupBox1.Controls.Add(this.Save_btn);
            this.groupBox1.Controls.Add(this.Minusquantity_tb);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(11, 526);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1155, 151);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Input of Product";
            // 
            // unitPrice_lbl
            // 
            this.unitPrice_lbl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(190)))), ((int)(((byte)(195)))));
            this.unitPrice_lbl.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.unitPrice_lbl.Location = new System.Drawing.Point(906, 40);
            this.unitPrice_lbl.Name = "unitPrice_lbl";
            this.unitPrice_lbl.ReadOnly = true;
            this.unitPrice_lbl.Size = new System.Drawing.Size(215, 22);
            this.unitPrice_lbl.TabIndex = 19;
            // 
            // quantity_lbl
            // 
            this.quantity_lbl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(190)))), ((int)(((byte)(195)))));
            this.quantity_lbl.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.quantity_lbl.Location = new System.Drawing.Point(493, 82);
            this.quantity_lbl.Name = "quantity_lbl";
            this.quantity_lbl.ReadOnly = true;
            this.quantity_lbl.Size = new System.Drawing.Size(247, 22);
            this.quantity_lbl.TabIndex = 18;
            // 
            // Category_lbl
            // 
            this.Category_lbl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(190)))), ((int)(((byte)(195)))));
            this.Category_lbl.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Category_lbl.Location = new System.Drawing.Point(493, 43);
            this.Category_lbl.Name = "Category_lbl";
            this.Category_lbl.ReadOnly = true;
            this.Category_lbl.Size = new System.Drawing.Size(247, 22);
            this.Category_lbl.TabIndex = 17;
            // 
            // itemName_lbl
            // 
            this.itemName_lbl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(190)))), ((int)(((byte)(195)))));
            this.itemName_lbl.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.itemName_lbl.Location = new System.Drawing.Point(131, 80);
            this.itemName_lbl.Name = "itemName_lbl";
            this.itemName_lbl.ReadOnly = true;
            this.itemName_lbl.Size = new System.Drawing.Size(210, 22);
            this.itemName_lbl.TabIndex = 16;
            // 
            // barcode_lbl
            // 
            this.barcode_lbl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(190)))), ((int)(((byte)(195)))));
            this.barcode_lbl.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.barcode_lbl.Location = new System.Drawing.Point(131, 40);
            this.barcode_lbl.Name = "barcode_lbl";
            this.barcode_lbl.ReadOnly = true;
            this.barcode_lbl.Size = new System.Drawing.Size(210, 22);
            this.barcode_lbl.TabIndex = 15;
            // 
            // Save_btn
            // 
            this.Save_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Save_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Save_btn.ForeColor = System.Drawing.Color.White;
            this.Save_btn.Location = new System.Drawing.Point(1039, 80);
            this.Save_btn.Name = "Save_btn";
            this.Save_btn.Size = new System.Drawing.Size(69, 29);
            this.Save_btn.TabIndex = 12;
            this.Save_btn.Text = "Save";
            this.Save_btn.UseVisualStyleBackColor = false;
            this.Save_btn.Click += new System.EventHandler(this.Save_btn_Click);
            // 
            // Minusquantity_tb
            // 
            this.Minusquantity_tb.Location = new System.Drawing.Point(906, 80);
            this.Minusquantity_tb.Name = "Minusquantity_tb";
            this.Minusquantity_tb.Size = new System.Drawing.Size(127, 29);
            this.Minusquantity_tb.TabIndex = 11;
            this.Minusquantity_tb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Minusquantity_tb_KeyPress);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(773, 85);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(133, 24);
            this.label13.TabIndex = 10;
            this.label13.Text = "Sell Quantity:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(803, 43);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(106, 24);
            this.label11.TabIndex = 8;
            this.label11.Text = "Unit Price:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(395, 85);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(92, 24);
            this.label9.TabIndex = 6;
            this.label9.Text = "Quantity:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(388, 43);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(99, 24);
            this.label7.TabIndex = 4;
            this.label7.Text = "Category:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 85);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 24);
            this.label5.TabIndex = 2;
            this.label5.Text = "Item Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 24);
            this.label3.TabIndex = 0;
            this.label3.Text = "Barcode:";
            // 
            // amount_lbl
            // 
            this.amount_lbl.AutoSize = true;
            this.amount_lbl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(190)))), ((int)(((byte)(195)))));
            this.amount_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.amount_lbl.ForeColor = System.Drawing.Color.Black;
            this.amount_lbl.Location = new System.Drawing.Point(857, 644);
            this.amount_lbl.Name = "amount_lbl";
            this.amount_lbl.Size = new System.Drawing.Size(121, 33);
            this.amount_lbl.TabIndex = 14;
            this.amount_lbl.Text = "Amount";
            // 
            // SellProduct_dgv
            // 
            this.SellProduct_dgv.AllowUserToAddRows = false;
            this.SellProduct_dgv.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.SellProduct_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SellProduct_dgv.Location = new System.Drawing.Point(9, 112);
            this.SellProduct_dgv.Name = "SellProduct_dgv";
            this.SellProduct_dgv.ReadOnly = true;
            this.SellProduct_dgv.RowHeadersVisible = false;
            this.SellProduct_dgv.Size = new System.Drawing.Size(1155, 403);
            this.SellProduct_dgv.TabIndex = 8;
            this.SellProduct_dgv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.SellProduct_dgv_CellClick);
            // 
            // Date
            // 
            this.Date.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Date.Location = new System.Drawing.Point(980, 86);
            this.Date.Name = "Date";
            this.Date.Size = new System.Drawing.Size(184, 20);
            this.Date.TabIndex = 1;
            this.Date.ValueChanged += new System.EventHandler(this.Date_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(936, 672);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 13);
            this.label4.TabIndex = 14;
            // 
            // Amount
            // 
            this.Amount.AutoSize = true;
            this.Amount.Location = new System.Drawing.Point(824, 672);
            this.Amount.Name = "Amount";
            this.Amount.Size = new System.Drawing.Size(0, 13);
            this.Amount.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(977, 67);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 16);
            this.label6.TabIndex = 15;
            this.label6.Text = "Time:";
            // 
            // TIme_lbl
            // 
            this.TIme_lbl.AutoSize = true;
            this.TIme_lbl.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.TIme_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TIme_lbl.Location = new System.Drawing.Point(1024, 67);
            this.TIme_lbl.Name = "TIme_lbl";
            this.TIme_lbl.Size = new System.Drawing.Size(41, 16);
            this.TIme_lbl.TabIndex = 16;
            this.TIme_lbl.Text = "Time:";
            // 
            // Time
            // 
            this.Time.Enabled = true;
            this.Time.Tick += new System.EventHandler(this.Time_Tick);
            // 
            // Employee_SellProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(1179, 705);
            this.ControlBox = false;
            this.Controls.Add(this.TIme_lbl);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Amount);
            this.Controls.Add(this.Date);
            this.Controls.Add(this.amount_lbl);
            this.Controls.Add(this.Searchbar_tb);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.SellProduct_dgv);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Employee_SellProduct";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Employee_SellProduct_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SellProduct_dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Searchbar_tb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button Save_btn;
        private System.Windows.Forms.TextBox Minusquantity_tb;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView SellProduct_dgv;
        private System.Windows.Forms.DateTimePicker Date;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label Amount;
        private System.Windows.Forms.Label amount_lbl;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label TIme_lbl;
        private System.Windows.Forms.Timer Time;
        private System.Windows.Forms.TextBox unitPrice_lbl;
        private System.Windows.Forms.TextBox quantity_lbl;
        private System.Windows.Forms.TextBox Category_lbl;
        private System.Windows.Forms.TextBox itemName_lbl;
        private System.Windows.Forms.TextBox barcode_lbl;
    }
}