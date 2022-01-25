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
    public partial class Registration : Form
    {
        public Registration()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string password = textBoxPassword.Text;
            string conpass = textBoxCnfPassword.Text;

            if(textBoxName.Text.Length==0 || textBoxEmail.Text.Length==0 || textBoxPassword.Text.Length==0 || textBoxCnfPassword.Text.Length==0 || empId.Text.Length==0 || textBoxContact.Text.Length == 0 )
            {
                MessageBox.Show("Please fill all entries", "Mandatory field Empty");
            }
            else if (password != conpass)
            {
                MessageBox.Show("Passwords dont match", "Password's Mismatch ");
            }
            
            else
            {
                if((!Regex.IsMatch(textBoxPassword.Text, @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[^\da-zA-Z]).{8,20}$")))
                {
                    MessageBox.Show("Password should contain atleast 1 lower case,1 upper case,1 number and 1 special character", "Password requirements not matching");
                }
                else
                {
                    MySqlConnection con = new MySqlConnection("Server = localhost; Database = timekeeper; Uid = root; Pwd = 123456789;");
                    con.Open();
                    MySqlCommand find = new MySqlCommand("select email from employees where email='" + textBoxEmail.Text + "'",con);
                    find.CommandType = CommandType.Text;
                    MySqlDataAdapter adapter = new MySqlDataAdapter();
                    adapter.SelectCommand = find;
                    DataSet dataSet = new DataSet();
                    adapter.Fill(dataSet);
                    if (dataSet.Tables[0].Rows.Count > 0)
                    {
                        MessageBox.Show("Already a user,Please login using existing credentials", "User Exists");
                        con.Close();
                        this.Hide();
                        login login = new login();
                        login.ShowDialog();
                        
                    }
                    else
                    {
                        var doj = DateTime.Now.ToString("yyyy/MM/dd");
                        MySqlCommand cmd = new MySqlCommand("Insert into employees (email,pass,name,empid,contact,dob,doj,role) values('" + textBoxEmail.Text + "','" + textBoxPassword.Text + "','" + textBoxName.Text + "','" + empId.Text + "','" + textBoxContact.Text + "'," + dateOfBirth.Text+","+ doj + ",'emp'"+")", con);
                        MySqlDataReader MyReader=cmd.ExecuteReader();
                        con.Close();
                        MessageBox.Show("User Registered", "success");
                        this.Hide();
                        Form1 f1 = new Form1();
                        f1.ShowDialog();
                    }
                    
                }
                

            }
        }

        private void Registration_Load(object sender, EventArgs e)
        {

        }

        private void textBoxContact_TextChanged(object sender, EventArgs e)
        {

        }

        private void generateEmpId_Click(object sender, EventArgs e)
        {
            string password = textBoxPassword.Text;
            string conpass = textBoxCnfPassword.Text;
            if (textBoxName.Text.Length == 0 /*|| textBoxEmail.Text.Length == 0 || textBoxPassword.Text.Length == 0 || textBoxCnfPassword.Text.Length == 0*/)
            {
                MessageBox.Show("Please fill all entries", "Mandatory field Empty");
            }
            else if (password != conpass)
            {
                MessageBox.Show("Passwords dont match", "Password's Mismatch ");
            }
            else
            {
                generateEmpId.Enabled = false;
                string name = textBoxName.Text;
                string empid = name.Substring(0, 2);
                var date = DateTime.Now.ToString("dd")+DateTime.Now.ToString("MM")+DateTime.Now.ToString("yy")+DateTime.Now.ToString("HH")+DateTime.Now.ToString("mm");
                empid = empid + date;
                empId.Text = empid;
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
