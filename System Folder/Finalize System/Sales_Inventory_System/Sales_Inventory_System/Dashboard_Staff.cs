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
    public partial class Dashboard_Staff : Form
    {
        public Dashboard_Staff()
        {
            InitializeComponent();
            string Firstname = StaffRecord.firstname;
            String Lastname = StaffRecord.lastname;

            Staff_Name_lbl.Text = " " + Firstname +" "+ Lastname;
        }

        private void addproduct_btn_Click(object sender, EventArgs e)
        {
            Employee_Stock_In employee_Stock_In = new Employee_Stock_In();
            employee_Stock_In.TopLevel = false;
            form_panels.Controls.Add(employee_Stock_In);
            employee_Stock_In.BringToFront();
            employee_Stock_In.Show();
        }

        private void sellproduct_btn_Click(object sender, EventArgs e)
        {
            Employee_SellProduct employee_SellProduct = new Employee_SellProduct();
            employee_SellProduct.TopLevel = false;
            form_panels.Controls.Add(employee_SellProduct);
            employee_SellProduct.BringToFront();
            employee_SellProduct.Show();
        }

        private void TransactionRecord_btn_Click(object sender, EventArgs e)
        {
            Employee_Transaction employee_Transaction = new Employee_Transaction();
            employee_Transaction.TopLevel = false;
            form_panels.Controls.Add(employee_Transaction);
            employee_Transaction.BringToFront();
            employee_Transaction.Show();
        }

        private void Logout_btn_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Form_Login form_Login = new Form_Login();
            form_Login.Closed += (s, args) => this.Close();
            form_Login.Show();
        }

        private void form_panels_Paint(object sender, PaintEventArgs e)
        {
            Employee_SellProduct employee_SellProduct = new Employee_SellProduct();
            employee_SellProduct.TopLevel = false;
            form_panels.Controls.Add(employee_SellProduct);
            employee_SellProduct.BringToFront();
            employee_SellProduct.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
