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
    public partial class Sales_Export : Form
    {

        public Sales_Export()
        {
            InitializeComponent();

            loads();
            totalAmmount();
        }

        double Totalamount;
        string cs = "datasource=127.0.0.1;port=3306;username=root;password=;database=inventory_products;";

        void loads()
        {

            String sql = "SELECT Date, Barcode, Name, Quantity, Price FROM exportings";
            MySqlConnection conn = new MySqlConnection(cs);
            MySqlCommand cmd = new MySqlCommand(sql, conn);

            MySqlDataAdapter adapter = new MySqlDataAdapter();
            adapter.SelectCommand = cmd;
            DataTable dt = new DataTable();
            adapter.Fill(dt);

            BindingSource bsource = new BindingSource();
            bsource.DataSource = dt;
            Export_dgv.DataSource = bsource;
            adapter.Update(dt);
            Export_dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;



        }
        void totalAmmount()
        {
            
           
            String sql = "SELECT SUM(Price) FROM exportings";
            MySqlConnection conn = new MySqlConnection(cs);
            MySqlCommand cmd = new MySqlCommand(sql, conn);

            conn.Open();
            cmd.ExecuteNonQuery();
            double total = Convert.ToDouble(cmd.ExecuteScalar());
            this.Totalamount = total;
            TotalAmount_lbl.Text = "₱ " + total.ToString();
            conn.Close();

            
            
        }
        private void Print_btn_Click(object sender, EventArgs e)
        {
            DGVPrinter Printer = new DGVPrinter();
            Printer.Title = "Centro Mercado Store \n Sales Report";
            Printer.TitleSpacing = 30;
            Printer.SubTitle = "Total Amount: " + TotalAmount_lbl.Text + "     |     Total Grocery: " + Income_lbl.Text + "     |     Profit: " + Profit_lbl.Text;
            Printer.SubTitleColor = Color.Black;
            Printer.SubTitleSpacing = 15;
            Printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
            Printer.PageNumbers = true;
            Printer.PageNumberInHeader = false;
            Printer.PorportionalColumns = true;
            Printer.HeaderCellAlignment = StringAlignment.Near;
            Printer.printDocument.DefaultPageSettings.Landscape = true;
            Printer.PrintDataGridView(Export_dgv);


            String sql = "DELETE FROM exportings";
            MySqlConnection conn = new MySqlConnection(cs);
            MySqlCommand cmd = new MySqlCommand(sql, conn);

            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
            this.Close();
        }

        private void Sales_Export_FormClosed(object sender, FormClosedEventArgs e)
        {
            String sql = "DELETE FROM exportings";
            MySqlConnection conn = new MySqlConnection(cs);
            MySqlCommand cmd = new MySqlCommand(sql, conn);

            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
            this.Close();
        }




        private void Selection_btn_Click(object sender, EventArgs e)
        {
            try
            {

                Income_Selection income_Selection = new Income_Selection();
                income_Selection.ShowDialog();
                Income_lbl.BringToFront();
                Income_lbl.Text = "₱ " + income_Selection.TotalAmount_tb.Text;


                string amounttxt = income_Selection.TotalAmount_tb.Text;
                double Income = Convert.ToDouble(amounttxt);
                double Profit;
                double allamount = this.Totalamount;

                if (allamount >= Income)
                {
                    Profit = allamount - Income;
                    Profit_lbl.Text = "₱ " + Profit.ToString();
                }
                else
                {

                    Profit = allamount - Income;
                    Profit_lbl.Text = "₱ " + Profit.ToString();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Your not Selected....");
                this.Close();
            }
        }



        //private void Selection_btn_Click(object sender, EventArgs e)
        //{
        //    Income_Selection income_Selection = new Income_Selection();
        //    income_Selection.ShowDialog();
        //    Income_lbl.BringToFront();
        //    Income_lbl.Text = income_Selection.TotalAmount_tb.Text; 
        //}


    } 
}
