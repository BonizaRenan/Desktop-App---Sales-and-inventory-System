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
    public partial class Employee_Stock_In : Form
    {
        public Employee_Stock_In()
        {
            InitializeComponent();
            loads();
            Time.Start();
            TIme_lbl.Text = DateTime.Now.ToLongTimeString();
        }
        private void Time_Tick(object sender, EventArgs e)
        {
            Time.Start();
            TIme_lbl.Text = DateTime.Now.ToLongTimeString();
        }
        string cs = "datasource=127.0.0.1;port=3306;username=root;password=;database=inventory_products;";

        private void addquantity_tb_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        void loads()
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
            StockIn_dgv.DataSource = bsource;
            adapter.Update(dt);
            StockIn_dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;

        }
        

        private void StockIn_dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.StockIn_dgv.Rows[e.RowIndex];
                barcode_lbl.Text = row.Cells["Barcode"].Value.ToString();
                itemName_lbl.Text = row.Cells["Name"].Value.ToString();
                Category_lbl.Text = row.Cells["Category"].Value.ToString();
                quantity_lbl.Text = row.Cells["Quantity"].Value.ToString();
                unitPrice_lbl.Text = row.Cells["Unit_Price"].Value.ToString();
               
            }
            else
            {
                MessageBox.Show("Invalid!");
            }

        }


        void Record() 
        {
            string firstnames = StaffRecord.firstname;
            string lastnames = StaffRecord.lastname;
            String sql = "INSERT INTO stockin_Product(Staff_Name, StockIn_Date, Time, Barcode, Name, Category, Quantity)"
                + "VALUES(' " + firstnames + " " + lastnames +
                        "' , '" + this.Date.Value.ToString("yyyy-MM-dd") +
                        "' , '" + this.TIme_lbl.Text +
                        "' , '" + this.barcode_lbl.Text +
                        "' , '" + this.itemName_lbl.Text +
                        "' , '" + this.Category_lbl.Text +
                        "' , '" + this.addquantity_tb.Text + "')";
            MySqlConnection conn = new MySqlConnection(cs);
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            conn.Open();
            MySqlDataReader reader = cmd.ExecuteReader();
            conn.Close();

        }


        private void Save_btn_Click(object sender, EventArgs e)
        {
            try
            {
                
                String sql = "SELECT * FROM items";
                MySqlConnection conn = new MySqlConnection(cs);
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                int quantity = 0;
                int stockIn = 0;
                int AddQuantity = 0;
                string In = "Available";

                quantity = Convert.ToInt32(quantity_lbl.Text);
                stockIn = Convert.ToInt32(addquantity_tb.Text);

                AddQuantity = quantity + stockIn;

                conn.Open();
                if (quantity >= 0)
                {
                    cmd.CommandText = "UPDATE items SET Quantity='" + AddQuantity + "'WHERE Barcode='" + barcode_lbl.Text + "'";
                    MessageBox.Show("Successfully Added");
                    Record();
                    cmd.ExecuteNonQuery();
                    cmd.CommandText = "UPDATE items SET Status ='" + In + "'WHERE Barcode='" + barcode_lbl.Text + "'";
                    cmd.ExecuteNonQuery();
                }
                else 
                {
                    MessageBox.Show("Disable to Add item");
                }
                
                loads();
                conn.Close();
                
            }
            catch (Exception ex) 
            {
                MessageBox.Show("Disable to Add item");
                
            }
            barcode_lbl.Clear();
            itemName_lbl.Clear();
            Category_lbl.Clear();
            quantity_lbl.Clear();
            unitPrice_lbl.Clear();
            addquantity_tb.Clear();

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
            StockIn_dgv.DataSource = dt;
            conn.Close();
        }

        private void Date_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                Date.ShowCheckBox = false;
                Date.ShowUpDown = false;

                Date.MinDate = DateTime.Now;
                Date.MaxDate = DateTime.Now;
            }
            catch 
            {
                MessageBox.Show("Disable to Change the date");
            
            }
        }

    








        //private void History_btn_Click(object sender, EventArgs e)
        //{
        //   Form History_stockin = new other_form.History_StockIn();
        //   History_stockin.Show();
        //}
    }
}
