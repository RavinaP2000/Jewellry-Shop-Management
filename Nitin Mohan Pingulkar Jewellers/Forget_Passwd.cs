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
    public partial class Forget_Passwd : Form
    {
        SqlConnection con = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["db"].ConnectionString);
        SqlCommand cmd;
        SqlDataReader dr;
        string username, password, confirm;
        string s, q;
        public Forget_Passwd()
        {
            InitializeComponent();
        }

        private void Forget_Passwd_Load(object sender, EventArgs e)
        {

        }

        private void newuser_sign_btn_Click(object sender, EventArgs e)
        {
            con.Open();

            username = newuser_name.Text;
            password = newuser_pass.Text;
            confirm = newuser_confirm.Text;

            newuser_name.Focus();
            if (username == "")
            {
                MessageBox.Show("Please enter username...");
            }

            else if (password == "")
            {
                MessageBox.Show("Please enter password...");
            }
            else if (confirm == "")
            {
                MessageBox.Show("Please enter confirm password...");
            }

            else
            {

                try
                {
                    cmd = new SqlCommand("select * from login where username='" + username + "' and password='" + password + "'", con);
                    dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        s = (string)dr["username"];
                        q = (string)dr["password"];

                    }

                    dr.Close();

                    if (password.Equals(confirm) && s != username)
                    {
                        cmd = new SqlCommand("insert into login values ('" + username + "','" + password + "')", con);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("New user created successfully..");
                        this.Close();

                    }
                    else if (s.Equals(username))
                    {
                        MessageBox.Show("User already registered..");
                        newuser_name.Text = "";
                        newuser_pass.Text = "";
                        newuser_confirm.Text = "";

                    }


                    else
                    {
                        MessageBox.Show("Please confirm your password ..");
                        newuser_confirm.Text = "";
                        newuser_confirm.Focus();


                    }



                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex + "exception found");
                }

            }
            con.Close();

        }


        public void newuser_chng_btn_Click(object sender, EventArgs e)
        {
            con.Open();

            username = newuser_name.Text;
            password = newuser_pass.Text;
            confirm = newuser_confirm.Text;

            newuser_name.Focus();
            if (username == "")
            {
                MessageBox.Show("Please enter username...");
            }

            else if (password == "")
            {
                MessageBox.Show("Please enter password...");
            }
            else if (confirm == "")
            {
                MessageBox.Show("Please enter confirm password...");
            }

            else
            {

                try
                {
                    cmd = new SqlCommand("select * from login where username='" + username + "' ", con);
                    dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        s = (string)dr["username"];
                        q = (string)dr["password"];

                    }

                    dr.Close();

                    if (password.Equals(confirm) && s.Equals(username))
                    {
                        cmd = new SqlCommand("update login set password='" + password + "' where username='" + s + "'", con);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Password updated successfully..");
                        this.Close();
                    }
                    else if (s != username)
                    {
                        MessageBox.Show("Such user does not exits..");
                        newuser_name.Text = "";
                        newuser_pass.Text = "";
                        newuser_confirm.Text = "";
                    }


                    else
                    {
                        MessageBox.Show("Please confirm your password ..");
                        newuser_confirm.Text = "";
                        newuser_confirm.Focus();


                    }



                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex + "exception found");
                }

            }
            con.Close();
      
        }

        private void newuser_chng_btn_Click_1(object sender, EventArgs e)
        {
            con.Open();

            username = newuser_name.Text;
            password = newuser_pass.Text;
            confirm = newuser_confirm.Text;

            newuser_name.Focus();
            if (username == "")
            {
                MessageBox.Show("Please enter username...");
            }

            else if (password == "")
            {
                MessageBox.Show("Please enter password...");
            }
            else if (confirm == "")
            {
                MessageBox.Show("Please enter confirm password...");
            }

            else
            {

                try
                {
                    cmd = new SqlCommand("select * from login where username='" + username + "' ", con);
                    dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        s = (string)dr["username"];
                        q = (string)dr["password"];

                    }

                    dr.Close();

                    if (password.Equals(confirm) && s.Equals(username))
                    {
                        cmd = new SqlCommand("update login set password='" + password + "' where username='" + s + "'", con);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Password updated successfully..");
                        this.Close();
                    }
                    else if (s != username)
                    {
                        MessageBox.Show("Such user does not exits..");
                        newuser_name.Text = "";
                        newuser_pass.Text = "";
                        newuser_confirm.Text = "";
                    }


                    else
                    {
                        MessageBox.Show("Please confirm your password ..");
                        newuser_confirm.Text = "";
                        newuser_confirm.Focus();


                    }



                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex + "exception found");
                }

            }
            con.Close();
      
        }

        private void newuser_exit_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
