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
    public partial class Inventory_Trashbin : Form
    {
        public Inventory_Trashbin()
        {
            InitializeComponent();
        }

        string cs = "datasource=127.0.0.1;port=3306;username=root;password=;database=inventory_products;";

        void load()
        {

            string query = "SELECT * FROM trashbin_items";
            MySqlConnection conn = new MySqlConnection(cs);
            MySqlCommand cmd = new MySqlCommand(query, conn);
            MySqlDataAdapter da = new MySqlDataAdapter();
            da.SelectCommand = cmd;
            DataTable dt = new DataTable();
            da.Fill(dt);
            Inventory_Trash_dgv.DataSource = dt;
            Inventory_Trash_dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
        }


        private void Inventory_Trashbin_Load(object sender, EventArgs e)
        {
            load();
        }

        private void RestoreAll_btn_Click(object sender, EventArgs e)
        {
            string message = $"Are you sure want to Restore All?";

            if (MessageBox.Show(message, "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string query = "INSERT INTO items SELECT * FROM trashbin_items";
                MySqlConnection conn = new MySqlConnection(cs);
                MySqlCommand cmd = new MySqlCommand(query, conn);
                conn.Open();
                cmd.ExecuteNonQuery();
                cmd.CommandText = "DELETE FROM trashbin_items ";
                cmd.ExecuteNonQuery();
                MessageBox.Show("Successfully Restore");
                conn.Close();
                this.Close();
            }
        }

        private void Restore_btn_Click(object sender, EventArgs e)
        {
            string id = Inventory_Trash_dgv.CurrentRow.Cells["Id_No"].Value.ToString();
            string message = "Are you sure want to Restore " + id + " ?";

            if (MessageBox.Show(message, "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string query = "INSERT INTO items SELECT * FROM trashbin_items WHERE Id_No='" + id + "'";
                MySqlConnection conn = new MySqlConnection(cs);
                MySqlCommand cmd = new MySqlCommand(query, conn);
                conn.Open();
                cmd.ExecuteNonQuery();
                cmd.CommandText = "DELETE FROM trashbin_items WHERE Id_No='" + id + "'";
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
                string query = "DELETE FROM trashbin_items ";
                MySqlConnection conn = new MySqlConnection(cs);
                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataReader dr;
                conn.Open();
                dr = cmd.ExecuteReader();
                conn.Close();
                this.Close();
            }

        }


        private void Delete_btn2_Click(object sender, EventArgs e)
        {
            string id = Inventory_Trash_dgv.CurrentRow.Cells["Id_No"].Value.ToString();
            string message = "Are you sure want to Delete " + id + " ?";

            if (MessageBox.Show(message, "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string query = "DELETE FROM trashbin_items WHERE Id_No='" + id + "'";
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
            string sql = "SELECT * FROM items WHERE Id_No LIKE'" +
           this.Searchbar_tb.Text + "%' OR Barcode LIKE'" +
           this.Searchbar_tb.Text + "%' OR Name LIKE'" +
           this.Searchbar_tb.Text + "%' OR Category LIKE'" +
           this.Searchbar_tb.Text + "%' OR Status LIKE'" +
           this.Searchbar_tb.Text + "%'";
            MySqlConnection conn = new MySqlConnection(cs);
            MySqlDataAdapter da = new MySqlDataAdapter(sql, conn);
            DataTable dt = new DataTable();
            conn.Open();
            da.Fill(dt);
            Inventory_Trash_dgv.DataSource = dt;
            conn.Close();
        }
    }
}
