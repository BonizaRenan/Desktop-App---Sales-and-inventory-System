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

namespace Sales_Inventory_System.SalesFolder
{
    public partial class Weekly_Sale : Form
    {
        public Weekly_Sale()
        {
            InitializeComponent();
            loads();
        }
        string cs = "datasource=127.0.0.1;port=3306;username=root;password=;database=inventory_products;";
        void loads()
        {
            try
            {
                String sql = "SELECT Date, Barcode, Name, Quantity, Price FROM record_outofstock WHERE week(Date) = week(now())";
                MySqlConnection conn = new MySqlConnection(cs);
                MySqlCommand cmd = new MySqlCommand(sql, conn);

                MySqlDataAdapter adapter = new MySqlDataAdapter();
                adapter.SelectCommand = cmd;
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                BindingSource bsource = new BindingSource();
                bsource.DataSource = dt;
                Transact_dgv.DataSource = bsource;
                adapter.Update(dt);
                Transact_dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;

                conn.Open();
                cmd.CommandText = "SELECT SUM(Price)AS Total FROM record_outofstock WHERE week(Date) = week(now())";
                cmd.ExecuteNonQuery();
                double total = Convert.ToDouble(cmd.ExecuteScalar());
                TotalAmount_lbl.Text = "₱ " + total.ToString();
                conn.Close();
            }
            catch (Exception ex) 
            {
                MessageBox.Show("You Dont Have Record For This Week");
            }
        }

        private void Weekly_Sale_Load(object sender, EventArgs e)
        {

        }
    }
}
