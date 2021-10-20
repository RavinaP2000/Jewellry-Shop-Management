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
using System.Text.RegularExpressions;

namespace Nitin_Mohan_Pingulkar_Jewellers
{
    public partial class Supplier_Regs : Form
    {
        SqlConnection con = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["db"].ConnectionString);
        SqlCommand cmd;
        SqlDataReader dr;

        double epin, esal;
        int eid, a, eexp;
        string ename, eadd, estate, edist, etal, egender, econtact, equal, eemail, edate;
        string s;

        public Supplier_Regs()
        {
            InitializeComponent();
        }

        private void empregs_statecmb_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (empregs_statecmb.SelectedIndex.Equals(0))
            {
                empregs_distcmb.Items.Clear();

                empregs_distcmb.Items.Add("Sindhudurg");
                empregs_distcmb.Items.Add("Ratnagiri");
                empregs_distcmb.Items.Add("Thane");
                empregs_distcmb.Items.Add("Bid");
                empregs_distcmb.SelectedItem = empregs_distcmb.SelectedIndex = 0;
            }
            else if (empregs_statecmb.SelectedIndex.Equals(1))
            {
                empregs_distcmb.Items.Clear();

                empregs_distcmb.Items.Add("Panjim");
                empregs_distcmb.Items.Add("Margao");

                empregs_distcmb.SelectedItem = empregs_distcmb.SelectedIndex = 0;
            }
        }

        private void empregs_distcmb_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (empregs_distcmb.SelectedItem.Equals("Sindhudurg"))
            {
                empregs_talcmb.Items.Clear();
                empregs_talcmb.Items.Add("Devgad");
                empregs_talcmb.Items.Add("Dodamarg");
                empregs_talcmb.Items.Add("Kankavli");
                empregs_talcmb.Items.Add("Kudal");
                empregs_talcmb.Items.Add("Malvan");
                empregs_talcmb.Items.Add("Sawantawadi");
                empregs_talcmb.Items.Add("Vengurla");
                empregs_talcmb.Items.Add("Vaibhavwadi");
                empregs_talcmb.SelectedItem = empregs_talcmb.SelectedIndex = 0;
            }
            else if (empregs_distcmb.SelectedItem.Equals("Ratnagiri"))
            {

                empregs_talcmb.Items.Clear();
                empregs_talcmb.Items.Add("Chiplun");
                empregs_talcmb.Items.Add("Rajapur");
                empregs_talcmb.Items.Add("Khed");
                empregs_talcmb.Items.Add("Sangameshvar");

                empregs_talcmb.SelectedItem = empregs_talcmb.SelectedIndex = 0;
            }
            else if (empregs_distcmb.SelectedItem.Equals("Panjim"))
            {

                empregs_talcmb.Items.Clear();
                empregs_talcmb.Items.Add("Mhapusa");
                empregs_talcmb.Items.Add("Bicholim");
                empregs_talcmb.Items.Add("Pernem");

                empregs_talcmb.SelectedItem = empregs_talcmb.SelectedIndex = 0;

            }
            else if (empregs_distcmb.SelectedItem.Equals("Margao"))
            {

                empregs_talcmb.Items.Clear();
                empregs_talcmb.Items.Add("Phonda");
                empregs_talcmb.Items.Add("Salcete");
                empregs_talcmb.Items.Add("Canacona");

                empregs_talcmb.SelectedItem = empregs_talcmb.SelectedIndex = 0;
            }
        }

        private void empregs_savebtn_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();

                eid = Convert.ToInt32(empregs_id.Text);
                ename = empregs_name.Text;
                eadd = empregs_add.Text;
                estate = empregs_statecmb.SelectedItem.ToString();
                edist = empregs_distcmb.SelectedItem.ToString();
                etal = empregs_talcmb.SelectedItem.ToString();
                epin = Convert.ToInt64(empregs_pin.Text);
                econtact = empregs_contact.Text;
                equal = empregs_qual.Text;
                eexp = Convert.ToInt32(empregs_expr.Text);
                eemail = empregs_email.Text;
                edate = Convert.ToString(dateTimePicker1.Value.Date);
                esal = Convert.ToInt64(empregs_sal.Text);

                if (empregs_male.Checked)
                {
                    egender = empregs_male.Text;
                }
                else if (empregs_female.Checked)
                {
                    egender = empregs_female.Text;
                }




                if (ename == "" || eadd == "" || estate == "" || edist == "" || etal == "" || econtact == "" || equal == "" || eemail == "" || edate == "" || egender == "")
                {
                    MessageBox.Show("Please enter all information...");
                }
                if (Validates())
                {


                    cmd = new SqlCommand("insert into sup_regs values(" + eid + ",'" + ename + "','" + eadd + "','" + estate + "','" + edist + "','" + etal + "'," + epin + ",'" + egender + "'," + econtact + ",'" + equal + "'," + eexp + ",'" + eemail + "','" + edate + "'," + esal + ")", con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Information saved successfully...");
                }

                con.Close();

                empregs_id.Text = "";
                empregs_name.Text = "";
                empregs_add.Text = "";
                empregs_pin.Text = "";
                empregs_expr.Text = "";
                empregs_qual.Text = "";
                empregs_sal.Text = "";
                empregs_email.Text = "";
                empregs_contact.Text = "";
                object obj = new object();
                con.Open();
                cmd = new SqlCommand("select eid from sup_regs", con);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    obj = (string)dr["eid"].ToString();
                }

                dr.Close();

                if (obj.ToString() == "")
                {
                    empregs_id.Text = (Convert.ToInt32(1)).ToString();
                }
                else
                {
                    empregs_id.Text = (Convert.ToInt32(obj) + 1).ToString();

                }

            }

            catch (Exception ex)
            {
                MessageBox.Show("Please enter all valid information...");
            }
            con.Close();

        }

        private void empregs_clrbtn_Click(object sender, EventArgs e)
        {
            empregs_id.Text = "";
            empregs_name.Text = "";
            empregs_add.Text = "";
            empregs_pin.Text = "";
            empregs_expr.Text = "";
            empregs_qual.Text = "";
            empregs_sal.Text = "";
            empregs_email.Text = "";
            empregs_contact.Text = "";
            object obj = new object();

            con.Open();

            cmd = new SqlCommand("select eid from sup_regs", con);
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                obj = (string)dr["eid"].ToString();
            }

            dr.Close();

            if (obj.ToString() == "")
            {
                empregs_id.Text = (Convert.ToInt32(1)).ToString();
            }
            else
            {
                empregs_id.Text = (Convert.ToInt32(obj) + 1).ToString();

            }
            con.Close();
        }

        private void empregs_exitbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        protected bool Validates()
        {
            string msg = "";
            int f = 0;
            Regex patName = new Regex(@"[a-zA-z]+");
            Regex patemail = new Regex(@"[a-zA-z.0-9]+@[a-z]+.[a-z]+");
            Regex patcontactno = new Regex(@"[0-9]{10,}");
            Regex pataddress = new Regex(@"[a-z]+");
            Regex patrollno = new Regex(@"[0-9]+");

            if (!patName.IsMatch(empregs_name.Text))
            {
                msg += "Name must contain only alphabates\n";
                f++;
            }

            if (!patName.IsMatch(empregs_qual.Text))
            {
                msg += "Qualification contain only alphabates\n";
                f++;
            }

            if (!patemail.IsMatch(empregs_email.Text))
            {
                msg += "Please enter valide email-id\n";
                f++;
            }

            if (!patrollno.IsMatch(empregs_pin.Text))
            {
                msg += "Pincode contain only numbers\n";
                f++;
            }
            if (!patcontactno.IsMatch(empregs_contact.Text))
            {
                msg += "Contact contain only 10 digit numbers\n";
                f++;
            }
            if (!patrollno.IsMatch(empregs_expr.Text))
            {
                msg += "Experience years contain only numbers\n";
                f++;
            }
            if (f == 0)
                return true;
            else
            {
                MessageBox.Show(msg + "");
                return false;
            }
        }

        private void Supplier_Regs_Load(object sender, EventArgs e)
        {
            empregs_statecmb.SelectedItem = empregs_statecmb.SelectedIndex = 0;
            SqlCommand cmd1 = new SqlCommand("select ename from sup_regs", con);

            con.Open();
            SqlDataReader reader = cmd1.ExecuteReader();
            AutoCompleteStringCollection MyCollection = new AutoCompleteStringCollection();
            while (reader.Read())
            {
                MyCollection.Add(reader.GetString(0));


            }
            reader.Close();
            empregs_name.AutoCompleteSource = AutoCompleteSource.CustomSource;
            empregs_name.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            empregs_name.AutoCompleteCustomSource = MyCollection;
            //listBox1. pname_txt.AutoCompleteCustomSource = MyCollection;
            con.Close();

            loadfun();
             
        }

        public void loadfun()
        {
            object obj = new object();
            con.Open();

            cmd = new SqlCommand("select eid from sup_regs", con);
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                obj = (string)dr["eid"].ToString();
            }

            dr.Close();

            if (obj.ToString() == "")
            {
                empregs_id.Text = (Convert.ToInt32(1)).ToString();
            }
            else
            {
                empregs_id.Text = (Convert.ToInt32(obj) + 1).ToString();

            }
            con.Close();
        }
    }
}
