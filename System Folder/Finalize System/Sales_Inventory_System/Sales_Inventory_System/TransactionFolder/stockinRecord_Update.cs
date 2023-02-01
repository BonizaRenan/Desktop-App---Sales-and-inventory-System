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
    public partial class stockinRecord_Update : Form
    {
        public stockinRecord_Update()
        {
            InitializeComponent();
        }
        string cs = "datasource=127.0.0.1;port=3306;username=root;password=;database=inventory_products;";

       

        private void stockInDate_dt_ValueChanged(object sender, EventArgs e)
        {
            String sql = "SELECT * FROM stockin_amount WHERE StockIn_Date = '" + stockInDate_dt.Value.ToString("yyyy-MM-dd") + "'";
            MySqlConnection conn = new MySqlConnection(cs);
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            conn.Open();
            MySqlDataReader dr = cmd.ExecuteReader();


            if (dr.Read())
            {
                totalamount_tb.Text = dr.GetString("Total_Amount");
              


            }
            else
            {
                totalamount_tb.Clear();
              

            }
            conn.Close();
        }

        private void Update_btn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(totalamount_tb.Text))
            {
                errordetect.SetError(totalamount_tb, "Required Input");
                return;
            }
            string query = "UPDATE stockin_amount SET Total_Amount = '" + this.totalamount_tb.Text +
             "' WHERE StockIn_Date = '" + stockInDate_dt.Value.ToString("yyyy-MM-dd") +
             "'";
            MySqlConnection conn = new MySqlConnection(cs);
            MySqlCommand cmd = new MySqlCommand(query, conn);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Successfully Update!");
            this.Close();
        }

        private void totalamount_tb_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && !".".Contains(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
