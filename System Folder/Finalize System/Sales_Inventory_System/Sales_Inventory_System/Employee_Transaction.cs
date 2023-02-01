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
    public partial class Employee_Transaction : Form
    {
      
        public Employee_Transaction()
        {
            InitializeComponent();
        
        }

    
        private void Record_panel_Paint(object sender, PaintEventArgs e)
        {
            Form StockOut = new Employee_Record.Employee_StockOut();
            StockOut.TopLevel = false;
            Record_panel.Controls.Add(StockOut);
            StockOut.BringToFront();
            StockOut.Show();
        }
        private void Stockout_btn_Click(object sender, EventArgs e)
        {
            Form StockOut = new Employee_Record.Employee_StockOut();
            StockOut.TopLevel = false;
            Record_panel.Controls.Add(StockOut);
            StockOut.BringToFront();
            StockOut.Show();
        }

        private void Stockin_btn_Click(object sender, EventArgs e)
        {
            Form StockIn = new Employee_Record.Employee_StockIn();
            StockIn.TopLevel = false;
            Record_panel.Controls.Add(StockIn);
            StockIn.BringToFront();
            StockIn.Show();
        }
    }
}
