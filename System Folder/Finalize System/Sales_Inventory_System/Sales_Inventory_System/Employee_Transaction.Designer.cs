namespace Sales_Inventory_System
{
    partial class Employee_Transaction
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
            this.Stockout_btn = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Stockin_btn = new System.Windows.Forms.Button();
            this.Record_panel = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1159, 58);
            this.panel1.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Elephant", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(-4, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(439, 51);
            this.label1.TabIndex = 0;
            this.label1.Text = "Transaction Record";
            // 
            // Stockout_btn
            // 
            this.Stockout_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Stockout_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Stockout_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Stockout_btn.ForeColor = System.Drawing.SystemColors.Control;
            this.Stockout_btn.Location = new System.Drawing.Point(41, 20);
            this.Stockout_btn.Name = "Stockout_btn";
            this.Stockout_btn.Size = new System.Drawing.Size(112, 43);
            this.Stockout_btn.TabIndex = 16;
            this.Stockout_btn.Text = "Stock-Out";
            this.Stockout_btn.UseVisualStyleBackColor = false;
            this.Stockout_btn.Click += new System.EventHandler(this.Stockout_btn_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.panel2.Controls.Add(this.Stockin_btn);
            this.panel2.Controls.Add(this.Stockout_btn);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 58);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1159, 86);
            this.panel2.TabIndex = 17;
            // 
            // Stockin_btn
            // 
            this.Stockin_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Stockin_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Stockin_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Stockin_btn.ForeColor = System.Drawing.SystemColors.Control;
            this.Stockin_btn.Location = new System.Drawing.Point(181, 20);
            this.Stockin_btn.Name = "Stockin_btn";
            this.Stockin_btn.Size = new System.Drawing.Size(112, 43);
            this.Stockin_btn.TabIndex = 17;
            this.Stockin_btn.Text = "Stock-In";
            this.Stockin_btn.UseVisualStyleBackColor = false;
            this.Stockin_btn.Click += new System.EventHandler(this.Stockin_btn_Click);
            // 
            // Record_panel
            // 
            this.Record_panel.BackColor = System.Drawing.SystemColors.Control;
            this.Record_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Record_panel.Location = new System.Drawing.Point(0, 144);
            this.Record_panel.Name = "Record_panel";
            this.Record_panel.Size = new System.Drawing.Size(1159, 561);
            this.Record_panel.TabIndex = 18;
            this.Record_panel.Paint += new System.Windows.Forms.PaintEventHandler(this.Record_panel_Paint);
            // 
            // Employee_Transaction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1159, 705);
            this.ControlBox = false;
            this.Controls.Add(this.Record_panel);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Employee_Transaction";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Stockout_btn;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button Stockin_btn;
        private System.Windows.Forms.Panel Record_panel;
    }
}