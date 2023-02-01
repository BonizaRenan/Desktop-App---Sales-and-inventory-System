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
    public partial class Inventory_Create : Form
    {
        public Inventory_Create()
        {
            InitializeComponent();
        }
        string cs = "datasource=127.0.0.1;port=3306;username=root;password=;database=inventory_products;";

        private void barcode_tb_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void quantity_tb_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btn_Create_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(barcode_tb.Text))
            {
                errordetect.SetError(barcode_tb, "Required Input");
                return;
            }
            else if (string.IsNullOrEmpty(Name_tb.Text))
            {
                errordetect.SetError(Name_tb, "Required Input");
                return;
            }
            else if (string.IsNullOrEmpty(category_tb.Text))
            {
                errordetect.SetError(category_tb, "Required Input");
                return;
            }
            else if (string.IsNullOrEmpty(quantity_tb.Text))
            {
                errordetect.SetError(quantity_tb, "Required Input");
                return;
            }
            else if (string.IsNullOrEmpty(price_tb.Text))
            {
                errordetect.SetError(price_tb, "Required Input");
                return;
            }
            else if (string.IsNullOrEmpty(status_tb.Text))
            {
                errordetect.SetError(status_tb, "Required Input");
                return;
            }
            MySqlConnection conn = new MySqlConnection(cs);
            string sql = "SELECT * FROM items WHERE Barcode='" + barcode_tb.Text +
            "'OR Name='" + Name_tb.Text +"'";
            MySqlCommand Duplicate = new MySqlCommand(sql, conn);
            try
            {
                conn.Open();
                string pid = (string)Duplicate.ExecuteScalar();
                conn.Close();

                if (pid != barcode_tb.Text || pid != Name_tb.Text)
                {
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand("INSERT INTO items (Barcode, Name, Category, Quantity, Unit_Price, Status )" +
                    "VALUES('" + this.barcode_tb.Text + "','" +
                    this.Name_tb.Text + "','" +
                    this.category_tb.Text + "','" +
                    this.quantity_tb.Text + "','" +
                    this.price_tb.Text + "','" +
                    this.status_tb.Text + "')", conn);
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("Successfully Created.");
                    this.Close();

                }

            }
            catch (Exception ex) 
            {
                MessageBox.Show("Already Exist.. Check the items");
            
            }
        }

        private void price_tb_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if (e.KeyChar == '.' && (sender as TextBox).Text.IndexOf('.') > -1)
            {
                e.Handled = true;
            }

            if (!char.IsControl(e.KeyChar))
            {

                TextBox textBox = (TextBox)sender;

                if (textBox.Text.IndexOf('.') > -1 &&
                         textBox.Text.Substring(textBox.Text.IndexOf('.')).Length >= 3)
                {
                    e.Handled = true;
                }

            }
        }

        private void category_tb_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Space);
        }
    }
}
