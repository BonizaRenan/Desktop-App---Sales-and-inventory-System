﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Sales_Inventory_System.Employee_Record
{
    public partial class Employee_StockIn : Form
    {
        public Employee_StockIn()
        {
            InitializeComponent();
            loads();
        }
        string cs = "datasource=127.0.0.1;port=3306;username=root;password=;database=inventory_products;";
        void loads()
        {
            try
            {
                String sql = "SELECT * FROM stockin_product Where StockIn_Date = curdate()";
                MySqlConnection conn = new MySqlConnection(cs);
                MySqlCommand cmd = new MySqlCommand(sql, conn);

                MySqlDataAdapter adapter = new MySqlDataAdapter();
                adapter.SelectCommand = cmd;
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                BindingSource bsource = new BindingSource();
                bsource.DataSource = dt;
                Transaction_dgv.DataSource = bsource;
                adapter.Update(dt);
                Transaction_dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            }
            catch (Exception ex) 
            {
                MessageBox.Show("You dont have Transaction record today");
            
            }

        }
        private void Date_ValueChanged(object sender, EventArgs e)
        {
            string date = Date.Value.ToString("yyyy-MM-dd");
            string sql = "SELECT * FROM stockin_product WHERE StockIn_Date LIKE'" +
            date + "%'";
            MySqlConnection conn = new MySqlConnection(cs);
            MySqlDataAdapter da = new MySqlDataAdapter(sql, conn);
            DataTable dt = new DataTable();
            conn.Open();
            da.Fill(dt);
            Transaction_dgv.DataSource = dt;
            conn.Close();
        }
    }
}
