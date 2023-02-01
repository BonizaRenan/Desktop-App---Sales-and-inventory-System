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
    public partial class StockIn_Record : Form
    {
        public StockIn_Record()
        {
            InitializeComponent();
            loads();
        }
        string cs = "datasource=127.0.0.1;port=3306;username=root;password=;database=inventory_products;";
        void loads()
        {
            String sql = "SELECT * FROM stockin_amount";
            MySqlConnection conn = new MySqlConnection(cs);
            MySqlCommand cmd = new MySqlCommand(sql, conn);

            MySqlDataAdapter adapter = new MySqlDataAdapter();
            adapter.SelectCommand = cmd;
            DataTable dt = new DataTable();
            adapter.Fill(dt);

            BindingSource bsource = new BindingSource();
            bsource.DataSource = dt;
            StockInTotal_dgv.DataSource = bsource;
            adapter.Update(dt);
            StockInTotal_dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;

        }
        private void Insert_btn_Click(object sender, EventArgs e)
        {
            Form stockInInsert = new TransactionFolder.StockIn_Insert();
            stockInInsert.ShowDialog();
            loads();
        }

        private void StockInTotal_dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Update_btn_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    String sql = "SELECT * FROM stockin_amount";
            //MySqlConnection conn = new MySqlConnection(cs);
            //MySqlCommand cmd = new MySqlCommand(sql, conn);
            //for (int item = 0; item <= StockInTotal_dgv.Rows.Count - 1; item++)
            //{
            //    conn.Open();
            //    cmd = new MySqlCommand("UPDATE stockin_amount SET StockIn_Date =@StockIn_Date, Total_Amount = @Total_Amount WHERE id=@id", conn);
            //    cmd.Parameters.AddWithValue("@StockIn_Date", StockInTotal_dgv.Rows[item].Cells[1].Value);
            //    cmd.Parameters.AddWithValue("@Total_Amount", StockInTotal_dgv.Rows[item].Cells[2].Value);
            //    cmd.Parameters.AddWithValue("@id", StockInTotal_dgv.Rows[item].Cells[0].Value);
            //    cmd.ExecuteNonQuery();
            //    conn.Close();

            //}
          
            //loads();
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("You Cant delete This record. You must Check the record product before deleted this record.");
            //}
            try
            {
                Form Update_stock = new TransactionFolder.stockinRecord_Update();
                Update_stock.ShowDialog();
                loads();

            }
            catch (Exception ex)
            {
                MessageBox.Show("You Cant delete This record. You must Check the record product before deleted this record.");
            }
        }


        private void delete_btn_Click(object sender, EventArgs e)
        {
            try
            {
                string id = StockInTotal_dgv.CurrentRow.Cells["id"].Value.ToString();
            string message = "Are you sure want to Delete " + id + " Permanently ?";

            if (MessageBox.Show(message, "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string query = "DELETE FROM stockin_amount WHERE id='" + id + "'";
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

        private void ProductRecord_btn_Click(object sender, EventArgs e)
        {
            Form product = new TransactionFolder.StockIn_Product();
            product.Show();
        }

        private void Searchbar_tb_TextChanged(object sender, EventArgs e)
        {

        }

        private void Date_ValueChanged(object sender, EventArgs e)
        {
            string date = Date.Value.ToString("yyyy-MM-dd");
            string sql = "SELECT * FROM stockin_amount WHERE StockIn_Date LIKE'" +
            date + "%'";
            MySqlConnection conn = new MySqlConnection(cs);
            MySqlDataAdapter da = new MySqlDataAdapter(sql, conn);
            DataTable dt = new DataTable();
            conn.Open();
            da.Fill(dt);
            StockInTotal_dgv.DataSource = dt;
            conn.Close();
        }
    }
}
