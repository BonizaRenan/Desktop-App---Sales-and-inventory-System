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
    public partial class Dashboard_Admin : Form
    {
        public Dashboard_Admin()
        {
            InitializeComponent();

            string firstname = StaffRecord.firstname;
            string lastname = StaffRecord.lastname;
            Admin_name_lbl.Text = "  " +firstname+ " " +  lastname;
        }

        private void Account_btn_Click(object sender, EventArgs e)
        {
            Admin_Account admin_Account = new Admin_Account();
            admin_Account.TopLevel = false;
            form_panel.Controls.Add(admin_Account);
            admin_Account.BringToFront();
            admin_Account.Show();
        }

        private void inventory_btn_Click(object sender, EventArgs e)
        {
            Admin_Inventory admin_Inventory = new Admin_Inventory();
            admin_Inventory.TopLevel = false;
            form_panel.Controls.Add(admin_Inventory);
            admin_Inventory.BringToFront();
            admin_Inventory.Show();
        }

        private void Dashboard_btn_Click(object sender, EventArgs e)
        {
            Admin_Dashboard admin_Dashboard = new Admin_Dashboard();
            admin_Dashboard.TopLevel = false;
            form_panel.Controls.Add(admin_Dashboard);
            admin_Dashboard.BringToFront();
            admin_Dashboard.Show();

        }

        private void Logout_btn_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
            this.Hide();
            Form_Login form_Login = new Form_Login();
            form_Login.Closed += (s, args) => this.Close();
            form_Login.Show();
        }

        private void Sales_btn_Click(object sender, EventArgs e)
        {
            Admin_Sales admin_Sales = new Admin_Sales();
            admin_Sales.TopLevel = false;
            form_panel.Controls.Add(admin_Sales);
            admin_Sales.BringToFront();
            admin_Sales.Show();
        }

        private void Transaction_btn_Click(object sender, EventArgs e)
        {
            Admin_Transaction admin_transaction = new Admin_Transaction();
            admin_transaction.TopLevel = false;
            form_panel.Controls.Add(admin_transaction);
            admin_transaction.BringToFront();
            admin_transaction.Show();
        }

        private void form_panel_Paint(object sender, PaintEventArgs e)
        {
            Admin_Dashboard admin_Dashboard = new Admin_Dashboard();
            admin_Dashboard.TopLevel = false;
            form_panel.Controls.Add(admin_Dashboard);
            admin_Dashboard.BringToFront();
            admin_Dashboard.Show();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
