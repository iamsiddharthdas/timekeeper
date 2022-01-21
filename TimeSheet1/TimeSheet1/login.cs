using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Text.RegularExpressions;
namespace TimeSheet1
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        

        private void textBoxPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection("Server = localhost; Database = timekeeper;  Uid = root; Pwd =123456789;");
            if (textBoxUser.Text.Length == 0 || textBoxPassword.Text.Length == 0)
            {
                MessageBox.Show("Please enter email/Password","Empty Email/Password");
            }
            else if ((!Regex.IsMatch(textBoxUser.Text, @"^[a-zA-Z][\w\.-]*[a-zA-Z0-9]@[a-zA-Z0-9][\w\.-]*[a-zA-Z0-9]\.[a-zA-Z][a-zA-Z\.]*[a-zA-Z]$")) || (!Regex.IsMatch(textBoxPassword.Text, @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[^\da-zA-Z]).{8,15}$")))
            {
                MessageBox.Show("Password or email does not match specified requirements","Invalid Entry");

            }
            else
            {
                con.Open();
                string username = textBoxUser.Text;
                string password = textBoxPassword.Text;
                MySqlCommand cmd = new MySqlCommand("select * from login where email='" + textBoxUser.Text + "'and pass='" +textBoxPassword.Text + "'", con);
                cmd.CommandType = CommandType.Text;
                MySqlDataAdapter adapter = new MySqlDataAdapter();
                adapter.SelectCommand = cmd;
                DataSet dataSet = new DataSet();
                adapter.Fill(dataSet);
                con.Close();
                if (dataSet.Tables[0].Rows.Count > 0)
                {
                    this.Hide();
                    Form1 f1 = new Form1();
                    f1.ShowDialog();
                }
                else 
                {            
                    MessageBox.Show("Email entered is not registered,would you Like to Register?","User not found",MessageBoxButtons.OK);
                }

            }
        }

        private void registrationBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Registration registration = new Registration();
            registration.ShowDialog();
        }
    }

        
}
