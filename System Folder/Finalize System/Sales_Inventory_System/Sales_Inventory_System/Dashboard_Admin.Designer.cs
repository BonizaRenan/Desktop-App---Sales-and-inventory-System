namespace Sales_Inventory_System
{
    partial class Dashboard_Admin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard_Admin));
            this.Account_btn = new System.Windows.Forms.Button();
            this.inventory_btn = new System.Windows.Forms.Button();
            this.Transaction_btn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Dashboard_btn = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Admin_name_lbl = new System.Windows.Forms.Label();
            this.Logout_btn = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.Sales_btn = new System.Windows.Forms.Button();
            this.form_panel = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Account_btn
            // 
            this.Account_btn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Account_btn.BackColor = System.Drawing.Color.MediumAquamarine;
            this.Account_btn.FlatAppearance.BorderSize = 0;
            this.Account_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Account_btn.Font = new System.Drawing.Font("Elephant", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Account_btn.ForeColor = System.Drawing.SystemColors.Control;
            this.Account_btn.Image = ((System.Drawing.Image)(resources.GetObject("Account_btn.Image")));
            this.Account_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Account_btn.Location = new System.Drawing.Point(0, 515);
            this.Account_btn.Name = "Account_btn";
            this.Account_btn.Size = new System.Drawing.Size(197, 83);
            this.Account_btn.TabIndex = 0;
            this.Account_btn.Text = "Account ";
            this.Account_btn.UseVisualStyleBackColor = false;
            this.Account_btn.Click += new System.EventHandler(this.Account_btn_Click);
            // 
            // inventory_btn
            // 
            this.inventory_btn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.inventory_btn.BackColor = System.Drawing.Color.MediumAquamarine;
            this.inventory_btn.FlatAppearance.BorderSize = 0;
            this.inventory_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.inventory_btn.Font = new System.Drawing.Font("Elephant", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inventory_btn.ForeColor = System.Drawing.SystemColors.Control;
            this.inventory_btn.Image = ((System.Drawing.Image)(resources.GetObject("inventory_btn.Image")));
            this.inventory_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.inventory_btn.Location = new System.Drawing.Point(0, 432);
            this.inventory_btn.Name = "inventory_btn";
            this.inventory_btn.Size = new System.Drawing.Size(197, 83);
            this.inventory_btn.TabIndex = 1;
            this.inventory_btn.Text = "Inventory";
            this.inventory_btn.UseVisualStyleBackColor = false;
            this.inventory_btn.Click += new System.EventHandler(this.inventory_btn_Click);
            // 
            // Transaction_btn
            // 
            this.Transaction_btn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Transaction_btn.BackColor = System.Drawing.Color.MediumAquamarine;
            this.Transaction_btn.FlatAppearance.BorderSize = 0;
            this.Transaction_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Transaction_btn.Font = new System.Drawing.Font("Elephant", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Transaction_btn.ForeColor = System.Drawing.SystemColors.Control;
            this.Transaction_btn.Image = ((System.Drawing.Image)(resources.GetObject("Transaction_btn.Image")));
            this.Transaction_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Transaction_btn.Location = new System.Drawing.Point(0, 349);
            this.Transaction_btn.Name = "Transaction_btn";
            this.Transaction_btn.Size = new System.Drawing.Size(197, 83);
            this.Transaction_btn.TabIndex = 2;
            this.Transaction_btn.Text = "Transaction";
            this.Transaction_btn.UseVisualStyleBackColor = false;
            this.Transaction_btn.Click += new System.EventHandler(this.Transaction_btn_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SeaGreen;
            this.panel1.Controls.Add(this.Dashboard_btn);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.Sales_btn);
            this.panel1.Controls.Add(this.Account_btn);
            this.panel1.Controls.Add(this.Transaction_btn);
            this.panel1.Controls.Add(this.inventory_btn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(197, 650);
            this.panel1.TabIndex = 3;
            // 
            // Dashboard_btn
            // 
            this.Dashboard_btn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Dashboard_btn.BackColor = System.Drawing.Color.MediumAquamarine;
            this.Dashboard_btn.FlatAppearance.BorderSize = 0;
            this.Dashboard_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Dashboard_btn.Font = new System.Drawing.Font("Elephant", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dashboard_btn.ForeColor = System.Drawing.SystemColors.Control;
            this.Dashboard_btn.Image = ((System.Drawing.Image)(resources.GetObject("Dashboard_btn.Image")));
            this.Dashboard_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Dashboard_btn.Location = new System.Drawing.Point(0, 182);
            this.Dashboard_btn.Name = "Dashboard_btn";
            this.Dashboard_btn.Size = new System.Drawing.Size(197, 83);
            this.Dashboard_btn.TabIndex = 4;
            this.Dashboard_btn.Text = "Dashboard";
            this.Dashboard_btn.UseVisualStyleBackColor = false;
            this.Dashboard_btn.Click += new System.EventHandler(this.Dashboard_btn_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.SeaGreen;
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.Admin_name_lbl);
            this.panel2.Controls.Add(this.Logout_btn);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(0, 1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(197, 181);
            this.panel2.TabIndex = 8;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(60, 21);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(76, 73);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // Admin_name_lbl
            // 
            this.Admin_name_lbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Admin_name_lbl.AutoSize = true;
            this.Admin_name_lbl.BackColor = System.Drawing.Color.Transparent;
            this.Admin_name_lbl.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Admin_name_lbl.ForeColor = System.Drawing.SystemColors.Control;
            this.Admin_name_lbl.Location = new System.Drawing.Point(36, 97);
            this.Admin_name_lbl.Name = "Admin_name_lbl";
            this.Admin_name_lbl.Size = new System.Drawing.Size(128, 21);
            this.Admin_name_lbl.TabIndex = 2;
            this.Admin_name_lbl.Text = " Administration";
            // 
            // Logout_btn
            // 
            this.Logout_btn.ActiveLinkColor = System.Drawing.SystemColors.ButtonFace;
            this.Logout_btn.AutoSize = true;
            this.Logout_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Logout_btn.ForeColor = System.Drawing.SystemColors.Control;
            this.Logout_btn.LinkColor = System.Drawing.Color.Cyan;
            this.Logout_btn.Location = new System.Drawing.Point(70, 149);
            this.Logout_btn.Name = "Logout_btn";
            this.Logout_btn.Size = new System.Drawing.Size(48, 16);
            this.Logout_btn.TabIndex = 6;
            this.Logout_btn.TabStop = true;
            this.Logout_btn.Text = "Logout";
            this.Logout_btn.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Logout_btn_LinkClicked);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(66, 123);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 21);
            this.label1.TabIndex = 7;
            this.label1.Text = "Admin ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Sales_btn
            // 
            this.Sales_btn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Sales_btn.BackColor = System.Drawing.Color.MediumAquamarine;
            this.Sales_btn.FlatAppearance.BorderSize = 0;
            this.Sales_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Sales_btn.Font = new System.Drawing.Font("Elephant", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sales_btn.ForeColor = System.Drawing.SystemColors.Control;
            this.Sales_btn.Image = ((System.Drawing.Image)(resources.GetObject("Sales_btn.Image")));
            this.Sales_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Sales_btn.Location = new System.Drawing.Point(0, 265);
            this.Sales_btn.Name = "Sales_btn";
            this.Sales_btn.Size = new System.Drawing.Size(197, 84);
            this.Sales_btn.TabIndex = 5;
            this.Sales_btn.Text = "Sales";
            this.Sales_btn.UseVisualStyleBackColor = false;
            this.Sales_btn.Click += new System.EventHandler(this.Sales_btn_Click);
            // 
            // form_panel
            // 
            this.form_panel.BackColor = System.Drawing.Color.White;
            this.form_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.form_panel.Location = new System.Drawing.Point(197, 0);
            this.form_panel.Name = "form_panel";
            this.form_panel.Size = new System.Drawing.Size(996, 650);
            this.form_panel.TabIndex = 6;
            this.form_panel.Paint += new System.Windows.Forms.PaintEventHandler(this.form_panel_Paint);
            // 
            // Dashboard_Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1193, 650);
            this.Controls.Add(this.form_panel);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Dashboard_Admin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard Admin";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button Account_btn;
        private System.Windows.Forms.Button inventory_btn;
        private System.Windows.Forms.Button Transaction_btn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label Admin_name_lbl;
        private System.Windows.Forms.Panel form_panel;
        private System.Windows.Forms.Button Dashboard_btn;
        private System.Windows.Forms.Button Sales_btn;
        private System.Windows.Forms.LinkLabel Logout_btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}