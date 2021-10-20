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
    public partial class Prod_Regs : Form
    {
        SqlConnection con = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["db"].ConnectionString);
        SqlCommand cmd;
        SqlDataReader dr;
        SqlDataAdapter da;
        int count = 1;
        int count2 = 1;
        int mediid;
        string a, b, c, d, f, g, h, i, j, k, l, m, n, o, p, q, r, s, aa, bb, cc, dd;
        string ingrname, invalue, abc;
        string mname, mtype, mproc, mmatra, manupan, minname, minvalue;
        string name1, value1;
        public Prod_Regs()
        {
            InitializeComponent();
        }

        private void Prod_Regs_Load(object sender, EventArgs e)
        {
            medi_name.Focus();
            Button btn = new Button();
            btn.Click += button1_Click;
            Button btn1 = new Button();
            btn1.Click += button2_Click;

            meditype_cmb.SelectedItem = meditype_cmb.SelectedIndex = 0;

            con.Open();
            SqlCommand cmd1 = new SqlCommand("select mname from prod_regs", con);

            SqlDataReader reader = cmd1.ExecuteReader();
            AutoCompleteStringCollection MyCollection1 = new AutoCompleteStringCollection();
            while (reader.Read())
            {
                MyCollection1.Add(reader.GetString(0));


            }
            reader.Close();
            medi_name.AutoCompleteSource = AutoCompleteSource.CustomSource;
            medi_name.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            medi_name.AutoCompleteCustomSource = MyCollection1;
            //listBox1. pname_txt.AutoCompleteCustomSource = MyCollection;s
            con.Close();

            loadfun();
           
        }

        private void save_btn_Click(object sender, EventArgs e)
        {
            try
            {

                con.Open();
                mediid = Convert.ToInt32(medi_id.Text);
                mname = medi_name.Text;
                mtype = meditype_cmb.SelectedItem.ToString();
                mmatra = medi_matra.Text;
                manupan = medi_anupan.Text;

                a = textBox3.Text; b = textBox12.Text;
                c = textBox4.Text; d = textBox13.Text;
                f = textBox5.Text; g = textBox14.Text;
                h = textBox6.Text; i = textBox15.Text;
                j = textBox7.Text; k = textBox16.Text;
                l = textBox8.Text; m = textBox17.Text;
                n = textBox9.Text; o = textBox18.Text;
                p = textBox10.Text; q = textBox19.Text;
                r = textBox11.Text; s = textBox20.Text;
                aa = textBox21.Text; bb = textBox22.Text;
                cc = textBox23.Text; dd = textBox24.Text;


                minname = "";
                minvalue = "";
                minname = string.Concat(a + "," + c + "," + f + "," + h + "," + j + "," + l + "," + n + "," + p + "," + r + "," + aa + "," + cc);
                minvalue = string.Concat(b + "," + d + "," + g + "," + i + "," + k + "," + m + "," + o + "," + q + "," + s + "," + bb + "," + dd);

                cmd = new SqlCommand("insert into prod_regs values(" + mediid + ",'" + mname + "','" + mtype + "','" + mmatra + "','" + manupan + "','" + minname + "','" + minvalue + "')", con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Information successfully submited", "Information");
                con.Close();
                clr();
                loadfun();
            }



            catch (Exception ex)
            {

                MessageBox.Show("found" + ex);
            }
            con.Close();


        }

        private void clr_btn_Click(object sender, EventArgs e)
        {
            medi_id.Text = "";
            medi_name.Text = "";
            medi_matra.Text = "";
            medi_anupan.Text = "";
            textBox3.Text = ""; textBox12.Text = "";
            textBox4.Text = ""; textBox13.Text = "";
            textBox5.Text = ""; textBox14.Text = "";
            textBox6.Text = ""; textBox15.Text = "";
            textBox7.Text = ""; textBox16.Text = "";
            textBox8.Text = ""; textBox17.Text = "";
            textBox9.Text = ""; textBox18.Text = "";
            textBox10.Text = ""; textBox19.Text = "";
            textBox11.Text = ""; textBox20.Text = "";
            textBox21.Text = ""; textBox22.Text = "";
            textBox23.Text = ""; textBox24.Text = "";
            loadfun();
        }

        private void view_btn_Click(object sender, EventArgs e)
        {
            try
            {
                if (medi_id.Text == "")
                {
                    MessageBox.Show("Please enter product id", "Information");
                }

                mediid = Convert.ToInt32(medi_id.Text);

                con.Open();
                cmd = new SqlCommand("select * from prod_regs where mid=" + mediid + "", con);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    medi_id.Text = (string)dr["mid"].ToString();
                    medi_name.Text = (string)dr["mname"];
                    meditype_cmb.Items.Add((string)dr["mtype"].ToString());
                    medi_matra.Text = (string)dr["mmatra"];
                    medi_anupan.Text = (string)dr["manupan"];

                    name1 = (string)dr["minname"];
                    value1 = (string)dr["minvalue"];

                }
                dr.Close();


                textBox3.Text = name1.Split(',')[0];
                textBox4.Text = name1.Split(',')[1];
                textBox5.Text = name1.Split(',')[2];
                textBox6.Text = name1.Split(',')[3];
                textBox7.Text = name1.Split(',')[4];
                textBox8.Text = name1.Split(',')[5];
                textBox9.Text = name1.Split(',')[6];
                textBox10.Text = name1.Split(',')[7];
                textBox11.Text = name1.Split(',')[8];

                textBox12.Text = value1.Split(',')[0];
                textBox13.Text = value1.Split(',')[1];
                textBox14.Text = value1.Split(',')[2];
                textBox15.Text = value1.Split(',')[3];
                textBox16.Text = value1.Split(',')[4];
                textBox17.Text = value1.Split(',')[5];
                textBox18.Text = value1.Split(',')[6];
                textBox19.Text = value1.Split(',')[7];
                textBox20.Text = value1.Split(',')[8];

                textBox21.Text = name1.Split(',')[9];
                textBox22.Text = value1.Split(',')[9];
                textBox23.Text = name1.Split(',')[10];
                textBox24.Text = value1.Split(',')[10];
                cmd = new SqlCommand("select * from prod_regs where mid=" + mediid + "", con);
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                }
                else
                {
                    MessageBox.Show("Sorry medicine dose not found", "Information");
                    clr();
                }
                dr.Close();
            }
            catch (Exception ex)
            {
                //MessageBox.Show("Please enter medicine id","Information");
                //viewids();       
            }

            con.Close();
        }

        private void update_btn_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                mediid = Convert.ToInt32(medi_id.Text);

                mname = medi_name.Text;
                mtype = meditype_cmb.SelectedItem.ToString();
                mmatra = medi_matra.Text;
                manupan = medi_anupan.Text;

                a = textBox3.Text; b = textBox12.Text;
                c = textBox4.Text; d = textBox13.Text;
                f = textBox5.Text; g = textBox14.Text;
                h = textBox6.Text; i = textBox15.Text;
                j = textBox7.Text; k = textBox16.Text;
                l = textBox8.Text; m = textBox17.Text;
                n = textBox9.Text; o = textBox18.Text;
                p = textBox10.Text; q = textBox19.Text;
                r = textBox11.Text; s = textBox20.Text;
                aa = textBox21.Text; bb = textBox22.Text;
                cc = textBox23.Text; dd = textBox24.Text;

                minname = "";
                minvalue = "";
                minname = string.Concat(a + "," + c + "," + f + "," + h + "," + j + "," + l + "," + n + "," + p + "," + r + "," + aa + "," + cc);
                minvalue = string.Concat(b + "," + d + "," + g + "," + i + "," + k + "," + m + "," + o + "," + q + "," + s + "," + bb + "," + dd);

                cmd = new SqlCommand("update prod_regs set mname='" + mname + "',mtype='" + mtype + "',mproc='" + mproc + "',mmatra='" + mmatra + "',manupan='" + manupan + "',minname='" + minname + "',minvalue='" + minvalue + "' where mid=" + mediid + "", con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Information successfully updated");


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex + "");
            }

        }

        private void exit_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void loadfun()
        {
            object obj = new object();
            con.Open();
            cmd = new SqlCommand("select mid from prod_regs", con);
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                obj = (string)dr["mid"].ToString();
            }

            dr.Close();

            if (obj.ToString() == "")
            {
                medi_id.Text = (Convert.ToInt32(1)).ToString();
            }
            else
            {
                //medi_id.Text = (Convert.ToInt32(obj) + 1).ToString();

            }
            con.Close();
        }

        public void clr()
        {
            medi_id.Text = "";
            medi_name.Text = "";
            medi_matra.Text = "";
            medi_anupan.Text = "";
            textBox3.Text = ""; textBox12.Text = "";
            textBox4.Text = ""; textBox13.Text = "";
            textBox5.Text = ""; textBox14.Text = "";
            textBox6.Text = ""; textBox15.Text = "";
            textBox7.Text = ""; textBox16.Text = "";
            textBox8.Text = ""; textBox17.Text = "";
            textBox9.Text = ""; textBox18.Text = "";
            textBox10.Text = ""; textBox19.Text = "";
            textBox11.Text = ""; textBox20.Text = "";
            textBox21.Text = ""; textBox22.Text = "";
            textBox23.Text = ""; textBox24.Text = "";
            loadfun();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int p = count++;
            if (p == 1)
            {
                textBox3.Visible = true; textBox12.Visible = true;

            }
            if (p == 2)
            {
                textBox4.Visible = true; textBox13.Visible = true;

            }
            if (p == 3)
            {
                textBox5.Visible = true; textBox14.Visible = true;

            }
            if (p == 4)
            {
                textBox6.Visible = true; textBox15.Visible = true;

            }
            if (p == 5)
            {
                textBox7.Visible = true; textBox16.Visible = true;

            }
            if (p == 6)
            {
                textBox8.Visible = true; textBox17.Visible = true;

            }
            if (p == 7)
            {
                textBox9.Visible = true; textBox18.Visible = true;

            }
            if (p == 8)
            {
                textBox10.Visible = true; textBox19.Visible = true;

            }
            if (p == 9)
            {
                textBox11.Visible = true; textBox20.Visible = true;

            }
            if (p == 10)
            {
                textBox21.Visible = true; textBox22.Visible = true;

            }
            if (p == 11)
            {
                textBox23.Visible = true; textBox24.Visible = true;

            }

            
        }

        private bool button1_Click()
        {
            throw new NotImplementedException();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int p = count2++;

            if (p == 11)
            {
                textBox3.Visible = false; textBox12.Visible = false;

            }
            if (p == 10)
            {
                textBox4.Visible = false; textBox13.Visible = false;

            }
            if (p == 9)
            {
                textBox5.Visible = false; textBox14.Visible = false;

            }
            if (p == 8)
            {
                textBox6.Visible = false; textBox15.Visible = false;

            }
            if (p == 7)
            {
                textBox7.Visible = false; textBox16.Visible = false;

            }
            if (p == 6)
            {
                textBox8.Visible = false; textBox17.Visible = false;

            }
            if (p == 5)
            {
                textBox9.Visible = false; textBox18.Visible = false;

            }
            if (p == 4)
            {
                textBox10.Visible = false; textBox19.Visible = false;

            }
            if (p == 3)
            {
                textBox11.Visible = false; textBox20.Visible = false;

            }
            if (p == 1)
            {
                textBox23.Visible = false; textBox24.Visible = false;

            }
            if (p == 2)
            {
                textBox21.Visible = false; textBox22.Visible = false;

            }
           


        }

        private void button3_Click(object sender, EventArgs e)
        {
            Prod_Details dt = new Prod_Details();
            dt.Show();
        }
    }
}
