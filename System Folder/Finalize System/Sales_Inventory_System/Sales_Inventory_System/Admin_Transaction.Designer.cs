namespace Sales_Inventory_System
{
    partial class Admin_Transaction
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
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.StockOut_btn = new System.Windows.Forms.Button();
            this.StockIn_btn = new System.Windows.Forms.Button();
            this.transact_panel = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(994, 54);
            this.panel1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Elephant", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(3, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(276, 51);
            this.label2.TabIndex = 55;
            this.label2.Text = "Transaction";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.panel2.Controls.Add(this.StockOut_btn);
            this.panel2.Controls.Add(this.StockIn_btn);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 54);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(994, 64);
            this.panel2.TabIndex = 1;
            // 
            // StockOut_btn
            // 
            this.StockOut_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.StockOut_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.StockOut_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StockOut_btn.ForeColor = System.Drawing.SystemColors.Control;
            this.StockOut_btn.Location = new System.Drawing.Point(178, 12);
            this.StockOut_btn.Name = "StockOut_btn";
            this.StockOut_btn.Size = new System.Drawing.Size(104, 42);
            this.StockOut_btn.TabIndex = 1;
            this.StockOut_btn.Text = "Stock Out";
            this.StockOut_btn.UseVisualStyleBackColor = false;
            this.StockOut_btn.Click += new System.EventHandler(this.StockOut_btn_Click);
            // 
            // StockIn_btn
            // 
            this.StockIn_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.StockIn_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.StockIn_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StockIn_btn.ForeColor = System.Drawing.SystemColors.Control;
            this.StockIn_btn.Location = new System.Drawing.Point(31, 11);
            this.StockIn_btn.Name = "StockIn_btn";
            this.StockIn_btn.Size = new System.Drawing.Size(104, 42);
            this.StockIn_btn.TabIndex = 0;
            this.StockIn_btn.Text = "Stock In";
            this.StockIn_btn.UseVisualStyleBackColor = false;
            this.StockIn_btn.Click += new System.EventHandler(this.StockIn_btn_Click);
            // 
            // transact_panel
            // 
            this.transact_panel.BackColor = System.Drawing.SystemColors.Control;
            this.transact_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.transact_panel.Location = new System.Drawing.Point(0, 118);
            this.transact_panel.Name = "transact_panel";
            this.transact_panel.Size = new System.Drawing.Size(994, 530);
            this.transact_panel.TabIndex = 2;
            this.transact_panel.Paint += new System.Windows.Forms.PaintEventHandler(this.transact_panel_Paint);
            // 
            // Admin_Transaction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(994, 648);
            this.ControlBox = false;
            this.Controls.Add(this.transact_panel);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Admin_Transaction";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button StockOut_btn;
        private System.Windows.Forms.Button StockIn_btn;
        private System.Windows.Forms.Panel transact_panel;
    }
}