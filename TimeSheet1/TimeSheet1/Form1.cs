using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TimeSheet1
{
    
        public partial class Form1 : Form
        {
            

            public Form1()
            {
                InitializeComponent();
            }

            private void button2_Click(object sender, EventArgs e)
            {
                MessageBox.Show("Timesheet is saved");
            }

            private void button4_Click(object sender, EventArgs e)
            {
                Close();
            }

            private void button1_Click(object sender, EventArgs e)
            {
            Form2 f2 = new Form2();
            f2.ShowDialog();

            }
                       

        
            private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
            {
            
            }
        }
        
    
}
