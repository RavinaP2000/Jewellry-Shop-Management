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
    public partial class Prod_Details : Form
    {
        SqlConnection con = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["db"].ConnectionString);
        SqlCommand cmd;
        SqlDataReader dr;

        string mname;

        public Prod_Details()
        {
            InitializeComponent();
        }

        private void Prod_Details_Load(object sender, EventArgs e)
        {
            display();
            display1();
        }

        private void display_btn_Click(object sender, EventArgs e)
        {
            display();
            display1();
        }

        public void displaysearch()
        {
            try
            {

                con.Open();
                mname = medi_name.Text;
                cmd = new SqlCommand("select mid,mname,mtype,mmatra,manupan,minname,minvalue from prod_regs where mname='" + mname + "'", con);

                dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    medi_id.Text = (string)dr["mid"].ToString();
                    medi_name.Text = (string)dr["mname"];
                    mtype_txt.Text = (string)dr["mtype"];
                    medi_matra.Text = (string)dr["mmatra"];
                    medi_anupan.Text = (string)dr["manupan"];
                    ming_txt.Text = (string)dr["minname"];
                    inval_txt.Text = (string)dr["minvalue"];


                }


                dr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }

            con.Close();


        }

        private void delete_btn_Click(object sender, EventArgs e)
        {
            if (medi_name.Text == "")
            {

                MessageBox.Show("Please enter product name to delete details", "Information");

                medi_name.Focus();
            }
            else
            {
                try
                {
                    mname = medi_name.Text;
                    con.Open();
                    cmd = new SqlCommand("delete from prod_regs where mname='" + mname + "'", con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Record deleted successfully");
                    con.Close();

                    display();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Product name contain only alphabates", "Information");
                }
            }

        }

        public void display1()
        {
            try
            {

                con.Open();

                cmd = new SqlCommand("select mid,mname,mtype,mmatra,manupan,minname,minvalue from prod_regs", con);

                dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    medi_id.Text = (string)dr["mid"].ToString();
                    medi_name.Text = (string)dr["mname"];
                    mtype_txt.Text = (string)dr["mtype"];
                    medi_matra.Text = (string)dr["mmatra"];
                    medi_anupan.Text = (string)dr["manupan"];
                    ming_txt.Text = (string)dr["minname"];
                    inval_txt.Text = (string)dr["minvalue"];
                }


                dr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }

            con.Close();
        }

        public void display()
        {
            try
            {
                con.Open();
                cmd = new SqlCommand("select * from prod_regs", con);
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
            dataGridView1.Columns[0].HeaderText = "Product Id";
            dataGridView1.Columns[1].HeaderText = "Product Name";
            dataGridView1.Columns[2].HeaderText = "Type";
            dataGridView1.Columns[3].HeaderText = "Matra";
            dataGridView1.Columns[4].HeaderText = "Anupan";
            dataGridView1.Columns[5].HeaderText = "Ingredients Names";
            dataGridView1.Columns[6].HeaderText = "Ingredients Value";

        }

        private void search_btn_Click(object sender, EventArgs e)
        {
            if (medi_name.Text == "")
            {


                MessageBox.Show("Please enter product name to search details", "Information");

                medi_name.Focus();
            }

            else
            {
                try
                {
                    mname = medi_name.Text;

                    con.Open();


                    cmd = new SqlCommand("select * from prod_regs where mname='" + mname + "'", con);
                    dr = cmd.ExecuteReader();
                    if (dr.HasRows)
                    {

                        MessageBox.Show("Record find successfully");
                        dr.Close();

                        display();
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
                    MessageBox.Show("" + ex);
                }


            }

        }

        private void clr_btn_Click(object sender, EventArgs e)
        {
            medi_id.Text = "";
            medi_matra.Text = "";
            medi_anupan.Text = "";
            medi_name.Text = "";
            mtype_txt.Text = "";
            inval_txt.Text = "";
            ming_txt.Text = "";
        }

        private void exit_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        int next, prev;
        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {
            medi_id.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            medi_name.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            mtype_txt.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            medi_matra.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            medi_anupan.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
            ming_txt.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
            inval_txt.Text = dataGridView1.SelectedRows[0].Cells[6].Value.ToString();
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {
            try
            {

                prev = this.dataGridView1.CurrentRow.Index - 1;
                this.dataGridView1.CurrentCell = this.dataGridView1.Rows[prev].Cells[this.dataGridView1.CurrentCell.ColumnIndex];
                medi_id.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                medi_name.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                mtype_txt.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                medi_matra.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
                medi_anupan.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
                ming_txt.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
                inval_txt.Text = dataGridView1.SelectedRows[0].Cells[6].Value.ToString();

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
                medi_id.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                medi_name.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                mtype_txt.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                medi_matra.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
                medi_anupan.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
                ming_txt.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
                inval_txt.Text = dataGridView1.SelectedRows[0].Cells[6].Value.ToString();

                displaysearch();
            }
            catch (Exception ex)
            {
                MessageBox.Show("This is last record", "Information");
            }

        }
    }
}
