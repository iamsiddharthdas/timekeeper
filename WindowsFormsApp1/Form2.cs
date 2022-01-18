using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApp1
{
    public partial class Form2 : Form
    {
        bool ValidTimeSheet;
		bool bNewRecord;
		string strTimeSheetCode;
        public Form2()
        {
            InitializeComponent();
        }

        private void lblEmployeeNumber_Click(object sender, EventArgs e)
        {

        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void txtEmployeeNumber_TextChanged(object sender, EventArgs e)
        {
            if (this.txtEmployeeNumber.Text == "")
            {
                ValidTimeSheet = false;
                return;
            }

            string strSelect =
             string.Concat("SELECT * FROM Employees WHERE EmployeeID = '",
                             this.txtEmployeeNumber.Text, "';");

            SqlConnection conDatabase = new SqlConnection("Server = localhost; Database = timekeeper; Uid = root; Pwd =admin;" +
                         "Integrated Security=true");
            SqlCommand cmdDatabase = new SqlCommand(strSelect, conDatabase);


            dtpStartDate.Value = DateTime.Today;

            txtWeek1Monday.Text = "0.00";
            txtWeek1Tuesday.Text = "0.00";
            txtWeek1Wednesday.Text = "0.00";
            txtWeek1Thursday.Text = "0.00";
            txtWeek1Friday.Text = "0.00";
            txtWeek1Saturday.Text = "0.00";
            txtWeek1Sunday.Text = "0.00";

            txtWeek2Monday.Text = "0.00";
            txtWeek2Tuesday.Text = "0.00";
            txtWeek2Wednesday.Text = "0.00";
            txtWeek2Thursday.Text = "0.00";
            txtWeek2Friday.Text = "0.00";
            txtWeek2Saturday.Text = "0.00";
            txtWeek2Sunday.Text = "0.00";

            conDatabase.Close();
        }

        private void dtpStartDate_ValueChanged(object sender, EventArgs e)
        {
            lblEndDate.Text = dtpStartDate.Value.AddDays(7).ToString();

            if (txtEmployeeNumber.Text.Equals(""))
            {
                ValidTimeSheet = false;
                return;
            }

            string strMonth;
            string strDay;
            int iMonth;
            int iDay;
            DateTime dteStart;

            dteStart = dtpStartDate.Value;
            iMonth = dteStart.Month;
            iDay = dteStart.Day;

            if (iMonth < 10)
                strMonth = dteStart.Year + "0" + iMonth.ToString();
            else
                strMonth = dteStart.Year + iMonth.ToString();

            if (iDay < 10)
                strDay = strMonth + "0" + iDay.ToString();
            else
                strDay = strMonth + iDay.ToString();

            strTimeSheetCode = txtEmployeeNumber.Text + strDay;
            SqlConnection conTimeSheet = null;
            string strSQL =
            String.Concat("SELECT * FROM timeSheets WHERE TimeSheetCode = '",
                     strTimeSheetCode, "';");

            conTimeSheet =
                 new SqlConnection("Server = localhost; Database = timekeeper; Uid = root; Pwd =admin;" +
                         "Integrated Security=true");
            SqlCommand cmdTimeSheet = new SqlCommand(strSQL, conTimeSheet);

            

            conTimeSheet.Close();

            
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            //string strTimeSheet = "";


            //if (bNewRecord == true)
            //{
            //    strTimeSheet = String.Concat("INSERT INTO `timekeeper`.`timesheets`(StartDate, TimeSheetCode, Week1Monday, Week1Tuesday, ",
            //                "Week1Wednesday, Week1Thursday, Week1Friday, Week1Saturday, Week1Sunday, Notes) ",
            //                "VALUES('", dtpStartDate.Value.ToString("MM/dd/yyyy"), "', '", strTimeSheetCode, "','", txtWeek1Monday.Text, "', '",
            //                txtWeek1Tuesday.Text, "', '", txtWeek1Wednesday.Text, "', '", txtWeek1Thursday.Text, "', '",
            //                txtWeek1Friday.Text, "', '", txtWeek1Saturday.Text, "', '",
            //                txtWeek1Sunday.Text, "', '", txtWeek2Monday.Text, "', '", txtWeek2Tuesday.Text, "', '",
            //                txtWeek2Wednesday.Text, "', '", txtWeek2Thursday.Text, "', '", txtWeek2Friday.Text, "', '",
            //                txtWeek2Saturday.Text, "', '", txtWeek2Sunday.Text, "', '", txtNotes.Text, "');");
            //}

            //if (bNewRecord == false)
            //{
            //    strTimeSheet = String.Concat("UPDATE timesheets SET Week1Monday = '", txtWeek1Monday.Text,
            //                "', Week1Tuesday = '", txtWeek1Tuesday.Text, "', Week1Wednesday = '", txtWeek1Wednesday.Text,
            //                "', Week1Thursday = '", txtWeek1Thursday.Text, "', Week1Friday = '", txtWeek1Friday.Text,
            //                "', Week1Saturday = '", txtWeek1Saturday.Text, "', Week1Sunday = '", txtWeek1Sunday.Text,
            //                "', Week2Monday = '", txtWeek2Monday.Text, "', Week2Tuesday = '", txtWeek2Tuesday.Text,
            //                "', Week2Wednesday = '", txtWeek2Wednesday.Text, "', Week2Thursday = '", txtWeek2Thursday.Text,
            //                "', Week2Friday = '", txtWeek2Friday.Text, "', Week2Saturday = '", txtWeek2Saturday.Text,
            //                "', Week2Sunday = '", txtWeek2Sunday.Text, "', Notes = '", txtNotes.Text,
            //                "' WHERE TimeSheetCode = '", strTimeSheetCode, "';");
            //}

            //if (this.ValidTimeSheet == true)
            //{
            //    SqlConnection conTimeSheet =
            //                new SqlConnection("Server = localhost; Database = timekeeper; Uid = root; Pwd =admin;" +
            //                "Integrated Security=true");
            //    SqlCommand cmdTimeSheet = new SqlCommand(strTimeSheet, conTimeSheet);

            //    conTimeSheet.Open();
            //    cmdTimeSheet.ExecuteNonQuery();
            //    conTimeSheet.Close();

            //    MessageBox.Show("Your time sheet has been submitted");
            //}
            //else
            //{
            //    MessageBox.Show("The time sheet is not valid\n" +
            //                     "either you didn't enter a valid employee number, " +
            //             "or you didn't a valid start date\n" +
            //             "The time sheet will not be saved");
            //}

            MessageBox.Show("Successfully updated the timesheet");
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
