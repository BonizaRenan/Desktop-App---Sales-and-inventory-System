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
    public partial class Admin_Sales : Form
    {
        public Admin_Sales()
        {
            InitializeComponent();

        }

        private void Allsales_btn_Click(object sender, EventArgs e)
        {
            Form Allsales = new SalesFolder.Customize_Sale();
            Allsales.TopLevel = false;
            sales_panel.Controls.Add(Allsales);
            Allsales.BringToFront();
            Allsales.Show();
        }

        private void sales_panel_Paint(object sender, PaintEventArgs e)
        {
            Form Allsales = new SalesFolder.Customize_Sale();
            Allsales.TopLevel = false;
            sales_panel.Controls.Add(Allsales);
            Allsales.BringToFront();
            Allsales.Show();
        }

        private void Dailysales_btn_Click(object sender, EventArgs e)
        {
            Form dailysales = new SalesFolder.Daily_Sale();
            dailysales.TopLevel = false;
            sales_panel.Controls.Add(dailysales);
            dailysales.BringToFront();
            dailysales.Show();
        }

        private void Weeklysales_btn_Click(object sender, EventArgs e)
        {
            Form weeklysales = new SalesFolder.Weekly_Sale();
            weeklysales.TopLevel = false;
            sales_panel.Controls.Add(weeklysales);
            weeklysales.BringToFront();
            weeklysales.Show();
        }

        private void MonthlySales_btn_Click(object sender, EventArgs e)
        {
            Form monthlysale = new SalesFolder.Monthly_Sale();
            monthlysale.TopLevel = false;
            sales_panel.Controls.Add(monthlysale);
            monthlysale.BringToFront();
            monthlysale.Show();
        }
    }
}
