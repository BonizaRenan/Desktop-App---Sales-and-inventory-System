namespace Sales_Inventory_System.TransactionFolder
{
    partial class StockInProduct_Insert
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StockInProduct_Insert));
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.Save_btn = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.Barcode_tb = new System.Windows.Forms.TextBox();
            this.itemName_tb = new System.Windows.Forms.TextBox();
            this.Category_tb = new System.Windows.Forms.TextBox();
            this.quantity_tb = new System.Windows.Forms.TextBox();
            this.unitPrice_tb = new System.Windows.Forms.TextBox();
            this.addquantity_tb = new System.Windows.Forms.TextBox();
            this.StockinProduct_Date = new System.Windows.Forms.DateTimePicker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.TIme_lbl = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Time = new System.Windows.Forms.Timer(this.components);
            this.errordetect = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errordetect)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(59, 219);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 24);
            this.label5.TabIndex = 6;
            this.label5.Text = "Item Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(21, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 24);
            this.label3.TabIndex = 4;
            this.label3.Text = "Barcode:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(82, 322);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(92, 24);
            this.label9.TabIndex = 10;
            this.label9.Text = "Quantity:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(73, 272);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(99, 24);
            this.label7.TabIndex = 8;
            this.label7.Text = "Category:";
            // 
            // Save_btn
            // 
            this.Save_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(110)))), ((int)(((byte)(114)))));
            this.Save_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Save_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Save_btn.ForeColor = System.Drawing.SystemColors.Control;
            this.Save_btn.Location = new System.Drawing.Point(181, 502);
            this.Save_btn.Name = "Save_btn";
            this.Save_btn.Size = new System.Drawing.Size(93, 32);
            this.Save_btn.TabIndex = 17;
            this.Save_btn.Text = "Save";
            this.Save_btn.UseVisualStyleBackColor = false;
            this.Save_btn.Click += new System.EventHandler(this.Save_btn_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(40, 436);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(136, 24);
            this.label13.TabIndex = 15;
            this.label13.Text = "Add Quantity:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(70, 381);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(106, 24);
            this.label11.TabIndex = 13;
            this.label11.Text = "Unit Price:";
            // 
            // Barcode_tb
            // 
            this.Barcode_tb.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Barcode_tb.Location = new System.Drawing.Point(121, 144);
            this.Barcode_tb.Name = "Barcode_tb";
            this.Barcode_tb.Size = new System.Drawing.Size(287, 29);
            this.Barcode_tb.TabIndex = 18;
            this.Barcode_tb.TextChanged += new System.EventHandler(this.Barcode_tb_TextChanged);
            this.Barcode_tb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Barcode_tb_KeyPress);
            // 
            // itemName_tb
            // 
            this.itemName_tb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemName_tb.Location = new System.Drawing.Point(181, 219);
            this.itemName_tb.Name = "itemName_tb";
            this.itemName_tb.Size = new System.Drawing.Size(266, 26);
            this.itemName_tb.TabIndex = 19;
            this.itemName_tb.TextChanged += new System.EventHandler(this.itemName_tb_TextChanged);
            // 
            // Category_tb
            // 
            this.Category_tb.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Category_tb.Location = new System.Drawing.Point(181, 275);
            this.Category_tb.Name = "Category_tb";
            this.Category_tb.ReadOnly = true;
            this.Category_tb.Size = new System.Drawing.Size(249, 29);
            this.Category_tb.TabIndex = 20;
            // 
            // quantity_tb
            // 
            this.quantity_tb.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quantity_tb.Location = new System.Drawing.Point(181, 321);
            this.quantity_tb.Name = "quantity_tb";
            this.quantity_tb.ReadOnly = true;
            this.quantity_tb.Size = new System.Drawing.Size(249, 29);
            this.quantity_tb.TabIndex = 21;
            // 
            // unitPrice_tb
            // 
            this.unitPrice_tb.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.unitPrice_tb.Location = new System.Drawing.Point(181, 378);
            this.unitPrice_tb.Name = "unitPrice_tb";
            this.unitPrice_tb.ReadOnly = true;
            this.unitPrice_tb.Size = new System.Drawing.Size(249, 29);
            this.unitPrice_tb.TabIndex = 22;
            // 
            // addquantity_tb
            // 
            this.addquantity_tb.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addquantity_tb.Location = new System.Drawing.Point(181, 436);
            this.addquantity_tb.Name = "addquantity_tb";
            this.addquantity_tb.Size = new System.Drawing.Size(131, 29);
            this.addquantity_tb.TabIndex = 23;
            this.addquantity_tb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.addquantity_tb_KeyPress);
            // 
            // StockinProduct_Date
            // 
            this.StockinProduct_Date.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StockinProduct_Date.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StockinProduct_Date.Location = new System.Drawing.Point(25, 77);
            this.StockinProduct_Date.Name = "StockinProduct_Date";
            this.StockinProduct_Date.Size = new System.Drawing.Size(259, 22);
            this.StockinProduct_Date.TabIndex = 24;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.TIme_lbl);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.quantity_tb);
            this.panel1.Controls.Add(this.itemName_tb);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.StockinProduct_Date);
            this.panel1.Controls.Add(this.Category_tb);
            this.panel1.Controls.Add(this.unitPrice_tb);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.Save_btn);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.addquantity_tb);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.Barcode_tb);
            this.panel1.Location = new System.Drawing.Point(23, 21);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(465, 574);
            this.panel1.TabIndex = 25;
            // 
            // TIme_lbl
            // 
            this.TIme_lbl.AutoSize = true;
            this.TIme_lbl.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.TIme_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TIme_lbl.Location = new System.Drawing.Point(71, 58);
            this.TIme_lbl.Name = "TIme_lbl";
            this.TIme_lbl.Size = new System.Drawing.Size(41, 16);
            this.TIme_lbl.TabIndex = 27;
            this.TIme_lbl.Text = "Time:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.Control;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(27, 58);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 16);
            this.label6.TabIndex = 26;
            this.label6.Text = "Time:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Elephant", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(-2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 31);
            this.label1.TabIndex = 25;
            this.label1.Text = "Insert";
            // 
            // Time
            // 
            this.Time.Enabled = true;
            this.Time.Tick += new System.EventHandler(this.Time_Tick);
            // 
            // errordetect
            // 
            this.errordetect.ContainerControl = this;
            // 
            // StockInProduct_Insert
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.ClientSize = new System.Drawing.Size(511, 597);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "StockInProduct_Insert";
            this.Text = "Insert";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errordetect)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button Save_btn;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox Barcode_tb;
        private System.Windows.Forms.TextBox itemName_tb;
        private System.Windows.Forms.TextBox Category_tb;
        private System.Windows.Forms.TextBox quantity_tb;
        private System.Windows.Forms.TextBox unitPrice_tb;
        private System.Windows.Forms.TextBox addquantity_tb;
        private System.Windows.Forms.DateTimePicker StockinProduct_Date;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label TIme_lbl;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Timer Time;
        private System.Windows.Forms.ErrorProvider errordetect;
    }
}