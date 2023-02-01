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
    public partial class stockinProduct_Update : Form
    {
        public stockinProduct_Update()
        {
            InitializeComponent();
        }
        public static int value;
        public static int value2;
        string cs = "datasource=127.0.0.1;port=3306;username=root;password=;database=inventory_products;";

        void addValue()
            {
            String sql = "SELECT * FROM items Where Barcode = '"+Barcode_tb.Text+"'";
            MySqlConnection conn = new MySqlConnection(cs);
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            MySqlDataReader dr = cmd.ExecuteReader();

            if (dr.Read()) 
            {
                int Valuequantity = dr.GetInt32("Quantity");
                value = Valuequantity;

            }
          
            }
        void addValue2()
        {
            String sql = "SELECT * FROM stockin_Product Where Barcode = '" + Barcode_tb.Text + "'";
            MySqlConnection conn = new MySqlConnection(cs);
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            MySqlDataReader dr = cmd.ExecuteReader();

            if (dr.Read())
            {
                int Valuequantity1 = dr.GetInt32("Quantity");
                value2 = Valuequantity1;

            }
        }

            private void id_No_tb_TextChanged(object sender, EventArgs e)
        {
            String sql = "SELECT * FROM stockin_Product WHERE Id = '" + id_No_tb.Text + "'";
            MySqlConnection conn = new MySqlConnection(cs);
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            conn.Open();
            MySqlDataReader dr = cmd.ExecuteReader();

            if (dr.Read())
            {
                Barcode_tb.Text = dr.GetString("Barcode");
                itemName_tb.Text = dr.GetString("Name");
                Category_tb.Text = dr.GetString("Category");
                quantity_tb.Text = dr.GetString("Quantity");
                

            }
            else
            {
                Barcode_tb.Clear();
                itemName_tb.Clear();
                Category_tb.Clear();
                quantity_tb.Clear();
                

            }
            conn.Close();
        }

        private void Update_btn_Click(object sender, EventArgs e)
        {
            try
            {
                int value1 = value;
                int value02 = value2;
                int quantity = 0;
                int total = 0;
                quantity = Convert.ToInt32(quantity_tb.Text);

                if (value02 > quantity)
                {
                    total = value02 - quantity;
                    int amount = total + value1;

                    string query = "UPDATE stockin_Product SET Quantity ='" + quantity +
                    "' WHERE Id= '" + this.id_No_tb.Text +
                    "'";

                    MySqlConnection conn = new MySqlConnection(cs);
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    cmd.CommandText = "UPDATE items SET Quantity='" + amount + "'WHERE Barcode='" + Barcode_tb.Text + "'";
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Succefully Update!");
                    conn.Close();
                    this.Close();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error! Check your Input..");
            }
        }

       
    }
}
