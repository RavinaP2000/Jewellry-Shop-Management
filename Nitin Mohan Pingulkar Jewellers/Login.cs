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
    public partial class Login : Form
    {
        SqlConnection con = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["db"].ConnectionString);
        SqlCommand cmd;
        SqlDataReader dr;
        string s, q;
        int temp;
        int attempt = 1;
        ProgressBar pb;
        public string username, password;
        DateTime dt;
        string logintime, logouttime;
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            loginfgt_btn.Visible = false;

            pb = new ProgressBar();
            pb.MarqueeAnimationSpeed = 1;
            pb.Name = "Loding";
           
        }

        private void loinuser_btn_Click(object sender, EventArgs e)
        {
            con.Open();
            username = loginuser_name.Text;
            password = loginuser_pass.Text;
            if (username == "")
            {
                MessageBox.Show("Please enter username...");
            }

            else if (password == "")
            {
                MessageBox.Show("Please enter password...");

            }

            else
            {
                try
                {

                    cmd = new SqlCommand("select * from login where username='" + username + "'", con);

                    dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        s = (string)dr["username"];
                        q = (string)dr["password"];
                    }

                    dr.Close();

                    if (s.Equals(username) && q != password)
                    {
                        if (attempt < 3)
                        {
                            MessageBox.Show("Please enter correct password..");
                            loginuser_pass.Clear();
                            loginuser_pass.Focus();
                            attempt = attempt + 1;
                        }
                        else
                        {
                            MessageBox.Show("Please change your password..");
                            loginfgt_btn.Visible = true;
                            loinuser_btn.Enabled = false;

                        }

                    }

                    else if (s.Equals(username) && q.Equals(password))
                    {

                        MessageBox.Show("Login Successful..");
                        temp = 1;
                        dt = DateTime.Now;
                        logintime = dt.ToString();
                        cmd = new SqlCommand("insert into logtable values('" + username + "','" + password + "','" + logintime + "','" + logouttime + "')", con);
                        cmd.ExecuteNonQuery();
                        this.Hide();
                        Home hm = new Home(logintime, username);
                        hm.Show();


                    }
                    else if (s != username && q != password)
                    {
                        MessageBox.Show("Sorry..You have not registered member..");
                        loginuser_name.Clear();
                        loginuser_pass.Clear();
                        //loinuser_btn.Enabled = false;
                        loginfgt_btn.Visible = true;

                    }

                    else if (s.Equals(username) && q != password)
                    {
                        if (attempt < 3)
                        {
                            MessageBox.Show("Please enter correct password..");
                            loginuser_pass.Text = "";
                            attempt = attempt + 1;
                        }
                        else
                        {
                            MessageBox.Show("Sorry Login fails...", "Information");
                            MessageBox.Show("Please verify your password from admin...");
                            this.Close();

                        }
                    }

                    else if (q.Equals(password) && s != (username))
                    {
                        if (attempt < 3)
                        {
                            MessageBox.Show("Please enter correct username..");
                            loginuser_name.Text = "";
                            attempt = attempt + 1;
                        }
                        else
                        {
                            MessageBox.Show("Sorry Login fails...", "Information");
                            MessageBox.Show("Please verify your username from admin...");
                            this.Close();

                        }
                    }

                    else
                    {

                        MessageBox.Show("Sorry..You have not registered member..");
                        loginuser_name.Clear();
                        loginuser_pass.Clear();
                        //loinuser_btn.Enabled = false;
                        loginfgt_btn.Visible = true;

                    }

                    con.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Sorry..You have not registered member.." + ex);
                    loginuser_name.Clear();
                    loginuser_pass.Clear();
                    loinuser_btn.Enabled = false;
                    loginfgt_btn.Visible = true;
                }

            }
        }

        private void loginext_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void loginfgt_btn_Click(object sender, EventArgs e)
        {
            Forget_Passwd fs = new Forget_Passwd();
            fs.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
