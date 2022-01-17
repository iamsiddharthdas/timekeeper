using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Data;
using System.Configuration;
using System.Data.SqlClient;
using System.Text.RegularExpressions;

namespace TimeKeeper
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader reader;
        static String connectionString = @"Data Source=localhost;Initial Catalog=L505057;User ID=EMEA\aayush.saxena;Password=Welcome123#;";

        public MainWindow()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                con = new SqlConnection(connectionString);
                if (con.Open())
                {
                    if (textBoxEmail.Text.Length == 0)
                    {
                        errormessage.Text = "Enter an email.";
                        textBoxEmail.Focus();
                    }
                    else if (!Regex.IsMatch(textBoxEmail.Text, @"^[a-zA-Z][\w\.-]*[a-zA-Z0-9]@[a-zA-Z0-9][\w\.-]*[a-zA-Z0-9]\.[a-zA-Z][a-zA-Z\.]*[a-zA-Z]$"))
                    {
                        errormessage.Text = "Enter a valid email.";
                        textBoxEmail.Select(0, textBoxEmail.Text.Length);
                        textBoxEmail.Focus();
                    }
                    else
                    {
                        string email = textBoxEmail.Text;
                        string password = passwordBox1.Password;
                        SqlCommand cmd = new SqlCommand("Select * from login where email='" + email + "'  and password='" + password + "'", con);
                        cmd.CommandType = CommandType.Text;
                        SqlDataAdapter adapter = new SqlDataAdapter();
                        adapter.SelectCommand = cmd;
                        DataSet dataSet = new DataSet();
                        adapter.Fill(dataSet);
                        if (dataSet.Tables[0].Rows.Count > 0)
                        {
                            errormessage.Text = "Logged in";
                            Close();
                        }
                        else
                        {
                            errormessage.Text = "Sorry! Please enter existing emailid/password.";
                        }
                        con.Close();
                    }
                }
            }
            }




    }
    }
}
