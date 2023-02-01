namespace Sales_Inventory_System.other_form
{
    partial class Inventory_Create
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inventory_Create));
            this.price_tb = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.quantity_tb = new System.Windows.Forms.TextBox();
            this.category_tb = new System.Windows.Forms.ComboBox();
            this.btn_Create = new System.Windows.Forms.Button();
            this.status_tb = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Name_tb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.barcode_tb = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.errordetect = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errordetect)).BeginInit();
            this.SuspendLayout();
            // 
            // price_tb
            // 
            this.price_tb.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.price_tb.Location = new System.Drawing.Point(108, 173);
            this.price_tb.Multiline = true;
            this.price_tb.Name = "price_tb";
            this.price_tb.Size = new System.Drawing.Size(235, 31);
            this.price_tb.TabIndex = 16;
            this.price_tb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.price_tb_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Elephant", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(5, 181);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 21);
            this.label6.TabIndex = 15;
            this.label6.Text = "Unit Price:";
            // 
            // quantity_tb
            // 
            this.quantity_tb.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quantity_tb.Location = new System.Drawing.Point(533, 117);
            this.quantity_tb.Multiline = true;
            this.quantity_tb.Name = "quantity_tb";
            this.quantity_tb.Size = new System.Drawing.Size(208, 31);
            this.quantity_tb.TabIndex = 14;
            this.quantity_tb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.quantity_tb_KeyPress);
            // 
            // category_tb
            // 
            this.category_tb.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.category_tb.FormattingEnabled = true;
            this.category_tb.Items.AddRange(new object[] {
            "Grains and cereals",
            "Canned goods",
            "Snacks",
            "Sweets",
            "Beverages",
            "Baby Care",
            "Milk Product",
            "Beer, Wines & Spirits"});
            this.category_tb.Location = new System.Drawing.Point(104, 119);
            this.category_tb.Name = "category_tb";
            this.category_tb.Size = new System.Drawing.Size(239, 28);
            this.category_tb.TabIndex = 13;
            this.category_tb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.category_tb_KeyPress);
            // 
            // btn_Create
            // 
            this.btn_Create.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_Create.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Create.Font = new System.Drawing.Font("Elephant", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Create.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_Create.Location = new System.Drawing.Point(304, 245);
            this.btn_Create.Name = "btn_Create";
            this.btn_Create.Size = new System.Drawing.Size(137, 37);
            this.btn_Create.TabIndex = 12;
            this.btn_Create.Text = "Create";
            this.btn_Create.UseVisualStyleBackColor = false;
            this.btn_Create.Click += new System.EventHandler(this.btn_Create_Click);
            // 
            // status_tb
            // 
            this.status_tb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.status_tb.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.status_tb.FormattingEnabled = true;
            this.status_tb.Items.AddRange(new object[] {
            "Available",
            "Out of Stock"});
            this.status_tb.Location = new System.Drawing.Point(533, 179);
            this.status_tb.Name = "status_tb";
            this.status_tb.Size = new System.Drawing.Size(208, 28);
            this.status_tb.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Elephant", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(460, 185);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 21);
            this.label5.TabIndex = 10;
            this.label5.Text = "Status:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Elephant", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(437, 128);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 21);
            this.label4.TabIndex = 8;
            this.label4.Text = "Quantity:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Elephant", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 21);
            this.label3.TabIndex = 6;
            this.label3.Text = "Category:";
            // 
            // Name_tb
            // 
            this.Name_tb.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name_tb.Location = new System.Drawing.Point(533, 64);
            this.Name_tb.Multiline = true;
            this.Name_tb.Name = "Name_tb";
            this.Name_tb.Size = new System.Drawing.Size(208, 31);
            this.Name_tb.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Elephant", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(378, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 21);
            this.label1.TabIndex = 4;
            this.label1.Text = "Name of Product:";
            // 
            // barcode_tb
            // 
            this.barcode_tb.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barcode_tb.Location = new System.Drawing.Point(104, 64);
            this.barcode_tb.Multiline = true;
            this.barcode_tb.Name = "barcode_tb";
            this.barcode_tb.Size = new System.Drawing.Size(239, 31);
            this.barcode_tb.TabIndex = 3;
            this.barcode_tb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.barcode_tb_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Elephant", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "Barcode:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.barcode_tb);
            this.panel1.Controls.Add(this.price_tb);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.quantity_tb);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.Name_tb);
            this.panel1.Controls.Add(this.category_tb);
            this.panel1.Controls.Add(this.status_tb);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btn_Create);
            this.panel1.Location = new System.Drawing.Point(23, 20);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(767, 310);
            this.panel1.TabIndex = 17;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Elephant", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(1, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(155, 31);
            this.label7.TabIndex = 17;
            this.label7.Text = "Insert Item";
            // 
            // errordetect
            // 
            this.errordetect.ContainerControl = this;
            // 
            // Inventory_Create
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.ClientSize = new System.Drawing.Size(817, 352);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Inventory_Create";
            this.Text = "Inventory_Create";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errordetect)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btn_Create;
        public System.Windows.Forms.ComboBox status_tb;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox Name_tb;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox barcode_tb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox category_tb;
        public System.Windows.Forms.TextBox quantity_tb;
        public System.Windows.Forms.TextBox price_tb;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ErrorProvider errordetect;
    }
}