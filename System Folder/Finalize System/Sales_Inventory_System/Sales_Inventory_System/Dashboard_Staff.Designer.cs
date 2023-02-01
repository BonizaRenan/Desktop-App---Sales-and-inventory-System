namespace Sales_Inventory_System
{
    partial class Dashboard_Staff
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard_Staff));
            this.sellproduct_btn = new System.Windows.Forms.Button();
            this.addproduct_btn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Staff_Name_lbl = new System.Windows.Forms.Label();
            this.Logout_btn = new System.Windows.Forms.LinkLabel();
            this.TransactionRecord_btn = new System.Windows.Forms.Button();
            this.form_panels = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // sellproduct_btn
            // 
            this.sellproduct_btn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.sellproduct_btn.BackColor = System.Drawing.Color.MediumAquamarine;
            this.sellproduct_btn.FlatAppearance.BorderSize = 0;
            this.sellproduct_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.sellproduct_btn.Font = new System.Drawing.Font("Elephant", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sellproduct_btn.ForeColor = System.Drawing.SystemColors.Control;
            this.sellproduct_btn.Image = ((System.Drawing.Image)(resources.GetObject("sellproduct_btn.Image")));
            this.sellproduct_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.sellproduct_btn.Location = new System.Drawing.Point(2, 311);
            this.sellproduct_btn.Name = "sellproduct_btn";
            this.sellproduct_btn.Size = new System.Drawing.Size(230, 83);
            this.sellproduct_btn.TabIndex = 6;
            this.sellproduct_btn.Text = "Stock-Out";
            this.sellproduct_btn.UseVisualStyleBackColor = false;
            this.sellproduct_btn.Click += new System.EventHandler(this.sellproduct_btn_Click);
            // 
            // addproduct_btn
            // 
            this.addproduct_btn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.addproduct_btn.BackColor = System.Drawing.Color.MediumAquamarine;
            this.addproduct_btn.FlatAppearance.BorderSize = 0;
            this.addproduct_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.addproduct_btn.Font = new System.Drawing.Font("Elephant", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addproduct_btn.ForeColor = System.Drawing.SystemColors.Control;
            this.addproduct_btn.Image = ((System.Drawing.Image)(resources.GetObject("addproduct_btn.Image")));
            this.addproduct_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addproduct_btn.Location = new System.Drawing.Point(2, 228);
            this.addproduct_btn.Name = "addproduct_btn";
            this.addproduct_btn.Size = new System.Drawing.Size(207, 83);
            this.addproduct_btn.TabIndex = 5;
            this.addproduct_btn.Text = "Stock-In";
            this.addproduct_btn.UseVisualStyleBackColor = false;
            this.addproduct_btn.Click += new System.EventHandler(this.addproduct_btn_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SeaGreen;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.TransactionRecord_btn);
            this.panel1.Controls.Add(this.sellproduct_btn);
            this.panel1.Controls.Add(this.addproduct_btn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Font = new System.Drawing.Font("Elephant", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(209, 707);
            this.panel1.TabIndex = 7;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.SeaGreen;
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.Staff_Name_lbl);
            this.panel2.Controls.Add(this.Logout_btn);
            this.panel2.Location = new System.Drawing.Point(-1, -1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(213, 229);
            this.panel2.TabIndex = 10;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(48, 25);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(116, 104);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(66, 159);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 21);
            this.label2.TabIndex = 7;
            this.label2.Text = "   Staff";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // Staff_Name_lbl
            // 
            this.Staff_Name_lbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Staff_Name_lbl.AutoSize = true;
            this.Staff_Name_lbl.BackColor = System.Drawing.Color.Transparent;
            this.Staff_Name_lbl.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Staff_Name_lbl.ForeColor = System.Drawing.SystemColors.Control;
            this.Staff_Name_lbl.Location = new System.Drawing.Point(44, 133);
            this.Staff_Name_lbl.Name = "Staff_Name_lbl";
            this.Staff_Name_lbl.Size = new System.Drawing.Size(124, 21);
            this.Staff_Name_lbl.TabIndex = 4;
            this.Staff_Name_lbl.Text = "User Employee";
            // 
            // Logout_btn
            // 
            this.Logout_btn.ActiveLinkColor = System.Drawing.SystemColors.ButtonFace;
            this.Logout_btn.AutoSize = true;
            this.Logout_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Logout_btn.LinkColor = System.Drawing.Color.Cyan;
            this.Logout_btn.Location = new System.Drawing.Point(75, 188);
            this.Logout_btn.Name = "Logout_btn";
            this.Logout_btn.Size = new System.Drawing.Size(48, 16);
            this.Logout_btn.TabIndex = 8;
            this.Logout_btn.TabStop = true;
            this.Logout_btn.Text = "Logout";
            this.Logout_btn.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Logout_btn_LinkClicked);
            // 
            // TransactionRecord_btn
            // 
            this.TransactionRecord_btn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TransactionRecord_btn.BackColor = System.Drawing.Color.MediumAquamarine;
            this.TransactionRecord_btn.FlatAppearance.BorderSize = 0;
            this.TransactionRecord_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.TransactionRecord_btn.Font = new System.Drawing.Font("Elephant", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TransactionRecord_btn.ForeColor = System.Drawing.SystemColors.Control;
            this.TransactionRecord_btn.Image = ((System.Drawing.Image)(resources.GetObject("TransactionRecord_btn.Image")));
            this.TransactionRecord_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.TransactionRecord_btn.Location = new System.Drawing.Point(1, 394);
            this.TransactionRecord_btn.Name = "TransactionRecord_btn";
            this.TransactionRecord_btn.Size = new System.Drawing.Size(244, 83);
            this.TransactionRecord_btn.TabIndex = 7;
            this.TransactionRecord_btn.Text = "Transaction";
            this.TransactionRecord_btn.UseVisualStyleBackColor = false;
            this.TransactionRecord_btn.Click += new System.EventHandler(this.TransactionRecord_btn_Click);
            // 
            // form_panels
            // 
            this.form_panels.Dock = System.Windows.Forms.DockStyle.Fill;
            this.form_panels.Location = new System.Drawing.Point(209, 0);
            this.form_panels.Name = "form_panels";
            this.form_panels.Size = new System.Drawing.Size(1161, 707);
            this.form_panels.TabIndex = 8;
            this.form_panels.Paint += new System.Windows.Forms.PaintEventHandler(this.form_panels_Paint);
            // 
            // Dashboard_Staff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1370, 707);
            this.Controls.Add(this.form_panels);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Dashboard_Staff";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Centro Mercado";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button sellproduct_btn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel form_panels;
        private System.Windows.Forms.Button TransactionRecord_btn;
        public System.Windows.Forms.Button addproduct_btn;
        private System.Windows.Forms.LinkLabel Logout_btn;
        public System.Windows.Forms.Label Staff_Name_lbl;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}