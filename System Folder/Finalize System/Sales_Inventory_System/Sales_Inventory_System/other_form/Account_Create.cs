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
    public partial class Account_Create : Form
    {
        public Account_Create()
        {
            InitializeComponent();
        }
        string cs = "datasource=127.0.0.1;port=3306;username=root;password=;database=inventory_accounts;";
        
        private void firsname_tb_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Space);
        }

        private void lastname_tb_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Space);
        }

        //void Create() {

        //    string query = "INSERT INTO logins(Firstname, Lastname, Username, Password, LogIn_Type )" +
        //        "VALUES('" + this.firsname_tb.Text + "','" + this.lastname_tb.Text + "','" + this.username_tb.Text +
        //        "','" + this.password_tb.Text + "','" + this.type_tb.Text + "')";
        //    MySqlConnection conn = new MySqlConnection(connectionString);
        //    MySqlCommand cmd = new MySqlCommand(query, conn);
        //    MySqlDataReader dr;
        //    conn.Open();
        //    dr = cmd.ExecuteReader();
        //    MessageBox.Show("Successfully Create");
        //    conn.Close();
        //    this.Close();
        //}

        private void btn_Create_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(firsname_tb.Text)) 
            {
                errordetect.SetError(firsname_tb, "Required Input");
                return;
            }
            else if (string.IsNullOrEmpty(lastname_tb.Text))
            {
                errordetect.SetError(lastname_tb, "Required Input");
                return;
            }
            else if (string.IsNullOrEmpty(username_tb.Text))
            {
                errordetect.SetError(username_tb, "Required Input");
                return;
            }
            else if (string.IsNullOrEmpty(password_tb.Text))
            {
                errordetect.SetError(password_tb, "Required Input");
                return;
            }
            else if (string.IsNullOrEmpty(type_tb.Text))
            {
                errordetect.SetError(type_tb, "Required Input");
                return;
            }
            MySqlConnection conn = new MySqlConnection(cs);
            string sql = "Select * from logins where Firstname='" + firsname_tb.Text +
            "'OR Lastname='" + lastname_tb.Text + "'OR username ='" + username_tb.Text + "'";
            MySqlCommand Duplicate = new MySqlCommand(sql, conn);
            
            try
            {
                conn.Open();
                string pid = (string)Duplicate.ExecuteScalar();
                conn.Close();

                if (pid != firsname_tb.Text || pid != lastname_tb.Text || pid != username_tb.Text)
                {
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand("INSERT INTO logins (Firstname, Lastname, Username, Password, LogIn_Type )" +
                    "VALUES('" + this.firsname_tb.Text + "','" + this.lastname_tb.Text + "','" + this.username_tb.Text +
                    "','" + this.password_tb.Text + "','" + this.type_tb.Text + "')",conn);
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("Successfully Created.");
                    this.Close();

                }

            }
            catch {

                MessageBox.Show("Already Exist!! Please check in your Data");
                this.Close();

            }
            
        }
    }
}
