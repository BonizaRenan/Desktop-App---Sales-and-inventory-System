namespace Sales_Inventory_System
{
    partial class Admin_Sales
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.MonthlySales_btn = new System.Windows.Forms.Button();
            this.Weeklysales_btn = new System.Windows.Forms.Button();
            this.Dailysales_btn = new System.Windows.Forms.Button();
            this.Allsales_btn = new System.Windows.Forms.Button();
            this.sales_panel = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(994, 56);
            this.panel1.TabIndex = 62;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Elephant", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(12, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(397, 51);
            this.label1.TabIndex = 54;
            this.label1.Text = "Sales Information";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.panel2.Controls.Add(this.MonthlySales_btn);
            this.panel2.Controls.Add(this.Weeklysales_btn);
            this.panel2.Controls.Add(this.Dailysales_btn);
            this.panel2.Controls.Add(this.Allsales_btn);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel2.Location = new System.Drawing.Point(0, 56);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(994, 71);
            this.panel2.TabIndex = 63;
            // 
            // MonthlySales_btn
            // 
            this.MonthlySales_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.MonthlySales_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.MonthlySales_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MonthlySales_btn.ForeColor = System.Drawing.SystemColors.Control;
            this.MonthlySales_btn.Location = new System.Drawing.Point(725, 14);
            this.MonthlySales_btn.Name = "MonthlySales_btn";
            this.MonthlySales_btn.Size = new System.Drawing.Size(136, 44);
            this.MonthlySales_btn.TabIndex = 4;
            this.MonthlySales_btn.Text = "Monthly Sales";
            this.MonthlySales_btn.UseVisualStyleBackColor = false;
            this.MonthlySales_btn.Click += new System.EventHandler(this.MonthlySales_btn_Click);
            // 
            // Weeklysales_btn
            // 
            this.Weeklysales_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Weeklysales_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Weeklysales_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Weeklysales_btn.ForeColor = System.Drawing.SystemColors.Control;
            this.Weeklysales_btn.Location = new System.Drawing.Point(504, 14);
            this.Weeklysales_btn.Name = "Weeklysales_btn";
            this.Weeklysales_btn.Size = new System.Drawing.Size(136, 44);
            this.Weeklysales_btn.TabIndex = 3;
            this.Weeklysales_btn.Text = "Weekly Sales";
            this.Weeklysales_btn.UseVisualStyleBackColor = false;
            this.Weeklysales_btn.Click += new System.EventHandler(this.Weeklysales_btn_Click);
            // 
            // Dailysales_btn
            // 
            this.Dailysales_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Dailysales_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Dailysales_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dailysales_btn.ForeColor = System.Drawing.SystemColors.Control;
            this.Dailysales_btn.Location = new System.Drawing.Point(276, 15);
            this.Dailysales_btn.Name = "Dailysales_btn";
            this.Dailysales_btn.Size = new System.Drawing.Size(136, 44);
            this.Dailysales_btn.TabIndex = 2;
            this.Dailysales_btn.Text = "Daily Sales";
            this.Dailysales_btn.UseVisualStyleBackColor = false;
            this.Dailysales_btn.Click += new System.EventHandler(this.Dailysales_btn_Click);
            // 
            // Allsales_btn
            // 
            this.Allsales_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Allsales_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Allsales_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Allsales_btn.ForeColor = System.Drawing.SystemColors.Control;
            this.Allsales_btn.Location = new System.Drawing.Point(77, 14);
            this.Allsales_btn.Name = "Allsales_btn";
            this.Allsales_btn.Size = new System.Drawing.Size(123, 44);
            this.Allsales_btn.TabIndex = 1;
            this.Allsales_btn.Text = "Sales";
            this.Allsales_btn.UseVisualStyleBackColor = false;
            this.Allsales_btn.Click += new System.EventHandler(this.Allsales_btn_Click);
            // 
            // sales_panel
            // 
            this.sales_panel.BackColor = System.Drawing.Color.SeaGreen;
            this.sales_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sales_panel.Location = new System.Drawing.Point(0, 127);
            this.sales_panel.Name = "sales_panel";
            this.sales_panel.Size = new System.Drawing.Size(994, 521);
            this.sales_panel.TabIndex = 64;
            this.sales_panel.Paint += new System.Windows.Forms.PaintEventHandler(this.sales_panel_Paint);
            // 
            // Admin_Sales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(994, 648);
            this.ControlBox = false;
            this.Controls.Add(this.sales_panel);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Admin_Sales";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button MonthlySales_btn;
        private System.Windows.Forms.Button Weeklysales_btn;
        private System.Windows.Forms.Button Dailysales_btn;
        private System.Windows.Forms.Button Allsales_btn;
        private System.Windows.Forms.Panel sales_panel;
    }
}