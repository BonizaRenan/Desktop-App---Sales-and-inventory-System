namespace Sales_Inventory_System.TransactionFolder
{
    partial class StockIn_Insert
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StockIn_Insert));
            this.stockInDate_dt = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.totalamount_tb = new System.Windows.Forms.TextBox();
            this.stockInInsert_btn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.errordetect = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errordetect)).BeginInit();
            this.SuspendLayout();
            // 
            // stockInDate_dt
            // 
            this.stockInDate_dt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stockInDate_dt.Location = new System.Drawing.Point(41, 99);
            this.stockInDate_dt.Name = "stockInDate_dt";
            this.stockInDate_dt.Size = new System.Drawing.Size(283, 26);
            this.stockInDate_dt.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(38, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "StockIn Date";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(38, 165);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Total Amount";
            // 
            // totalamount_tb
            // 
            this.totalamount_tb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalamount_tb.Location = new System.Drawing.Point(41, 186);
            this.totalamount_tb.Multiline = true;
            this.totalamount_tb.Name = "totalamount_tb";
            this.totalamount_tb.Size = new System.Drawing.Size(283, 32);
            this.totalamount_tb.TabIndex = 3;
            this.totalamount_tb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.totalamount_tb_KeyPress);
            // 
            // stockInInsert_btn
            // 
            this.stockInInsert_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(110)))), ((int)(((byte)(114)))));
            this.stockInInsert_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.stockInInsert_btn.Font = new System.Drawing.Font("Elephant", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stockInInsert_btn.ForeColor = System.Drawing.SystemColors.Control;
            this.stockInInsert_btn.Location = new System.Drawing.Point(127, 245);
            this.stockInInsert_btn.Name = "stockInInsert_btn";
            this.stockInInsert_btn.Size = new System.Drawing.Size(95, 33);
            this.stockInInsert_btn.TabIndex = 4;
            this.stockInInsert_btn.Text = "Insert";
            this.stockInInsert_btn.UseVisualStyleBackColor = false;
            this.stockInInsert_btn.Click += new System.EventHandler(this.stockInInsert_btn_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.totalamount_tb);
            this.panel1.Controls.Add(this.stockInInsert_btn);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.stockInDate_dt);
            this.panel1.Location = new System.Drawing.Point(12, 30);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(376, 305);
            this.panel1.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Elephant", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(0, -1);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 31);
            this.label3.TabIndex = 5;
            this.label3.Text = "Insert";
            // 
            // errordetect
            // 
            this.errordetect.ContainerControl = this;
            // 
            // StockIn_Insert
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.ClientSize = new System.Drawing.Size(408, 347);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "StockIn_Insert";
            this.Text = "StockIn_Insert";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errordetect)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DateTimePicker stockInDate_dt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox totalamount_tb;
        private System.Windows.Forms.Button stockInInsert_btn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ErrorProvider errordetect;
    }
}