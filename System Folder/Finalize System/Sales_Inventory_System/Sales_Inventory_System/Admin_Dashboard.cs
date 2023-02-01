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

namespace Sales_Inventory_System
{
    public partial class Admin_Dashboard : Form
    {
        public Admin_Dashboard()
        {
            InitializeComponent();
            try
            {
                NumberofStock();
                NumberOfSellStock();
                TotalSales();
            }
            catch (Exception ex) 
            {
                MessageBox.Show("You dont have Record today");
            }
        }

        string cs = "datasource=127.0.0.1;port=3306;username=root;password=;database=inventory_products;";

        void NumberofStock()
        {
            String sql = "SELECT SUM(Quantity) FROM items";
            MySqlConnection conn = new MySqlConnection(cs);
            MySqlCommand cmd = new MySqlCommand(sql, conn);

            conn.Open();
            cmd.ExecuteNonQuery();
            int total = Convert.ToInt32(cmd.ExecuteScalar());
            //this.Totalamount = total;
            NumberStocks_tb.Text = total.ToString();
            conn.Close();
        }
        void NumberOfSellStock() 
        {

            String sql = "SELECT SUM(Quantity) FROM record_outofstock WHERE Date = curdate()";
            MySqlConnection conn = new MySqlConnection(cs);
            MySqlCommand cmd = new MySqlCommand(sql, conn);

            conn.Open();
            cmd.ExecuteNonQuery();
            double total = Convert.ToDouble(cmd.ExecuteScalar());
            //this.Totalamount = total;
            Numbersellstock_tb.Text = total.ToString();
            conn.Close();

        }

        void TotalSales()
        {
            String sql = "SELECT SUM(Price) FROM record_outofstock WHERE Date = curdate()";
            MySqlConnection conn = new MySqlConnection(cs);
            MySqlCommand cmd = new MySqlCommand(sql, conn);

            conn.Open();
            cmd.ExecuteNonQuery();
            double total = Convert.ToDouble(cmd.ExecuteScalar());
            //this.Totalamount = total;
            totalSales_tb.Text = "₱ " + total.ToString();
            conn.Close();

        }

        private void totalSales_tb_TextChanged(object sender, EventArgs e)
        {

        }

        private void Numbersellstock_tb_TextChanged(object sender, EventArgs e)
        {

        }

        private void NumberStocks_tb_TextChanged(object sender, EventArgs e)
        {

        }

        private void Update_Box_Enter(object sender, EventArgs e)
        {

        }
    }
}
