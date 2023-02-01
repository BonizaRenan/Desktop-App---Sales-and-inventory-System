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
    public partial class StockInProduct_Insert : Form
    {
        public StockInProduct_Insert()
        {
            InitializeComponent();
            Time.Start();
            TIme_lbl.Text = DateTime.Now.ToLongTimeString();
        }
        private void Time_Tick(object sender, EventArgs e)
        {
            Time.Start();
            TIme_lbl.Text = DateTime.Now.ToLongTimeString();
        }
        string cs = "datasource=127.0.0.1;port=3306;username=root;password=;database=inventory_products;";
        private void Barcode_tb_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void addquantity_tb_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void Barcode_tb_TextChanged(object sender, EventArgs e)
        {
            String sql = "SELECT * FROM items WHERE Barcode = '" + Barcode_tb.Text + "'";
            MySqlConnection conn = new MySqlConnection(cs);
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            conn.Open();
            MySqlDataReader dr = cmd.ExecuteReader();

            if (dr.Read())
            {
                itemName_tb.Text = dr.GetString("Name");
                Category_tb.Text = dr.GetString("Category");
                quantity_tb.Text = dr.GetString("Quantity");
                unitPrice_tb.Text = dr.GetString("Unit_Price");

            }
            else
            {
                itemName_tb.Clear();
                Category_tb.Clear();
                quantity_tb.Clear();
                unitPrice_tb.Clear();

            }
            conn.Close();
        }
        void addValue() 
        {
            try
            {
                string firstnames = StaffRecord.firstname;
                string lastnames = StaffRecord.lastname;
                String sql = "INSERT INTO stockin_Product( Staff_Name, StockIn_Date, Time, Barcode, Name, Category, Quantity)"
                 + "VALUES(' " + firstnames + " " + lastnames +
                         "' , '" + this.StockinProduct_Date.Value.ToString("yyyy-MM-dd") +
                          "' , '" + this.TIme_lbl.Text +
                         "' , '" + this.Barcode_tb.Text +
                         "' , '" + this.itemName_tb.Text +
                         "' , '" + this.Category_tb.Text +
                         "' , '" + this.addquantity_tb.Text + "')";
                MySqlConnection conn = new MySqlConnection(cs);
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                conn.Open();
                MySqlDataReader reader = cmd.ExecuteReader();
                conn.Close();
                this.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error! Check your Input..");
            }

        }
      
        private void Save_btn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Barcode_tb.Text))
            {
                errordetect.SetError(Barcode_tb, "Required Input");
                return;
            }

            if (string.IsNullOrEmpty(itemName_tb.Text))
            {
                errordetect.SetError(itemName_tb, "Required Input");
                return;
            }

            if (string.IsNullOrEmpty(addquantity_tb.Text))
            {
                errordetect.SetError(addquantity_tb, "Required Input");
                return;
            }
           
           
            try
            {

                String sql = "SELECT * FROM items";
                MySqlConnection conn = new MySqlConnection(cs);
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                int quantity = 0;
                int stockIn = 0;
                int AddQuantity = 0;
                string In = "Available";

                quantity = Convert.ToInt32(quantity_tb.Text);
                stockIn = Convert.ToInt32(addquantity_tb.Text);

                AddQuantity = quantity + stockIn;

                conn.Open();
                if (quantity >= 0)
                {
                    cmd.CommandText = "UPDATE items SET Quantity='" + AddQuantity + "'WHERE Barcode='" + Barcode_tb.Text + "'";
                    MessageBox.Show("Successfully Added");

                    cmd.ExecuteNonQuery();
                    cmd.CommandText = "UPDATE items SET Status ='" + In + "'WHERE Barcode='" + Barcode_tb.Text + "'";
                    cmd.ExecuteNonQuery();
                    addValue();
                }
                else
                {
                    MessageBox.Show("Disable to Add item");
                }

                conn.Close();
                this.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Disable to Add item");
                this.Close();
            }

        }



        private void itemName_tb_TextChanged(object sender, EventArgs e)
        {
            String sql = "SELECT * FROM items WHERE Name = '" + itemName_tb.Text + "'";
            MySqlConnection conn = new MySqlConnection(cs);
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            conn.Open();
            MySqlDataReader dr = cmd.ExecuteReader();

            if (dr.Read())
            {
                Barcode_tb.Text = dr.GetString("Barcode");
                Category_tb.Text = dr.GetString("Category");
                quantity_tb.Text = dr.GetString("Quantity");
                unitPrice_tb.Text = dr.GetString("Unit_Price");

            }
            else
            {


            }
            conn.Close();
        }

      
    }
}
