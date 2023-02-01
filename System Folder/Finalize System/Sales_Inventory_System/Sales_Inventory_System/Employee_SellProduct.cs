using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Mail;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Sales_Inventory_System
{

    public partial class Employee_SellProduct : Form
    {
        public Employee_SellProduct()
        {
            InitializeComponent();
            Time.Start();
            TIme_lbl.Text = DateTime.Now.ToLongTimeString();
          
        }

        private void Time_Tick(object sender, EventArgs e)
        {
            TIme_lbl.Text = DateTime.Now.ToLongTimeString();
            Time.Start();
        }

        //public static string firstname { get; set; }
        //public static string lastname { get; set; }
        string cs = "datasource=127.0.0.1;port=3306;username=root;password=;database=inventory_products;";
        string cs2 = "datasource=127.0.0.1;port=3306;username=root;password=;database=inventory_accounts;";
        private void Minusquantity_tb_KeyPress(object sender, KeyPressEventArgs e)
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
            SellProduct_dgv.DataSource = bsource;
            adapter.Update(dt);
            SellProduct_dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;

        }

        private void Employee_SellProduct_Load(object sender, EventArgs e)
        {
            loads();
        }

        private void SellProduct_dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.SellProduct_dgv.Rows[e.RowIndex];
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

      

        private void Save_btn_Click(object sender, EventArgs e)
        {
            try
            {
                String sql = "SELECT * FROM items";
                MySqlConnection conn = new MySqlConnection(cs);
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                int quantity = 0;
                int sell = 0;
                int total = 0;
                double price = 0;
                double Amount = 0;
                string firstnames = StaffRecord.firstname;
                string lastnames = StaffRecord.lastname;


                String Out = "Out of Stock";

                quantity = Convert.ToInt32(quantity_lbl.Text);
                sell = Convert.ToInt32(Minusquantity_tb.Text);
                price = Convert.ToDouble(unitPrice_lbl.Text);

                total = quantity - sell;
                Amount = price * sell;
                conn.Open();


                if (sell <= quantity)
                {
                    if (quantity >= 0)
                    {
                        cmd.CommandText = "UPDATE items SET Quantity='" + total + "'WHERE Barcode='" + barcode_lbl.Text + "'";
                        MessageBox.Show("Successfully Sell");
                        cmd.ExecuteNonQuery();
                        loads();
                        cmd.CommandText = "INSERT INTO record_outofstock(Staff_Name, Date, Time, Barcode, Name, Quantity, Price)" +
                            "VALUES(' " + firstnames + " " + lastnames +
                            "' , '" + Date.Value.ToString("yyyy-MM-dd") +
                            "' , '" + TIme_lbl.Text +
                            "' , '" + barcode_lbl.Text +
                            "' , '" + itemName_lbl.Text +
                            "' , '" + Minusquantity_tb.Text +
                            "' , '" + Amount + "')";
                        cmd.ExecuteNonQuery();

                        amount_lbl.Text = "Amount: ₱ " + Amount.ToString();

                        if (total <= 10)
                        {

                            string name = SellProduct_dgv.CurrentRow.Cells["Name"].Value.ToString();

                            string fromMail = "renanboniza03@gmail.com";
                            string fromPassword = "luswtcrutzxyuqbt";


                            MailMessage message = new MailMessage();
                            message.From = new MailAddress(fromMail);
                            message.Subject = "Product Notification";
                            message.To.Add(new MailAddress("renanboniza03@gmail.com"));
                            message.Body = "<html><body> '" + itemName_lbl.Text + "' is at Critical Level. Please Check your Inventory Information.Thank you!</body></html>";
                            message.IsBodyHtml = true;

                            var smtpClient = new SmtpClient("smtp.gmail.com")
                            {

                                Port = 587,
                                Credentials = new NetworkCredential(fromMail, fromPassword),
                                EnableSsl = true,
                            };

                            smtpClient.Send(message);
                            MessageBox.Show(itemName_lbl.Text + " is at Critical Level. ");

                        }

                        if (total == 0)
                        {

                            cmd.CommandText = "UPDATE items SET Status ='" + Out + "'WHERE Barcode='" + barcode_lbl.Text + "'";
                            MessageBox.Show("Out Of Stock");
                            cmd.ExecuteNonQuery();
                            loads();
                            conn.Close();


                        }

                    }
                    else
                    {
                        MessageBox.Show("Out Of Stock");
                    }


                }
                else
                {
                    MessageBox.Show("Not enough item. Please check the Quantity of the product");

                }

                barcode_lbl.Clear();
                itemName_lbl.Clear();
                Category_lbl.Clear();
                quantity_lbl.Clear();
                unitPrice_lbl.Clear();
                Minusquantity_tb.Clear();
            }
            catch (Exception ex) 
            {
                MessageBox.Show("Invalid!");
            }


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
            SellProduct_dgv.DataSource = dt;
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





        //void Record()
        //{

        //    String sql = "INSERT INTO record_outofstock(Barcode, Name, Category, Quantity_Add)"
        //        + "VALUES(' " + this.barcode_lbl.Text +
        //                "' , '" + this.itemName_lbl.Text +
        //                "' , '" + this.Category_lbl.Text +
        //                "' , '" + this.Minusquantity_tb.Text + "')";
        //    MySqlConnection conn = new MySqlConnection(cs);
        //    MySqlCommand cmd = new MySqlCommand(sql, conn);
        //    conn.Open();
        //    MySqlDataReader reader = cmd.ExecuteReader();
        //    conn.Close();


        //}

    }

}
