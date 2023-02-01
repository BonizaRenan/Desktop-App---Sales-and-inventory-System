using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace Sales_Inventory_System
{
    public partial class Form_Login : Form
    {
        public Form_Login()
        {
            InitializeComponent();
        }
        //public static string firstname;
        //public static string lastname;
        
        string cs = "datasource=127.0.0.1;port=3306;username=root;password=;database=inventory_accounts;";


        private void BTN_LOGIN_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM logins WHERE username='" + username_tb.Text + "'AND password='" + passwrod_tb.Text + "'";
            MySqlConnection conn = new MySqlConnection(cs);
            MySqlCommand commandata = new MySqlCommand(query, conn);
            MySqlDataReader reader;

            

            try
            {
                conn.Open();
                reader = commandata.ExecuteReader();
                
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                       string types = reader.GetString("LogIn_Type");
                       StaffRecord.firstname = reader.GetString("Firstname");
                       StaffRecord.lastname = reader.GetString("Lastname");

                        if (types == "Admin")
                        {
                            
                            
                            this.Hide();
                            var dashboard_Admin = new Dashboard_Admin();
                            dashboard_Admin.Closed += (s, args) => this.Close();
                            dashboard_Admin.Show();
                            
                        }

                        else if (types == "Staff")
                        {

                            
                            
                            
                            this.Hide();
                            var dashboard_Staff = new Dashboard_Staff();
                            dashboard_Staff.Closed += (s, args) => this.Close();
                            dashboard_Staff.Show();
                            
                        }
                    }
                }
                else
                {

                    MessageBox.Show("Invalid Input! Please try again");

                }
            }
            catch (Exception)
            {
                MessageBox.Show("Database Error");


            }
        }

      
        private void ShowPassword_CB_CheckedChanged(object sender, EventArgs e)
        {
            if (ShowPassword_CB.Checked == true)
            {
                passwrod_tb.UseSystemPasswordChar = true;

            }
            else 
            {
                passwrod_tb.UseSystemPasswordChar = false;

            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form_Login_Load(object sender, EventArgs e)
        {

        }
    }
    
}
