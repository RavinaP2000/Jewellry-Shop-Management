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
using iTextSharp;
using iTextSharp.text.pdf;
using System.IO;
using iTextSharp.text;

namespace Nitin_Mohan_Pingulkar_Jewellers
{
    public partial class Bill : Form
    {
        SqlConnection con = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["db"].ConnectionString);
        SqlCommand cmd;
        SqlDataReader dr;

        int id;
        double quan, price, gst;
        double a, b, c, d;
        string name, total;

        public Bill()
        {
            InitializeComponent();
        }

        public void loadfun()
        {
            object obj = new object();
            con.Open();
            cmd = new SqlCommand("select pbillid from bill", con);
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                obj = (string)dr["pbillid"].ToString();
            }

            dr.Close();

            if (obj.ToString() == "")
            {
                prod_id_txt.Text = (Convert.ToInt32(1)).ToString();
            }
            else
            {
                prod_id_txt.Text = (Convert.ToInt32(obj) + 1).ToString();

            }
            con.Close();
        }


        private void Bill_Load(object sender, EventArgs e)
        {
            loadfun();
            try
            {

                con.Open();


                cmd = new SqlCommand("select mname from prod_regs", con);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    prod_name_cmb.Items.Add((string)dr["mname"]);
                }
                prod_name_cmb.SelectedItem = prod_name_cmb.SelectedIndex = 0;
                dr.Close();

            }


            catch (Exception ex)
            {
                MessageBox.Show(ex + "");
            }

            con.Close();
        }

        private void Save_btn_Click(object sender, EventArgs e)
        {
            DateTime d = DateTime.Today;

            try
            {

                con.Open();
                id = Convert.ToInt32(prod_id_txt.Text);
                name = prod_name_cmb.SelectedItem.ToString();
                quan = Convert.ToDouble(prod_quan_txt.Text);
                price = Convert.ToDouble(prod_price_txt.Text);
                gst = Convert.ToDouble(prod_gst_txt.Text);

                total = prod_total_txt.Text;
                cmd = new SqlCommand("insert into bill values(" + id + ",'" + name + "','" + quan + "','" + price + "','" + gst + "','" + total + "','" + d.ToShortDateString() + "')", con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Data inserted successfully", "Information");
            }


            catch (Exception ex)
            {
                MessageBox.Show("Please fill all information", "Information");
            }

            con.Close();
            prod_gst_txt.Text = "";
            prod_price_txt.Text = "";
            prod_quan_txt.Text = "";
            prod_total_txt.Text = "";

            loadfun();

        }
    }
}
