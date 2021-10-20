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
    public partial class Employee_Details : Form
    {
        SqlConnection con = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["db"].ConnectionString);
        SqlCommand cmd;
        SqlDataReader dr;

        double epin, esal;
        int eid, a, eexp;
        string ename, eadd, estate, edist, etal, egender, econtact, equal, eemail, edate;
        string s;
        public Employee_Details()
        {
            InitializeComponent();
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

        public void displaysearch()
        {
            try
            {

                eid = Convert.ToInt32(empregs_id.Text);
                con.Open();

                cmd = new SqlCommand("select eid,ename,eadd,econtact,equal,eexp,esalary from emp_regs where eid=" + eid + "", con);

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

        private void Employee_Details_Load(object sender, EventArgs e)
        {
            display();
            display1();
        }

        private void display_btn_Click(object sender, EventArgs e)
        {
            display();
            display1();
        }

        private void update_btn_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                eadd = empregs_add.Text;
                econtact = empregs_contact.Text;
                equal = empregs_qual.Text;
                eexp = Convert.ToInt32(empregs_expr.Text);
                esal = Convert.ToInt64(empregs_sal.Text);

                cmd = new SqlCommand("update emp_regs set eadd='" + eadd + "', econtact='" + econtact + "',equal='" + equal + "',eexp=" + eexp + ",esal=" + esal + " where eid=" + eid + "", con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Record updated successfully");
               
                con.Close();
                display();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Id contain only numbers", "Information");
            }  
        }

        private void delete_btn_Click(object sender, EventArgs e)
        {

            if (empregs_id.Text == "")
            {

                MessageBox.Show("Please enter employee id to delete details", "Information");

                empregs_id.Focus();
            }
            else
            {

                try
                {

                    eid = Convert.ToInt32(empregs_id.Text);
                    con.Open();
                    cmd = new SqlCommand("delete from emp_regs where eid=" + eid + "", con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Record deleted successfully");
                    con.Close();
                    display();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Id contain only numbers", "Information");
                }
            }
        }

        private void search_btn_Click(object sender, EventArgs e)
        {
            if (empregs_id.Text == "")
            {

                MessageBox.Show("Please enter employee id to search details", "Information");

                empregs_id.Focus();
            }
            else
            {

                try
                {

                    ename = empregs_name.Text;
                    con.Open();


                    cmd = new SqlCommand("select * from emp_regs", con);
                    dr = cmd.ExecuteReader();
                    if (dr.HasRows)
                    {

                        cmd = new SqlCommand("select * from emp_regs where ename='" + ename + "'", con);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Record find successfully");
                        display();
                        dr.Close();
                        displaysearch();
                    }
                    else
                    {
                        MessageBox.Show("No such record found in database", "Information");
                    }
                    con.Close();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Please enter correct name", "Information");
                }
            }
        }

        private void clr_btn_Click(object sender, EventArgs e)
        {
            empregs_id.Text = "";
            empregs_name.Text = "";
            empregs_add.Text = "";
            empregs_contact.Text = "";
            empregs_qual.Text = "";
            empregs_expr.Text = "";
            empregs_sal.Text = "";
        }

        int next, prev;
        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {
            empregs_id.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            empregs_name.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            empregs_add.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            empregs_contact.Text = dataGridView1.SelectedRows[0].Cells[8].Value.ToString();
            empregs_qual.Text = dataGridView1.SelectedRows[0].Cells[9].Value.ToString();
            empregs_expr.Text = dataGridView1.SelectedRows[0].Cells[10].Value.ToString();
            empregs_sal.Text = dataGridView1.SelectedRows[0].Cells[14].Value.ToString();

        }

    

        private void exit_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {
             try
            {

                prev = this.dataGridView1.CurrentRow.Index - 1;
                this.dataGridView1.CurrentCell = this.dataGridView1.Rows[prev].Cells[this.dataGridView1.CurrentCell.ColumnIndex];
                empregs_id.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                empregs_name.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                empregs_add.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                empregs_contact.Text = dataGridView1.SelectedRows[0].Cells[8].Value.ToString();
                empregs_qual.Text = dataGridView1.SelectedRows[0].Cells[9].Value.ToString();
                empregs_expr.Text = dataGridView1.SelectedRows[0].Cells[10].Value.ToString();
                empregs_sal.Text = dataGridView1.SelectedRows[0].Cells[14].Value.ToString();
            
                displaysearch();
            }
            catch (Exception ex)
            {
                MessageBox.Show("This is first record", "Information");
            }
 
         
        }

        private void PictureBox2_Click(object sender, EventArgs e)
        {
             try
            {

                next = this.dataGridView1.CurrentRow.Index + 1;
                this.dataGridView1.CurrentCell = this.dataGridView1.Rows[next].Cells[this.dataGridView1.CurrentCell.ColumnIndex];
                empregs_id.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                empregs_name.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                empregs_add.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                empregs_contact.Text = dataGridView1.SelectedRows[0].Cells[8].Value.ToString();
                empregs_qual.Text = dataGridView1.SelectedRows[0].Cells[9].Value.ToString();
                empregs_expr.Text = dataGridView1.SelectedRows[0].Cells[10].Value.ToString();
                empregs_sal.Text = dataGridView1.SelectedRows[0].Cells[14].Value.ToString();
                displaysearch();
            }
            catch (Exception ex)
            {
                MessageBox.Show("This is last record", "Information");
            }

         
        }
        }
        }
        
    

