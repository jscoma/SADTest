﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using DiabeticHealthDB;
namespace Test
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        public static void hubThreadStart()
        {
            Hub main = new Hub();
            main.ShowDialog();
        }

        private void bLogin_Click(object sender, EventArgs e)
        {
            //int loginParameter = LoginFunction.LoginCheck(tbUsername.Text, tbPassword.Text);

            //if (loginParameter == 1)
            //{
            //    ThreadStart hubRef = new ThreadStart(hubThreadStart);
            //    Thread hubThread = new Thread(hubRef);
            //    hubThread.Start();
            //    this.Close();
            //}
            //else if (loginParameter == 2)
            //    MessageBox.Show("Incorrect Username or Password");
            //else if (loginParameter == 3)
            //    MessageBox.Show("Incorrect Username");
            //else if (loginParameter == 4)
            //    MessageBox.Show("Error Logging In");

            //Connects to the Database
            
            MySqlConnection connection = DatabaseConnection.GetConnection();

            string checkUsername = "Select count(*) FROM Login WHERE LoginID ='" + tbUsername.Text + "'";

             try
             {
                 connection.Open();
                 MySqlCommand cmd = new MySqlCommand(checkUsername, connection);
                 int temp = Convert.ToInt32(cmd.ExecuteScalar().ToString());

                 if (temp == 1)
                 {
                     string checkPassword = "select Password from Login where LoginID='" + tbUsername.Text + "'";
                     MySqlCommand passwordCmd = new MySqlCommand(checkPassword, connection);
                     string password = passwordCmd.ExecuteScalar().ToString().Replace(" ", "");
                     if(password == tbPassword.Text)
                     {
                         ThreadStart hubRef = new ThreadStart(hubThreadStart);
                         Thread hubThread = new Thread(hubRef);
                         hubThread.Start();
                         this.Close();
                     }
                     else
                     {
                         MessageBox.Show("Username or Password Incorrect");
                     }
                 }
                 else
                 {
                     MessageBox.Show("Username or Password Incorrect");
                 }
                 connection.Close();
             }
             catch(Exception ex)
             {
                 MessageBox.Show("ERROR: " + ex.Message.ToString());
             }
             
        }
        
                  private void button1_Click(object sender, EventArgs e)
        {
        

        }
        

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void bExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void tbUsername_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
