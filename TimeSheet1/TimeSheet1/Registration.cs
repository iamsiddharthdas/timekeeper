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
            if(textBoxName.Text.Length==0 || textBoxEmail.Text.Length==0 || textBoxPassword.Text.Length==0 || textBoxCnfPassword.Text.Length==0 || textBoxEmpId.Text.Length==0 || textBoxContact.Text.Length == 0)
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

                MySqlCommand cmd = new MySqlCommand("Insert into login (email,pass,name,empid,contact) values('"+textBoxEmail.Text + "','" + textBoxPassword.Text + "','" + textBoxName.Text + "','" + textBoxEmpId.Text + "','" + textBoxContact.Text+"')", con);
                cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("User Registered","success");
                this.Hide();
                Form1 f1 = new Form1();
                f1.ShowDialog();

            }
        }

        private void Registration_Load(object sender, EventArgs e)
        {

        }
    }
}
