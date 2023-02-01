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

namespace Sales_Inventory_System.other_form
{
    public partial class Inventory_Update : Form
    {
        public Inventory_Update()
        {
            InitializeComponent();
        }

        string cs = "datasource=127.0.0.1;port=3306;username=root;password=;database=inventory_products;";
        private void id_No_tb_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void Barcode_tb_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }

        }


        private void Category_tb_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Space);
        }

        private void Quantity_tb_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void Unitprice_tb_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && !".".Contains(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void Status_tb_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Space);
        }

        private void id_No_tb_TextChanged(object sender, EventArgs e)
        {
            String sql = "SELECT * FROM items WHERE Id_No = '" + id_No_tb.Text + "'";
            MySqlConnection conn = new MySqlConnection(cs);
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            conn.Open();
            MySqlDataReader dr = cmd.ExecuteReader();

            if (dr.Read())
            {
                Barcode_tb.Text = dr.GetString("Barcode");
                Name_tb.Text = dr.GetString("Name");
                Category_tb.Text = dr.GetString("Category");
                Quantity_tb.Text = dr.GetString("Quantity");
                Unitprice_tb.Text = dr.GetString("Unit_Price");
                Status_tb.Text = dr.GetString("Status");
            }
            else
            {
                Barcode_tb.Clear();
                Name_tb.Clear();
                Category_tb.Clear();
                Quantity_tb.Clear();
                Unitprice_tb.Clear();
               
            }
            conn.Close();
        }

        private void Update_btn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Barcode_tb.Text))
            {
                errordetect.SetError(Barcode_tb, "Required Input");
                return;
            }
            else if (string.IsNullOrEmpty(Name_tb.Text))
            {
                errordetect.SetError(Name_tb, "Required Input");
                return;
            }
            else if (string.IsNullOrEmpty(Category_tb.Text))
            {
                errordetect.SetError(Category_tb, "Required Input");
                return;
            }
            else if (string.IsNullOrEmpty(Quantity_tb.Text))
            {
                errordetect.SetError(Quantity_tb, "Required Input");
                return;
            }
            else if (string.IsNullOrEmpty(Unitprice_tb.Text))
            {
                errordetect.SetError(Unitprice_tb, "Required Input");
                return;
            }
            else if (string.IsNullOrEmpty(Status_tb.Text))
            {
                errordetect.SetError(Status_tb, "Required Input");
                return;
            }
            string query = "UPDATE items SET Barcode = '" + this.Barcode_tb.Text +
              "', Name ='" + this.Name_tb.Text +
              "', Category ='" + this.Category_tb.Text +
              "', Quantity ='" + this.Quantity_tb.Text +
              "', Unit_Price = '" + this.Unitprice_tb.Text +
              "', Status ='" + this.Status_tb.Text +
              "' WHERE Id_No= '" + this.id_No_tb.Text +
              "'";

            MySqlConnection conn = new MySqlConnection(cs);
            MySqlCommand cmd = new MySqlCommand(query, conn);
            MySqlDataReader dr;
            conn.Open();
            dr = cmd.ExecuteReader();
            MessageBox.Show("Succefully Update!");
            conn.Close();
            this.Close();
        }

        
    }
}
