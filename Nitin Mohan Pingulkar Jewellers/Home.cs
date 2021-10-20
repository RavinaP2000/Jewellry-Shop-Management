using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace Nitin_Mohan_Pingulkar_Jewellers
{
    public partial class Home : Form
    {
        SqlConnection con = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["db"].ConnectionString);
        SqlCommand cmd;
        SqlDataReader dr;
        //  static void main(string[] args);
        Employee_Regs re;
        public string username;
        public string password;
        DateTime dt;
        public string logoutime, logintime;
        public Home(string logint, string user)
        {
            InitializeComponent();
            logintime = logint;
            username = user;
        }
        public Home()
        {
            // TODO: Complete member initialization
        }
        string dnames;
        int ids;

        private void Home_Load(object sender, EventArgs e)
        {
           
        }

        
        private void regiToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        private void registritionToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void calculatorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("calc");
        }

        private void WordpadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("wordpad");
        }

        private void notepadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("notepad");
        }

        private void adminToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void rateModuleToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void employeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Employee_Regs emp = new Employee_Regs();
            emp.Show();
        }

        private void supplierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Supplier_Regs sup = new Supplier_Regs();
            sup.Show();
        }

        private void employeeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Employee_Details epd = new Employee_Details();
            epd.Show();
        }

        private void productToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Prod_Regs ms = new Prod_Regs();
            ms.Show();
        }

        private void logToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Log_details de = new Log_details();
            de.Show();
        }

        private void supplierToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Supplier_Details sa = new Supplier_Details();
            sa.Show();
        }

        private void categoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Category_Regs ms = new Category_Regs();
            ms.Show();
        }

        private void productToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }
    }
}
