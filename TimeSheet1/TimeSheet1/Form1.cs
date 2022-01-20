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

                MySqlConnection con = new MySqlConnection("Server = localhost; Database = timekeeper; Uid = root; Pwd =Pacchuu2418@;");
                con.Open();

                Form2 f2 = new Form2();
                f2.ShowDialog();

            }

            private void button2_Click(object sender, EventArgs e)
            {
                MessageBox.Show("Timesheet is saved");
            }

            private void button4_Click(object sender, EventArgs e)
            {
                Close();
            }
                  
    }
        
    
}
