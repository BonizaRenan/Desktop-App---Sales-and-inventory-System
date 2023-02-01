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
    public partial class StockOut_Record : Form
    {
        public StockOut_Record()
        {
            InitializeComponent();
            loads();
        }
        string cs = "datasource=127.0.0.1;port=3306;username=root;password=;database=inventory_products;";
        void loads()
        {
            try
            {
                String sql = "SELECT * FROM record_outofstock WHERE Date = curdate()";
                MySqlConnection conn = new MySqlConnection(cs);
                MySqlCommand cmd = new MySqlCommand(sql, conn);

                MySqlDataAdapter adapter = new MySqlDataAdapter();
                adapter.SelectCommand = cmd;
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                BindingSource bsource = new BindingSource();
                bsource.DataSource = dt;
                StockOut_dgv.DataSource = bsource;
                adapter.Update(dt);
                StockOut_dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;

            }
            catch (Exception ex)
            {
                MessageBox.Show("You Dont Have Record Today");
            }
        }

        private void Date_ValueChanged(object sender, EventArgs e)
        {
            string date = Date.Value.ToString("yyyy-MM-dd");
            string sql = "SELECT * FROM record_outofstock WHERE Date LIKE'" +
            date + "%'";
            MySqlConnection conn = new MySqlConnection(cs);
            MySqlDataAdapter da = new MySqlDataAdapter(sql, conn);
            DataTable dt = new DataTable();
            conn.Open();
            da.Fill(dt);
            StockOut_dgv.DataSource = dt;
            conn.Close();
        }

        private void delete_btn_Click(object sender, EventArgs e)
        {
           
                string id = StockOut_dgv.CurrentRow.Cells["Record_ID"].Value.ToString();
                string message = "Are you sure want to Delete " + id + " Permanently ?";

                if (MessageBox.Show(message, "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    string query = "DELETE FROM record_outofstock WHERE Record_ID='" + id + "'";
                    MySqlConnection conn = new MySqlConnection(cs);
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Successfully Deleted");
                    conn.Close();
                    loads();
                
                }
           
        }



   
    }
}
