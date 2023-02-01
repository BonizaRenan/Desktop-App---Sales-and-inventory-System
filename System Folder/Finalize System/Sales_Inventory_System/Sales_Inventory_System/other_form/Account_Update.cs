using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Sales_Inventory_System.other_form
{
    public partial class Account_Update : Form
    {
        public Account_Update()
        {
            InitializeComponent();
        }
        string cs = "datasource=127.0.0.1;port=3306;username=root;password=;database=inventory_accounts;";

        private void firstname_tb_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Space);
        }

        private void Lastname_tb_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Space);
        }

      


        private void id_No_tb_TextChanged(object sender, EventArgs e)
        {
            String sql = "SELECT * FROM logins WHERE Id_No = '" + id_No_tb.Text + "'";
            MySqlConnection conn = new MySqlConnection(cs);
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            conn.Open();
            MySqlDataReader dr = cmd.ExecuteReader();

            if (dr.Read())
            {
                firstname_tb.Text = dr.GetString("Firstname");
                Lastname_tb.Text = dr.GetString("Lastname");
                Username_tb.Text = dr.GetString("Username");
                Password_tb.Text = dr.GetString("Password");
                Usertype_tb.Text = dr.GetString("Login_Type");

            }
            else
            {
                firstname_tb.Clear();
                Lastname_tb.Clear();
                Username_tb.Clear();
                Password_tb.Clear();
                

            }
            conn.Close();
        }

        private void Update_btn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(firstname_tb.Text))
            {
                errordetect.SetError(firstname_tb, "Required Input");
                return;
            }
            else if (string.IsNullOrEmpty(Lastname_tb.Text))
            {
                errordetect.SetError(Lastname_tb, "Required Input");
                return;
            }
            else if (string.IsNullOrEmpty(Username_tb.Text))
            {
                errordetect.SetError(Username_tb, "Required Input");
                return;
            }
            else if (string.IsNullOrEmpty(Password_tb.Text))
            {
                errordetect.SetError(Password_tb, "Required Input");
                return;
            }
            else if (string.IsNullOrEmpty(Usertype_tb.Text))
            {
                errordetect.SetError(Usertype_tb, "Required Input");
                return;
            }
            string query = "UPDATE logins SET Firstname = '" + this.firstname_tb.Text +
             "', Lastname ='" + this.Lastname_tb.Text +
             "', Username ='" + this.Username_tb.Text +
             "', Password ='" + this.Password_tb.Text +
             "', LogIn_Type ='" + this.Usertype_tb.Text +
             "' WHERE Id_No= '" + this.id_No_tb.Text +
             "'";
            MySqlConnection conn = new MySqlConnection(cs);
            MySqlCommand cmd = new MySqlCommand(query, conn);
            MySqlDataReader dr;
            conn.Open();
            dr = cmd.ExecuteReader();
            MessageBox.Show("Succefully Update!");
            conn.Close();
            this.Close();
        }

        private void Account_Update_Load(object sender, EventArgs e)
        {

        }

        private void id_No_tb_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

       
    }
}
