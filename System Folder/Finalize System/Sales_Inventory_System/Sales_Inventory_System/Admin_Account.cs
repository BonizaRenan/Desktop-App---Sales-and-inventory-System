using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using Sales_Inventory_System;
using System.Windows.Forms;

namespace Sales_Inventory_System
{
    public partial class Admin_Account : Form
    {
        public Admin_Account()
        {
            InitializeComponent();
        }
        string cs = "datasource=127.0.0.1;port=3306;username=root;password=;database=inventory_accounts;";

        void Loads()
        {
            String sql = "SELECT * FROM logins";
            MySqlConnection conn = new MySqlConnection(cs);
            MySqlCommand cmd = new MySqlCommand(sql, conn);

            MySqlDataAdapter adapter = new MySqlDataAdapter();
            adapter.SelectCommand = cmd;
            DataTable dt = new DataTable();
            adapter.Fill(dt);

            BindingSource bsource = new BindingSource();
            bsource.DataSource = dt;
            Account_dgv.DataSource = bsource;
            adapter.Update(dt);
            Account_dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;



        }
        //Admin_Account_Load that can show a database
        private void Admin_Account_Load(object sender, EventArgs e)
        {
            Loads();
        }
        
        
       

        //Insert_btn_Click he call the other form 
        private void Insert_btn_Click(object sender, EventArgs e)
        {
            Form Accountcreate = new other_form.Account_Create();
            Accountcreate.ShowDialog();
            Loads();
        }


        //Update_btn_Click he can execute if you want to change a data
        private void Update_btn_Click(object sender, EventArgs e)
        {
            //String sql = "SELECT * FROM logins";
            //MySqlConnection conn = new MySqlConnection(cs);
            //MySqlCommand cmd = new MySqlCommand(sql, conn);
            //try
            //{
            //    for (int item = 0; item <= Account_dgv.Rows.Count - 1; item++)
            //    {

            //        conn.Open();
            //        cmd = new MySqlCommand("UPDATE Logins SET Firstname=@Firstname, Lastname = @Lastname," +
            //        " username=@username, password=@password, LogIn_Type=@LogIn_Type WHERE Id_No=@Id_No", conn);
            //        cmd.Parameters.AddWithValue("@Firstname", Account_dgv.Rows[item].Cells[1].Value);
            //        cmd.Parameters.AddWithValue("@Lastname", Account_dgv.Rows[item].Cells[2].Value);
            //        cmd.Parameters.AddWithValue("@username", Account_dgv.Rows[item].Cells[3].Value);
            //        cmd.Parameters.AddWithValue("@password", Account_dgv.Rows[item].Cells[4].Value);
            //        cmd.Parameters.AddWithValue("@LogIn_Type", Account_dgv.Rows[item].Cells[5].Value);
            //        cmd.Parameters.AddWithValue("@Id_No", Account_dgv.Rows[item].Cells[0].Value);
            //        cmd.ExecuteNonQuery();
            //        conn.Close();

            //    }
            //    MessageBox.Show("Successfully Update!");
            //    Loads();
            //}
            //catch (Exception ex) 
            //{
            //    MessageBox.Show("You have error on your input please check.....");
            
            //}

            Form Update = new other_form.Account_Update();
            Update.ShowDialog();
            Loads();
        }
    

       
    


        private void Searchbar_tb_TextChanged(object sender, EventArgs e)
        {

            string sql = "SELECT * FROM logins WHERE Id_No LIKE'" +
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
            Account_dgv.DataSource = dt;
            conn.Close();

        }

        //Delete_btn_Click he can delete those data
        private void Delete_btn_Click(object sender, EventArgs e)
        {


            string id = Account_dgv.CurrentRow.Cells["Id_No"].Value.ToString();
            string message = "Are you sure want to Delete "+id+ " ?";

            if (MessageBox.Show(message, "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string query = "INSERT INTO trashbin_logins SELECT * FROM logins WHERE Id_No='" + id + "'";
                MySqlConnection conn = new MySqlConnection(cs);
                MySqlCommand cmd = new MySqlCommand(query, conn);
                conn.Open();
                cmd.ExecuteNonQuery();
                cmd.CommandText = "DELETE FROM logins WHERE Id_No='" + id + "'";
                cmd.ExecuteNonQuery();
                MessageBox.Show("Successfully Deleted");
                conn.Close();
                Loads();
            }

        }

        private void Recycle_btn_Click(object sender, EventArgs e)
        {
            Form Accounttrashbin = new other_form.Account_Trashbin();
            Accounttrashbin.ShowDialog();
            Loads();
        }

      
    }
}
