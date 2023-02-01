namespace Sales_Inventory_System
{
    partial class Form_Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Login));
            this.passwrod_tb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BTN_LOGIN = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.ShowPassword_CB = new System.Windows.Forms.CheckBox();
            this.username_tb = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // passwrod_tb
            // 
            this.passwrod_tb.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.passwrod_tb.Font = new System.Drawing.Font("Elephant", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwrod_tb.Location = new System.Drawing.Point(774, 328);
            this.passwrod_tb.Multiline = true;
            this.passwrod_tb.Name = "passwrod_tb";
            this.passwrod_tb.PasswordChar = '*';
            this.passwrod_tb.Size = new System.Drawing.Size(182, 33);
            this.passwrod_tb.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Elephant", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(632, 266);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "Username:";
            // 
            // BTN_LOGIN
            // 
            this.BTN_LOGIN.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BTN_LOGIN.BackColor = System.Drawing.Color.SeaGreen;
            this.BTN_LOGIN.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BTN_LOGIN.Font = new System.Drawing.Font("Elephant", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_LOGIN.ForeColor = System.Drawing.Color.White;
            this.BTN_LOGIN.Location = new System.Drawing.Point(754, 432);
            this.BTN_LOGIN.Name = "BTN_LOGIN";
            this.BTN_LOGIN.Size = new System.Drawing.Size(120, 43);
            this.BTN_LOGIN.TabIndex = 4;
            this.BTN_LOGIN.Text = "LogIn";
            this.BTN_LOGIN.UseVisualStyleBackColor = false;
            this.BTN_LOGIN.Click += new System.EventHandler(this.BTN_LOGIN_Click);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Elephant", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(637, 334);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 27);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password:";
            // 
            // ShowPassword_CB
            // 
            this.ShowPassword_CB.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ShowPassword_CB.AutoSize = true;
            this.ShowPassword_CB.BackColor = System.Drawing.Color.Transparent;
            this.ShowPassword_CB.Font = new System.Drawing.Font("Elephant", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShowPassword_CB.ForeColor = System.Drawing.Color.Black;
            this.ShowPassword_CB.Location = new System.Drawing.Point(789, 367);
            this.ShowPassword_CB.Name = "ShowPassword_CB";
            this.ShowPassword_CB.Size = new System.Drawing.Size(141, 21);
            this.ShowPassword_CB.TabIndex = 5;
            this.ShowPassword_CB.Text = "Show Password";
            this.ShowPassword_CB.UseVisualStyleBackColor = false;
            this.ShowPassword_CB.CheckedChanged += new System.EventHandler(this.ShowPassword_CB_CheckedChanged);
            // 
            // username_tb
            // 
            this.username_tb.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.username_tb.Font = new System.Drawing.Font("Elephant", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.username_tb.Location = new System.Drawing.Point(774, 260);
            this.username_tb.Multiline = true;
            this.username_tb.Name = "username_tb";
            this.username_tb.Size = new System.Drawing.Size(182, 33);
            this.username_tb.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Brush Script MT", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(727, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(182, 46);
            this.label3.TabIndex = 6;
            this.label3.Text = "LogIn Form";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // Form_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1055, 613);
            this.Controls.Add(this.BTN_LOGIN);
            this.Controls.Add(this.ShowPassword_CB);
            this.Controls.Add(this.username_tb);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.passwrod_tb);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form_Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login Form";
            this.Load += new System.EventHandler(this.Form_Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox passwrod_tb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BTN_LOGIN;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox ShowPassword_CB;
        public System.Windows.Forms.TextBox username_tb;
        private System.Windows.Forms.Label label3;
    }
}

