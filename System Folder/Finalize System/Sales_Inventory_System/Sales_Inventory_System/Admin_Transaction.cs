using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sales_Inventory_System
{
    public partial class Admin_Transaction : Form
    {
        public Admin_Transaction()
        {
            InitializeComponent();
        }

        private void StockIn_btn_Click(object sender, EventArgs e)
        {
            Form stockin  = new TransactionFolder.StockIn_Record();
            stockin.TopLevel = false;
            transact_panel.Controls.Add(stockin);
            stockin.BringToFront();
            stockin.Show();
        }

        private void transact_panel_Paint(object sender, PaintEventArgs e)
        {
            Form stockin = new TransactionFolder.StockIn_Record();
            stockin.TopLevel = false;
            transact_panel.Controls.Add(stockin);
            stockin.BringToFront();
            stockin.Show();
        }

        private void StockOut_btn_Click(object sender, EventArgs e)
        {
            Form stockout = new TransactionFolder.StockOut_Record();
            stockout.TopLevel = false;
            transact_panel.Controls.Add(stockout);
            stockout.BringToFront();
            stockout.Show();
        }
    }
}
