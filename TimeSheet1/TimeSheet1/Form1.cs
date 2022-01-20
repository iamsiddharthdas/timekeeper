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
    

    public partial class Form1 : Form
        {

        
        public Form1()
            {
                InitializeComponent();
            }

            private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
            {

            }


            private void button1_Click(object sender, EventArgs e)
            {

                MySqlConnection con = new MySqlConnection("Server = localhost; Database = timekeeper; Uid = root; Pwd =admin;");
                con.Open();

                Form2 f2 = new Form2();
                f2.ShowDialog();
                con.Close();

            }

            private void button2_Click(object sender, EventArgs e)
            {

            MySqlConnection con = new MySqlConnection("Server = localhost; Database = timekeeper; Uid = root; Pwd =admin;");
            con.Open();
            MySqlCommand cmd = new MySqlCommand("UPDATE project` SET `day1` = '8', `day2` = '9', `day3` = '9' WHERE(`project_id` = pid);");


            
        }

            private void button4_Click(object sender, EventArgs e)
            {
                Close();
            }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        
    }
        
    
}
