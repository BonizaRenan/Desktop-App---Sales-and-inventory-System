using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sales_Inventory_System
{
    public partial class Admin_Inventory : Form
    {
        public Admin_Inventory()
        {
            InitializeComponent();
        }
        string cs = "datasource=127.0.0.1;port=3306;username=root;password=;database=inventory_products;";

         void Loads()
        {
            try
            {
                String sql = "SELECT * FROM items";
                MySqlConnection conn = new MySqlConnection(cs);
                MySqlCommand cmd = new MySqlCommand(sql, conn);

                MySqlDataAdapter adapter = new MySqlDataAdapter();
                adapter.SelectCommand = cmd;
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                BindingSource bsource = new BindingSource();
                bsource.DataSource = dt;
                Inventory_dgv.DataSource = bsource;
                adapter.Update(dt);
                Inventory_dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            }
            catch (Exception ex) 
            {
            
                MessageBox.Show("error");

            

            }

        }

        private void Admin_Inventory_Load(object sender, EventArgs e)
        {
            Loads();

        }

        private void Insert_btn_Click(object sender, EventArgs e)
        {
            Form InventoryInsert = new other_form.Inventory_Create();
            InventoryInsert.ShowDialog();
            Loads();
        }

        private void Update_btn_Click(object sender, EventArgs e)
        {
            //String sql = "SELECT * FROM items";
            //MySqlConnection conn = new MySqlConnection(cs);
            //MySqlCommand cmd = new MySqlCommand(sql, conn);
          

            //    for (int item = 0; item <= Inventory_dgv.Rows.Count - 1; item++)
            //    {
                
            //        conn.Open();
            //        cmd = new MySqlCommand("UPDATE items SET Barcode = @Barcode, Name = @Name , Category= @Category, Quantity=@Quantity, Unit_Price=@Unit_Price, Status=@Status WHERE Id_No=@Id_No", conn);
            //        cmd.Parameters.AddWithValue("@Barcode", Inventory_dgv.Rows[item].Cells[1].Value);
            //        cmd.Parameters.AddWithValue("@Name", Inventory_dgv.Rows[item].Cells[2].Value);
            //        cmd.Parameters.AddWithValue("@Category", Inventory_dgv.Rows[item].Cells[3].Value);
            //        cmd.Parameters.AddWithValue("@Quantity", Inventory_dgv.Rows[item].Cells[4].Value);
            //        cmd.Parameters.AddWithValue("@Unit_Price", Inventory_dgv.Rows[item].Cells[5].Value);
            //        cmd.Parameters.AddWithValue("@Status", Inventory_dgv.Rows[item].Cells[6].Value);
            //        cmd.Parameters.AddWithValue("@Id_No", Inventory_dgv.Rows[item].Cells[0].Value);
            //        cmd.ExecuteNonQuery();
            //        conn.Close();
              

            //    }
            //    MessageBox.Show("Successfully Update!");
            //    Loads();

            Form Update = new other_form.Inventory_Update();
            Update.ShowDialog();
            Loads();
           
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
            Inventory_dgv.DataSource = dt;
            conn.Close();
        }

        private void Delete_btn_Click(object sender, EventArgs e)
        {
            string id = Inventory_dgv.CurrentRow.Cells["Id_No"].Value.ToString();
            string message = "Are you sure want to Delete " + id + " ?";

            if (MessageBox.Show(message, "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string query = "INSERT INTO trashbin_items SELECT * FROM items WHERE Id_No='" + id + "'";
                MySqlConnection conn = new MySqlConnection(cs);
                MySqlCommand cmd = new MySqlCommand(query, conn);
                conn.Open();
                cmd.ExecuteNonQuery();
                cmd.CommandText = "DELETE FROM items WHERE Id_No='" + id + "'";
                cmd.ExecuteNonQuery();
                MessageBox.Show("Successfully Deleted");
                conn.Close();
                Loads();
            }
        }

        private void Recycle_btn_Click(object sender, EventArgs e)
        {
            Form Inventorytrashbin = new other_form.Inventory_Trashbin();
            Inventorytrashbin.ShowDialog();
            Loads();    
        }
    }
}
