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

namespace Sales_Inventory_System.TransactionFolder
{
    public partial class StockIn_Product : Form
    {
        public StockIn_Product()
        {
            InitializeComponent();
            loads();
        }
        string cs = "datasource=127.0.0.1;port=3306;username=root;password=;database=inventory_products;";
        void loads()
        {
            String sql = "SELECT * FROM stockin_product";
            MySqlConnection conn = new MySqlConnection(cs);
            MySqlCommand cmd = new MySqlCommand(sql, conn);

            MySqlDataAdapter adapter = new MySqlDataAdapter();
            adapter.SelectCommand = cmd;
            DataTable dt = new DataTable();
            adapter.Fill(dt);

            BindingSource bsource = new BindingSource();
            bsource.DataSource = dt;
            stockInProduct_dgv.DataSource = bsource;
            adapter.Update(dt);
            stockInProduct_dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;

        }
       

        private void Insert_btn_Click(object sender, EventArgs e)
        {
            Form product_insert = new TransactionFolder.StockInProduct_Insert();
            product_insert.ShowDialog();
            loads();
        }

        private void Update_btn_Click(object sender, EventArgs e)
        {
            //String sql = "SELECT * FROM stockin_product";
            //MySqlConnection conn = new MySqlConnection(cs);
            //MySqlCommand cmd = new MySqlCommand(sql, conn);
            //try
            //{
               
            //    for (int item = 0; item <= stockInProduct_dgv.Rows.Count - 1; item++)
            //    {
            //        conn.Open();
            //        cmd = new MySqlCommand("UPDATE stockin_product SET Quantity = @Quantity WHERE Id = @Id", conn);
            //        cmd.Parameters.AddWithValue("@Quantity", stockInProduct_dgv.Rows[item].Cells[5].Value);
            //        cmd.Parameters.AddWithValue("@Id", stockInProduct_dgv.Rows[item].Cells[0].Value);
            //        cmd.ExecuteNonQuery();
            //        conn.Close();

            //    }
            //    MessageBox.Show("Successfully Update!");
            //    loads();
            //}
            //catch (Exception ex) 
            //{
            //    MessageBox.Show("error");
            
            //}

            Form update = new TransactionFolder.stockinProduct_Update();
            update.ShowDialog();
            loads();

        }

        private void delete_btn_Click(object sender, EventArgs e)
        {
            try
            {

                string id = stockInProduct_dgv.CurrentRow.Cells["Id"].Value.ToString();
                string message = "Are you sure want to Delete " + id + " Permanently ?";

                if (MessageBox.Show(message, "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {

                    string query = "DELETE FROM stockin_product WHERE id='" + id + "'";
                    MySqlConnection conn = new MySqlConnection(cs);
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Successfully Deleted");
                    conn.Close();
                    loads();

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("You Cant delete This record. You must Check the record product before deleted this record.");
            }
        }

        private void Searchbar_tb_TextChanged(object sender, EventArgs e)
        {
            string sql = "SELECT * FROM stockin_product WHERE Id LIKE'" +
            this.Searchbar_tb.Text + "%' OR Barcode LIKE'" +
            this.Searchbar_tb.Text + "%' OR Name LIKE'" +
            this.Searchbar_tb.Text + "%' OR Category LIKE'" +
            this.Searchbar_tb.Text + "%'";
            MySqlConnection conn = new MySqlConnection(cs);
            MySqlDataAdapter da = new MySqlDataAdapter(sql, conn);
            DataTable dt = new DataTable();
            conn.Open();
            da.Fill(dt);
            stockInProduct_dgv.DataSource = dt;
            conn.Close();
        }

        private void Date_ValueChanged(object sender, EventArgs e)
        {
            string date = Date.Value.ToString("yyyy-MM-dd");
            string sql = "SELECT * FROM stockin_product WHERE StockIn_Date LIKE'" +
            date + "%'";
            MySqlConnection conn = new MySqlConnection(cs);
            MySqlDataAdapter da = new MySqlDataAdapter(sql, conn);
            DataTable dt = new DataTable();
            conn.Open();
            da.Fill(dt);
            stockInProduct_dgv.DataSource = dt;
            conn.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
