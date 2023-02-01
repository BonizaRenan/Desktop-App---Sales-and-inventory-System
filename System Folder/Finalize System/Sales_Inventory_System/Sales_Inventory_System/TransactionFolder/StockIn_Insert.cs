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
    public partial class StockIn_Insert : Form
    {
        public StockIn_Insert()
        {
            InitializeComponent();
        }

        string cs = "datasource=127.0.0.1;port=3306;username=root;password=;database=inventory_products;";

        private void stockInInsert_btn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(totalamount_tb.Text))
            {
                errordetect.SetError(totalamount_tb, "Required Input");
                return;
            }
            MySqlConnection conn = new MySqlConnection(cs);
                string sql = "Select * from stockin_amount where StockIn_Date='" + stockInDate_dt.Value.ToString("yyyy-MM-dd") + "'";
                MySqlCommand Duplicate = new MySqlCommand(sql, conn);
                try
                {
                    conn.Open();
                    string pid = (string)Duplicate.ExecuteScalar();
                    conn.Close();

                    if (pid != stockInDate_dt.Value.ToString("yyyy-MM-dd"))
                    {
                        conn.Open();
                        MySqlCommand cmd = new MySqlCommand("INSERT INTO stockin_amount (StockIn_Date, Total_Amount )" +
                        "VALUES('" + this.stockInDate_dt.Value.ToString("yyyy-MM-dd") + "','" + this.totalamount_tb.Text + "')", conn);
                        cmd.ExecuteNonQuery();
                        conn.Close();
                        MessageBox.Show("Successfully Created.");
                        this.Close();

                    }

                }
                catch
                {

                    MessageBox.Show("Already Exist!! Please check in your Data");
                    this.Close();

                }
            
       
  
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
