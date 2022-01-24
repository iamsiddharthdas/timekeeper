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
                MySqlConnection con = new MySqlConnection("Server = localhost; Database = timekeeper; Uid = root; Pwd = 123456789;");
                con.Open();
                var doj = DateTime.Now.ToString("dd/MM/yyyy");

                MySqlCommand cmd = new MySqlCommand("Insert into employees (email,pass,name,empid,contact,dob,doj) values('" + textBoxEmail.Text + "','" + textBoxPassword.Text + "','" + textBoxName.Text + "','" + empId.Text + "','" + textBoxContact.Text + "','"+dateOfBirth.Value + doj + "')", con);
                cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("User Registered", "success");
                this.Hide();
                Form1 f1 = new Form1();
                f1.ShowDialog();

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
