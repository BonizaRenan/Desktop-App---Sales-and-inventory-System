namespace Sales_Inventory_System.other_form
{
    partial class Account_Trashbin
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Account_Trashbin));
            this.Account_Trash_dgv = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.RestoreAll_btn = new System.Windows.Forms.Button();
            this.DeleteAll_btn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.Searchbar_tb = new System.Windows.Forms.TextBox();
            this.Restore_btn = new System.Windows.Forms.Button();
            this.Delete_btn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.Account_Trash_dgv)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Account_Trash_dgv
            // 
            this.Account_Trash_dgv.AllowUserToAddRows = false;
            this.Account_Trash_dgv.AllowUserToDeleteRows = false;
            this.Account_Trash_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Account_Trash_dgv.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.Account_Trash_dgv.Location = new System.Drawing.Point(10, 160);
            this.Account_Trash_dgv.Name = "Account_Trash_dgv";
            this.Account_Trash_dgv.ReadOnly = true;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Account_Trash_dgv.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.Account_Trash_dgv.RowHeadersVisible = false;
            this.Account_Trash_dgv.Size = new System.Drawing.Size(1169, 387);
            this.Account_Trash_dgv.TabIndex = 53;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Elephant", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(3, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(731, 51);
            this.label2.TabIndex = 55;
            this.label2.Text = "Trash Bin  for Account Information";
            // 
            // RestoreAll_btn
            // 
            this.RestoreAll_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.RestoreAll_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.RestoreAll_btn.Font = new System.Drawing.Font("Elephant", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RestoreAll_btn.ForeColor = System.Drawing.SystemColors.Control;
            this.RestoreAll_btn.Location = new System.Drawing.Point(909, 557);
            this.RestoreAll_btn.Name = "RestoreAll_btn";
            this.RestoreAll_btn.Size = new System.Drawing.Size(135, 37);
            this.RestoreAll_btn.TabIndex = 56;
            this.RestoreAll_btn.Text = "Restore All";
            this.RestoreAll_btn.UseVisualStyleBackColor = false;
            this.RestoreAll_btn.Click += new System.EventHandler(this.RestoreAll_btn_Click);
            // 
            // DeleteAll_btn
            // 
            this.DeleteAll_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.DeleteAll_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.DeleteAll_btn.Font = new System.Drawing.Font("Elephant", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteAll_btn.ForeColor = System.Drawing.SystemColors.Control;
            this.DeleteAll_btn.Location = new System.Drawing.Point(1050, 558);
            this.DeleteAll_btn.Name = "DeleteAll_btn";
            this.DeleteAll_btn.Size = new System.Drawing.Size(118, 36);
            this.DeleteAll_btn.TabIndex = 57;
            this.DeleteAll_btn.Text = "Delete All";
            this.DeleteAll_btn.UseVisualStyleBackColor = false;
            this.DeleteAll_btn.Click += new System.EventHandler(this.DeleteAll_btn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Elephant", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(11, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 27);
            this.label3.TabIndex = 59;
            this.label3.Text = "Search:";
            // 
            // Searchbar_tb
            // 
            this.Searchbar_tb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Searchbar_tb.Location = new System.Drawing.Point(110, 124);
            this.Searchbar_tb.Multiline = true;
            this.Searchbar_tb.Name = "Searchbar_tb";
            this.Searchbar_tb.Size = new System.Drawing.Size(283, 32);
            this.Searchbar_tb.TabIndex = 58;
            this.Searchbar_tb.TextChanged += new System.EventHandler(this.Searchbar_tb_TextChanged);
            // 
            // Restore_btn
            // 
            this.Restore_btn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Restore_btn.BackgroundImage")));
            this.Restore_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Restore_btn.Location = new System.Drawing.Point(399, 122);
            this.Restore_btn.Name = "Restore_btn";
            this.Restore_btn.Size = new System.Drawing.Size(35, 32);
            this.Restore_btn.TabIndex = 60;
            this.Restore_btn.UseVisualStyleBackColor = true;
            this.Restore_btn.Click += new System.EventHandler(this.Restore_btn_Click);
            // 
            // Delete_btn
            // 
            this.Delete_btn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Delete_btn.BackgroundImage")));
            this.Delete_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Delete_btn.Location = new System.Drawing.Point(440, 122);
            this.Delete_btn.Name = "Delete_btn";
            this.Delete_btn.Size = new System.Drawing.Size(32, 32);
            this.Delete_btn.TabIndex = 61;
            this.Delete_btn.UseVisualStyleBackColor = true;
            this.Delete_btn.Click += new System.EventHandler(this.Delete_btn_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(0, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1179, 89);
            this.panel1.TabIndex = 62;
            // 
            // Account_Trashbin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(1191, 628);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Delete_btn);
            this.Controls.Add(this.Restore_btn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Searchbar_tb);
            this.Controls.Add(this.DeleteAll_btn);
            this.Controls.Add(this.RestoreAll_btn);
            this.Controls.Add(this.Account_Trash_dgv);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Account_Trashbin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Account_Trashbin";
            this.Load += new System.EventHandler(this.Account_Trashbin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Account_Trash_dgv)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.DataGridView Account_Trash_dgv;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button RestoreAll_btn;
        private System.Windows.Forms.Button DeleteAll_btn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Searchbar_tb;
        private System.Windows.Forms.Button Restore_btn;
        private System.Windows.Forms.Button Delete_btn;
        private System.Windows.Forms.Panel panel1;
    }
}