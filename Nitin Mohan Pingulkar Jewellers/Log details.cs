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
    public partial class Log_details : Form
    {
        SqlConnection con = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["db"].ConnectionString);
        SqlCommand cmd;
        SqlDataReader dr;
        public Log_details()
        {
            InitializeComponent();
        }

        private void Log_details_Load(object sender, EventArgs e)
        {
            con.Open();
            cmd = new SqlCommand("select * from logtable ", con);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            da.Fill(dt);
            dataGridView1.DataSource = dt;
            dataGridView1.Columns[0].HeaderText = "Username";
            dataGridView1.Columns[1].HeaderText = "Password";
            dataGridView1.Columns[2].HeaderText = "Login Date-Time";
            dataGridView1.Columns[3].HeaderText = "Logout Date-Time";

            dataGridView1.Columns[0].Width = 100;
            dataGridView1.Columns[1].Width = 100;
            dataGridView1.Columns[2].Width = 150;
            dataGridView1.Columns[3].Width = 150;

            con.Close();
            
         
        }
    }
}
