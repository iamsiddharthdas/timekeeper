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
        public static string name = "";
        public static string empid = "";
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
            else if ((!Regex.IsMatch(textBoxUser.Text, @"^[a-zA-Z][\w\.-]*[a-zA-Z0-9]@[a-zA-Z0-9][\w\.-]*[a-zA-Z0-9]\.[a-zA-Z][a-zA-Z\.]*[a-zA-Z]$")))
            {
                MessageBox.Show("Password or email does not match specified requirements","Invalid Entry");

            }
            else
            {
                con.Open();
                string pass = "";
                MySqlCommand cmd = new MySqlCommand("select email from employees where email='" + textBoxUser.Text + "'", con);
                string pread = textBoxPassword.Text.ToString();
                  
                    cmd.CommandType = CommandType.Text;
                    MySqlDataAdapter adapter = new MySqlDataAdapter();
                    adapter.SelectCommand = cmd;
                    DataSet dataSet = new DataSet();
                    adapter.Fill(dataSet);
                    if (dataSet.Tables[0].Rows.Count > 0)
                    {
                        MySqlCommand find = new MySqlCommand("select empid,name,pass from employees where email='" + textBoxUser.Text + "'", con);
                        MySqlDataReader reader = find.ExecuteReader();
                        while (reader.Read())
                        {
                            name = reader[1].ToString();
                            empid = reader[0].ToString();
                            pass = reader[2].ToString();
                        }
                        con.Close();
                    if (pass == textBoxPassword.Text)
                    {
                        this.Hide();
                        Form1 f1 = new Form1();
                        f1.ShowDialog();

                    }
                    else
                    {
                        MessageBox.Show("Wrong Password");
                    }
                        
                    }
                else
                {
                    MessageBox.Show("User Not Found,Please Register", "Invalid User");
                }

            }
        }

        private void registrationBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Registration registration = new Registration();
            registration.ShowDialog();
        }

        private void login_Load(object sender, EventArgs e)
        {

        }
    }

        
}
