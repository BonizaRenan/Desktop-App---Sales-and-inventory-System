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
    public partial class Customize_Sale : Form
    {
        public Customize_Sale()
        {
            InitializeComponent();
            loads();
        }
        string cs = "datasource=127.0.0.1;port=3306;username=root;password=;database=inventory_products;";

        void loads()
        {

            String sql = "SELECT Record_ID, Date, Barcode, Name, Quantity, Price FROM record_outofstock";
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


        }

        private void search_btn_Click(object sender, EventArgs e)
        {
            string sql = "SELECT Record_ID, Date, Barcode, Name, Quantity, Price FROM record_outofstock WHERE Date between '" +
            Date1.Value.ToString("yyyy-MM-dd") + "' and '" + Date2.Value.ToString("yyyy-MM-dd") + "'";
            MySqlConnection conn = new MySqlConnection(cs);
            MySqlDataAdapter da = new MySqlDataAdapter(sql, conn);
            DataTable dt = new DataTable();
            conn.Open();
            da.Fill(dt);
            Transact_dgv.DataSource = dt;
            conn.Close();
        }

        private void Export_btn_Click(object sender, EventArgs e)
        {
            try
            {
                string query = "INSERT INTO exportings SELECT Record_ID, Date, Barcode, Name, Quantity, Price FROM record_outofstock WHERE Date between '" +
                Date1.Value.ToString("yyyy-MM-dd") + "' and '" + Date2.Value.ToString("yyyy-MM-dd") + "'";
                MySqlConnection conn = new MySqlConnection(cs);
                MySqlCommand cmd = new MySqlCommand(query, conn);
                conn.Open();
                cmd.ExecuteNonQuery();

                conn.Close();
                Form export = new SalesFolder.Sales_Export();
                export.ShowDialog();        

            }
            catch (Exception ex)
            {

                MessageBox.Show("You dont have record on that date.. please input a Date");


            }

        }
    }
}
