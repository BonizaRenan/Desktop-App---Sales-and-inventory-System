namespace Sales_Inventory_System.other_form
{
    partial class Inventory_Trashbin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inventory_Trashbin));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Delete_btn2 = new System.Windows.Forms.Button();
            this.Restore_btn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.Searchbar_tb = new System.Windows.Forms.TextBox();
            this.DeleteAll_btn = new System.Windows.Forms.Button();
            this.RestoreAll_btn = new System.Windows.Forms.Button();
            this.Inventory_Trash_dgv = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Inventory_Trash_dgv)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Delete_btn2
            // 
            this.Delete_btn2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Delete_btn2.BackgroundImage")));
            this.Delete_btn2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Delete_btn2.Location = new System.Drawing.Point(436, 121);
            this.Delete_btn2.Name = "Delete_btn2";
            this.Delete_btn2.Size = new System.Drawing.Size(32, 32);
            this.Delete_btn2.TabIndex = 67;
            this.Delete_btn2.UseVisualStyleBackColor = true;
            this.Delete_btn2.Click += new System.EventHandler(this.Delete_btn2_Click);
            // 
            // Restore_btn
            // 
            this.Restore_btn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Restore_btn.BackgroundImage")));
            this.Restore_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Restore_btn.Location = new System.Drawing.Point(395, 121);
            this.Restore_btn.Name = "Restore_btn";
            this.Restore_btn.Size = new System.Drawing.Size(35, 32);
            this.Restore_btn.TabIndex = 66;
            this.Restore_btn.UseVisualStyleBackColor = true;
            this.Restore_btn.Click += new System.EventHandler(this.Restore_btn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Elephant", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(11, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 27);
            this.label3.TabIndex = 65;
            this.label3.Text = "Search:";
            // 
            // Searchbar_tb
            // 
            this.Searchbar_tb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Searchbar_tb.Location = new System.Drawing.Point(106, 121);
            this.Searchbar_tb.Multiline = true;
            this.Searchbar_tb.Name = "Searchbar_tb";
            this.Searchbar_tb.Size = new System.Drawing.Size(283, 32);
            this.Searchbar_tb.TabIndex = 64;
            this.Searchbar_tb.TextChanged += new System.EventHandler(this.Searchbar_tb_TextChanged);
            // 
            // DeleteAll_btn
            // 
            this.DeleteAll_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.DeleteAll_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.DeleteAll_btn.Font = new System.Drawing.Font("Elephant", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteAll_btn.ForeColor = System.Drawing.SystemColors.Control;
            this.DeleteAll_btn.Location = new System.Drawing.Point(1063, 559);
            this.DeleteAll_btn.Name = "DeleteAll_btn";
            this.DeleteAll_btn.Size = new System.Drawing.Size(115, 36);
            this.DeleteAll_btn.TabIndex = 71;
            this.DeleteAll_btn.Text = "Delete All";
            this.DeleteAll_btn.UseVisualStyleBackColor = false;
            this.DeleteAll_btn.Click += new System.EventHandler(this.DeleteAll_btn_Click);
            // 
            // RestoreAll_btn
            // 
            this.RestoreAll_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.RestoreAll_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.RestoreAll_btn.Font = new System.Drawing.Font("Elephant", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RestoreAll_btn.ForeColor = System.Drawing.SystemColors.Control;
            this.RestoreAll_btn.Location = new System.Drawing.Point(916, 559);
            this.RestoreAll_btn.Name = "RestoreAll_btn";
            this.RestoreAll_btn.Size = new System.Drawing.Size(132, 37);
            this.RestoreAll_btn.TabIndex = 70;
            this.RestoreAll_btn.Text = "Restore All";
            this.RestoreAll_btn.UseVisualStyleBackColor = false;
            this.RestoreAll_btn.Click += new System.EventHandler(this.RestoreAll_btn_Click);
            // 
            // Inventory_Trash_dgv
            // 
            this.Inventory_Trash_dgv.AllowUserToAddRows = false;
            this.Inventory_Trash_dgv.AllowUserToDeleteRows = false;
            this.Inventory_Trash_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Inventory_Trash_dgv.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.Inventory_Trash_dgv.Location = new System.Drawing.Point(9, 160);
            this.Inventory_Trash_dgv.Name = "Inventory_Trash_dgv";
            this.Inventory_Trash_dgv.ReadOnly = true;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Inventory_Trash_dgv.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.Inventory_Trash_dgv.RowHeadersVisible = false;
            this.Inventory_Trash_dgv.Size = new System.Drawing.Size(1171, 387);
            this.Inventory_Trash_dgv.TabIndex = 69;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-1, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1179, 89);
            this.panel1.TabIndex = 72;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Elephant", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(6, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(761, 51);
            this.label1.TabIndex = 55;
            this.label1.Text = "Trash Bin  for Inventory Information";
            // 
            // Inventory_Trashbin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(1191, 628);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.DeleteAll_btn);
            this.Controls.Add(this.RestoreAll_btn);
            this.Controls.Add(this.Inventory_Trash_dgv);
            this.Controls.Add(this.Delete_btn2);
            this.Controls.Add(this.Restore_btn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Searchbar_tb);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Inventory_Trashbin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inventory_Trashbin";
            this.Load += new System.EventHandler(this.Inventory_Trashbin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Inventory_Trash_dgv)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Delete_btn2;
        private System.Windows.Forms.Button Restore_btn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Searchbar_tb;
        private System.Windows.Forms.Button DeleteAll_btn;
        private System.Windows.Forms.Button RestoreAll_btn;
        public System.Windows.Forms.DataGridView Inventory_Trash_dgv;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
    }
}