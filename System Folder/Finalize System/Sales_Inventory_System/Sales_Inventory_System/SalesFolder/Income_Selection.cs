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
    public partial class Income_Selection : Form
    {
        public Income_Selection()
        {
            InitializeComponent();
            loads();
        }

        string cs = "datasource=127.0.0.1;port=3306;username=root;password=;database=inventory_products;";
        void loads()
        {
            String sql = "SELECT * FROM stockin_amount";
            MySqlConnection conn = new MySqlConnection(cs);
            MySqlCommand cmd = new MySqlCommand(sql, conn);

            MySqlDataAdapter adapter = new MySqlDataAdapter();
            adapter.SelectCommand = cmd;
            DataTable dt = new DataTable();
            adapter.Fill(dt);

            BindingSource bsource = new BindingSource();
            bsource.DataSource = dt;
            StockInTotal_dgv.DataSource = bsource;
            adapter.Update(dt);
            StockInTotal_dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;

        }

        private void StockInTotal_dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
             
                DataGridViewRow row = this.StockInTotal_dgv.Rows[e.RowIndex];
                TotalAmount_tb.Text = row.Cells["Total_Amount"].Value.ToString();
            }
            this.Close();
        }

        private void Income_btn_Click(object sender, EventArgs e)
        {
            //Sales_Export sales_Export = new Sales_Export();
            
        }

        private void Income_Selection_Load(object sender, EventArgs e)
        {

        }
        //private void StockInTotal_dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        //{
        //    if (e.RowIndex >= 0)
        //    {
        //        Sales_Export sales_Export = new Sales_Export();
        //        DataGridViewRow row = this.StockInTotal_dgv.Rows[e.RowIndex];
        //        sales_Export.Income_lbl.Text = row.Cells["Total_Amount"].Value.ToString();


        //    }
        //}
    }
}
