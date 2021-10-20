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
    public partial class Category_Regs : Form
    {
        SqlConnection con = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["db"].ConnectionString);
        SqlCommand cmd;
        SqlDataReader dr;
        SqlDataAdapter da;

        int count = 1;
        int count2 = 1;
        int cid;
        string cname, ccategory, cproduct;

        public Category_Regs()
        {
            InitializeComponent();
        }

        private void save_btn_Click(object sender, EventArgs e)
        {
            try
            {

                con.Open();
                cid = Convert.ToInt32(c_id.Text);
                cname = c_name.Text;
                ccategory = ccategory_cmb.SelectedItem.ToString();
                cproduct = c_product.Text;

                cmd = new SqlCommand("insert into cat_regs values(" + cid + ",'" + cname + "','" + ccategory + "')", con);
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

        public void loadfun()
        {
            object obj = new object();
            con.Open();
            cmd = new SqlCommand("select cid from cat_regs", con);
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                obj = (string)dr["cid"].ToString();
            }

            dr.Close();

            if (obj.ToString() == "")
            {
                c_id.Text = (Convert.ToInt32(1)).ToString();
            }
            else
            {
                c_id.Text = (Convert.ToInt32(obj) + 1).ToString();

            }
            con.Close();
        }

        public void clr()
        {
            c_id.Text = "";
            c_name.Text = "";
            ccategory_cmb.Text = "";
            c_product.Text = "";
            
            
            loadfun();
        }

        private void clr_btn_Click(object sender, EventArgs e)
        {
            
            c_id.Text = "";
            c_name.Text = "";
            ccategory_cmb.Text = "";
            c_product.Text = "";
            loadfun();
        }

        private void exit_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Category_Regs_Load(object sender, EventArgs e)
        {
            ccategory_cmb.SelectedItem = ccategory_cmb.SelectedIndex = 0;

            con.Open();
            SqlCommand cmd1 = new SqlCommand("select mname from cat_regs", con);

            SqlDataReader reader = cmd1.ExecuteReader();
            AutoCompleteStringCollection MyCollection1 = new AutoCompleteStringCollection();
            while (reader.Read())
            {
                MyCollection1.Add(reader.GetString(0));


            }
            reader.Close();
            c_name.AutoCompleteSource = AutoCompleteSource.CustomSource;
            c_name.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            c_name.AutoCompleteCustomSource = MyCollection1;
            //listBox1. pname_txt.AutoCompleteCustomSource = MyCollection;s
            con.Close();

            loadfun();
           
        }
        }
    }

