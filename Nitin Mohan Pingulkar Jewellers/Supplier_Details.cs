using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;



namespace Nitin_Mohan_Pingulkar_Jewellers
{
    public partial class Supplier_Details : Form
    {
        SqlConnection con = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["db"].ConnectionString);
        SqlCommand cmd;
        SqlDataReader dr;

        double epin, esal;
        int eid, a, eexp;
        string ename, eadd, estate, edist, etal, egender, econtact, equal, eemail, edate;
        string s;
        public Supplier_Details()
        {
            InitializeComponent();
        }

        private void Supplier_Details_Load(object sender, EventArgs e)
        {
            display();
            display1();
        }

        public void display()
        {
            try
            {
                con.Open();
                cmd = new SqlCommand("select * from emp_regs", con);
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);

                da.Fill(dt);
                dataGridView1.DataSource = dt;
                headertext();
                da.Dispose();
                con.Close();
            }
            catch (Exception ex)
            {

            }
        }

            public void headertext()
        {
            dataGridView1.Columns[0].HeaderText = "Emp.Id";
            dataGridView1.Columns[1].HeaderText = "Emp.Name";
            dataGridView1.Columns[2].HeaderText = "Address";
            dataGridView1.Columns[3].HeaderText = "State";
            dataGridView1.Columns[4].HeaderText = "District";
            dataGridView1.Columns[5].HeaderText = "Tal";
            dataGridView1.Columns[6].HeaderText = "Pin";
            dataGridView1.Columns[7].HeaderText = "Gender";
            dataGridView1.Columns[8].HeaderText = "Contact";
            dataGridView1.Columns[9].HeaderText = "Qualification";
            dataGridView1.Columns[10].HeaderText = "Experience";
            dataGridView1.Columns[11].HeaderText = "Email-Id";
            dataGridView1.Columns[12].HeaderText = "Join Date";
            dataGridView1.Columns[13].HeaderText = "Salary";
            }

            public void display1()
        {
            try
            {
                con.Open();

                cmd = new SqlCommand("select eid,ename,eadd,econtact,equal,eexp,esalary from emp_regs", con);

                dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    empregs_id.Text = (string)dr["eid"].ToString();
                    empregs_name.Text = (string)dr["ename"];
                    empregs_add.Text = (string)dr["eadd"];
                    empregs_contact.Text = (string)dr["econtact"];
                    empregs_qual.Text = (string)dr["equal"];
                    empregs_expr.Text = (string)dr["eexp"].ToString();
                    empregs_sal.Text = (string)dr["esalary"].ToString();

                }

                dr.Close();


            }
            catch (Exception ex)
            {

            }

            con.Close();



        }


        }
    }

