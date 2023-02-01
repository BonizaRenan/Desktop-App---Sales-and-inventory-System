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

namespace Sales_Inventory_System.other_form
{
    public partial class Account_Trashbin : Form
    {
        public Account_Trashbin()
        {
            InitializeComponent();
        }
        string cs = "datasource=127.0.0.1;port=3306;username=root;password=;database=inventory_accounts;";

        void load()
        {

            string query = "SELECT * FROM trashbin_logins";
            MySqlConnection conn = new MySqlConnection(cs);
            MySqlCommand cmd = new MySqlCommand(query, conn);
            MySqlDataAdapter da = new MySqlDataAdapter();
            da.SelectCommand = cmd;
            DataTable dt = new DataTable();
            da.Fill(dt);
            Account_Trash_dgv.DataSource = dt;
            Account_Trash_dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
        }


        private void Account_Trashbin_Load(object sender, EventArgs e)
        {
            load();
        }
      

        private void RestoreAll_btn_Click(object sender, EventArgs e)
        {
            string message = $"Are you sure want to Restore All?";

            if (MessageBox.Show(message, "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) 
            {
                string query = "INSERT INTO logins SELECT * FROM trashbin_logins";
                MySqlConnection conn = new MySqlConnection(cs);
                MySqlCommand cmd = new MySqlCommand(query, conn);
                conn.Open();
                cmd.ExecuteNonQuery();
                cmd.CommandText = "DELETE FROM trashbin_logins ";
                cmd.ExecuteNonQuery();
                MessageBox.Show("Successfully Restore");
                conn.Close();
                this.Close();
            } 
        }


        private void Restore_btn_Click(object sender, EventArgs e)
        {
            string id = Account_Trash_dgv.CurrentRow.Cells["Id_No"].Value.ToString();
            string message = "Are you sure want to Restore " + id + " ?";

            if (MessageBox.Show(message, "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string query = "INSERT INTO logins SELECT * FROM trashbin_logins WHERE Id_No='" + id + "'";
                MySqlConnection conn = new MySqlConnection(cs);
                MySqlCommand cmd = new MySqlCommand(query, conn);
                conn.Open();
                cmd.ExecuteNonQuery();
                cmd.CommandText = "DELETE FROM trashbin_logins WHERE Id_No='" + id + "'";
                cmd.ExecuteNonQuery();
                MessageBox.Show("Successfully Restore");
                conn.Close();
                load();
            }
        }


        private void DeleteAll_btn_Click(object sender, EventArgs e)
        {
            string message = $"Are you sure want to Delete All?";

            if (MessageBox.Show(message, "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string query = "DELETE FROM trashbin_logins ";
                MySqlConnection conn = new MySqlConnection(cs);
                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataReader dr;
                conn.Open();
                dr = cmd.ExecuteReader();
                conn.Close();
                this.Close();
            }
        }


        private void Delete_btn_Click(object sender, EventArgs e)
        {
            string id = Account_Trash_dgv.CurrentRow.Cells["Id_No"].Value.ToString();
            string message = "Are you sure want to Delete " + id + " ?";

            if (MessageBox.Show(message, "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string query = "DELETE FROM trashbin_logins WHERE Id_No='" + id + "'";
                MySqlConnection conn = new MySqlConnection(cs);
                MySqlCommand cmd = new MySqlCommand(query, conn);
                conn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Successfully Deleted");
                conn.Close();
                load();

            }
        }


        private void Searchbar_tb_TextChanged(object sender, EventArgs e)
        {
            string sql = "SELECT * FROM trashbin_logins WHERE Id_No LIKE'" +
             this.Searchbar_tb.Text + "%' OR Firstname LIKE'" +
             this.Searchbar_tb.Text + "%' OR Lastname LIKE'" +
             this.Searchbar_tb.Text + "%' OR Username LIKE'" +
             this.Searchbar_tb.Text + "%' OR LogIn_Type LIKE'" +
             this.Searchbar_tb.Text + "%'";
            MySqlConnection conn = new MySqlConnection(cs);
            MySqlDataAdapter da = new MySqlDataAdapter(sql, conn);
            DataTable dt = new DataTable();
            conn.Open();
            da.Fill(dt);
            Account_Trash_dgv.DataSource = dt;
            conn.Close();
        }
    }
}
