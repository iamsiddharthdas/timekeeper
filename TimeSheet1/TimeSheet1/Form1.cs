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


        private void Form1_Load(object sender, EventArgs e)
        {
            empName.Text = login.name;
            emp_id.Text = login.empid;
            MySqlConnection con = new MySqlConnection("Server = localhost; Database = timekeeper;  Uid = root; Pwd =123456789;");
            con.Open();
            MySqlCommand cmd = new MySqlCommand("select project_id,project_name from project where empid='" + emp_id.Text + "'", con);
            MySqlDataReader reader = cmd.ExecuteReader();
            //MySqlDataAdapter adapter = new MySqlDataAdapter();
            //adapter.SelectCommand = cmd;
            //DataTable dt = new DataTable();
            //adapter.Fill(dt);
            //int index = 0;
            //foreach(DataRow row in dt.Rows)
            //{
            //    timeSheet.Rows[index].Cells[0].Value = row["project_id"];
            //    timeSheet.Rows[index].Cells[1].Value = row["project_name"];
            //    index++;
            //}
            while (reader.Read())
            {
                  timeSheet.Rows[0].Cells[0].Value = reader[0].ToString();
                  timeSheet.Rows[0].Cells[1].Value = reader[1].ToString();
                  reader.NextResult();
            }


            day1.HeaderText = dtpStartDate.Value.AddDays(0).DayOfWeek.ToString();
            day2.HeaderText = dtpStartDate.Value.AddDays(1).DayOfWeek.ToString();
            day3.HeaderText = dtpStartDate.Value.AddDays(2).DayOfWeek.ToString();
            day4.HeaderText = dtpStartDate.Value.AddDays(3).DayOfWeek.ToString();
            day5.HeaderText = dtpStartDate.Value.AddDays(4).DayOfWeek.ToString();
            day6.HeaderText = dtpStartDate.Value.AddDays(5).DayOfWeek.ToString();
            day7.HeaderText = dtpStartDate.Value.AddDays(6).DayOfWeek.ToString();

           
        }

        private void dtpStartDate_ValueChanged(object sender, EventArgs e)
        {


                l1.Text = dtpStartDate.Value.AddDays(0).ToString("M");
                l2.Text = dtpStartDate.Value.AddDays(1).ToString("M");
                l3.Text = dtpStartDate.Value.AddDays(2).ToString("M");
                l4.Text = dtpStartDate.Value.AddDays(3).ToString("M");
                l5.Text = dtpStartDate.Value.AddDays(4).ToString("M");
                l6.Text = dtpStartDate.Value.AddDays(5).ToString("M");
                l7.Text = dtpStartDate.Value.AddDays(6).ToString("M");

                day1.HeaderText = dtpStartDate.Value.AddDays(0).DayOfWeek.ToString();
                day2.HeaderText = dtpStartDate.Value.AddDays(1).DayOfWeek.ToString();
                day3.HeaderText = dtpStartDate.Value.AddDays(2).DayOfWeek.ToString();
                day4.HeaderText = dtpStartDate.Value.AddDays(3).DayOfWeek.ToString();
                day5.HeaderText = dtpStartDate.Value.AddDays(4).DayOfWeek.ToString();
                day6.HeaderText = dtpStartDate.Value.AddDays(5).DayOfWeek.ToString();
                day7.HeaderText = dtpStartDate.Value.AddDays(6).DayOfWeek.ToString();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           

        }


        //private void button1_Click(object sender, EventArgs e)
        //{

        //    MySqlConnection con = new MySqlConnection("Server = localhost; Database = timekeeper; Uid = root; Pwd =admin;");
        //    //con.Open();

        //    Form2 f2 = new Form2();
        //    f2.ShowDialog();
        //    //con.Close();

        //}

        private void button2_Click(object sender, EventArgs e)
        {

            MySqlConnection con = new MySqlConnection("Server = localhost; Database = timekeeper; Uid = root; Pwd =123456789;");
            //con.Open();
            MySqlCommand cmd = new MySqlCommand("");


        }

              

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void l1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void timeSheet_DefaultValuesNeeded(object sender, DataGridViewRowEventArgs e)
        {

        }
    }
        
    
}
