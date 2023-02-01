namespace Sales_Inventory_System.TransactionFolder
{
    partial class stockinProduct_Update
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(stockinProduct_Update));
            this.label1 = new System.Windows.Forms.Label();
            this.id_No_tb = new System.Windows.Forms.TextBox();
            this.itemName_tb = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.quantity_tb = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.Category_tb = new System.Windows.Forms.TextBox();
            this.Barcode_tb = new System.Windows.Forms.TextBox();
            this.Update_btn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 25);
            this.label1.TabIndex = 43;
            this.label1.Text = "Id:";
            // 
            // id_No_tb
            // 
            this.id_No_tb.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.id_No_tb.Location = new System.Drawing.Point(70, 79);
            this.id_No_tb.Name = "id_No_tb";
            this.id_No_tb.Size = new System.Drawing.Size(287, 31);
            this.id_No_tb.TabIndex = 44;
            this.id_No_tb.TextChanged += new System.EventHandler(this.id_No_tb_TextChanged);
            // 
            // itemName_tb
            // 
            this.itemName_tb.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemName_tb.Location = new System.Drawing.Point(139, 206);
            this.itemName_tb.Name = "itemName_tb";
            this.itemName_tb.ReadOnly = true;
            this.itemName_tb.Size = new System.Drawing.Size(249, 29);
            this.itemName_tb.TabIndex = 30;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(39, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 24);
            this.label3.TabIndex = 23;
            this.label3.Text = "Barcode:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(17, 209);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 24);
            this.label5.TabIndex = 24;
            this.label5.Text = "Item Name:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(31, 262);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(99, 24);
            this.label7.TabIndex = 25;
            this.label7.Text = "Category:";
            // 
            // quantity_tb
            // 
            this.quantity_tb.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quantity_tb.Location = new System.Drawing.Point(139, 308);
            this.quantity_tb.Name = "quantity_tb";
            this.quantity_tb.Size = new System.Drawing.Size(249, 29);
            this.quantity_tb.TabIndex = 32;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(40, 312);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(92, 24);
            this.label9.TabIndex = 26;
            this.label9.Text = "Quantity:";
            // 
            // Category_tb
            // 
            this.Category_tb.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Category_tb.Location = new System.Drawing.Point(139, 262);
            this.Category_tb.Name = "Category_tb";
            this.Category_tb.ReadOnly = true;
            this.Category_tb.Size = new System.Drawing.Size(249, 29);
            this.Category_tb.TabIndex = 31;
            // 
            // Barcode_tb
            // 
            this.Barcode_tb.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Barcode_tb.Location = new System.Drawing.Point(139, 151);
            this.Barcode_tb.Name = "Barcode_tb";
            this.Barcode_tb.ReadOnly = true;
            this.Barcode_tb.Size = new System.Drawing.Size(249, 29);
            this.Barcode_tb.TabIndex = 29;
            // 
            // Update_btn
            // 
            this.Update_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Update_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Update_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Update_btn.ForeColor = System.Drawing.SystemColors.Control;
            this.Update_btn.Location = new System.Drawing.Point(139, 371);
            this.Update_btn.Name = "Update_btn";
            this.Update_btn.Size = new System.Drawing.Size(115, 41);
            this.Update_btn.TabIndex = 28;
            this.Update_btn.Text = "Update";
            this.Update_btn.UseVisualStyleBackColor = false;
            this.Update_btn.Click += new System.EventHandler(this.Update_btn_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.Barcode_tb);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.quantity_tb);
            this.panel1.Controls.Add(this.id_No_tb);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.itemName_tb);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.Update_btn);
            this.panel1.Controls.Add(this.Category_tb);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(16, 18);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(417, 428);
            this.panel1.TabIndex = 45;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Elephant", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 31);
            this.label2.TabIndex = 45;
            this.label2.Text = "Update";
            // 
            // stockinProduct_Update
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.ClientSize = new System.Drawing.Size(453, 469);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "stockinProduct_Update";
            this.Text = "Update";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox itemName_tb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox quantity_tb;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox Category_tb;
        private System.Windows.Forms.TextBox Barcode_tb;
        private System.Windows.Forms.Button Update_btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox id_No_tb;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
    }
}