using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VeterinarySystem
{
    public partial class LogInWindow : Form
    {
        private string _username;
        private string _password;
        public LogInWindow()
        {
            InitializeComponent();
        }

        private void LogInWindow_Load(object sender, EventArgs e)
        {
            name.Leave += GetUsername;
            pass.Leave += GetPassword;
        }

        private void GetUsername(object sender, EventArgs e)
        {
            _username = (sender as TextBox).Text;
        }
        private void GetPassword(object sender, EventArgs e)
        {
            _password = (sender as TextBox).Text;
        }

        private void loginbutton_Click(object sender, EventArgs e)
        {
            string str_connestion = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Dovile\Desktop\Veterinary\VeterinarySystem\VeterinarySystem\DatabaseVeterinary.mdf;Integrated Security=True";

            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = str_connestion;
            connection.Open();

            SqlCommand command = new SqlCommand("SELECT Name, SurName FROM Owner", connection);
            SqlCommand command1 = new SqlCommand("SELECT Name, SurName FROM Vet", connection);
            SqlCommand command2 = new SqlCommand("SELECT Name, City FROM Clinic", connection);

            SqlDataAdapter adapter = new SqlDataAdapter();
            SqlDataAdapter adapter1 = new SqlDataAdapter();
            SqlDataAdapter adapter2 = new SqlDataAdapter();

            adapter.SelectCommand = command;
            adapter1.SelectCommand = command1;
            adapter2.SelectCommand = command2;

            DataSet dataSet = new DataSet();
            adapter.Fill(dataSet, "Owner");
            adapter1.Fill(dataSet, "Vet");
            adapter2.Fill(dataSet, "Clinic");
            bool found = false;

            if(FindUser("Name", "SurName", dataSet.Tables["Owner"].Rows))
            {
                OwnerWindow owner = new OwnerWindow();
                owner.Show();
                Hide();
            }
            else if(FindUser("Name", "SurName", dataSet.Tables["Vet"].Rows))
            {
                VetWindow vet = new VetWindow();
                vet.Show();
                Hide();
            }
            else if(FindUser("Name", "City", dataSet.Tables["Clinic"].Rows))
            {
                ClinicWindow clinic = new ClinicWindow();
                clinic.Show();
                Hide();
            }
            else
            {
                MessageBox.Show("Maybe username or password is incorrect.", "Wrong connection", MessageBoxButtons.OK);
            }

            connection.Close();
            adapter.Dispose();
            adapter1.Dispose();
            adapter2.Dispose();
        }

        private bool FindUser(string column1, string column2, DataRowCollection table)
        {
            bool found = false;
            foreach (DataRow temp in table)
            {
                if (temp[column1].Equals(_username) && temp[column2].Equals(_password))
                    found = true;
            }
            return found;
        }

        private void signUpButton_Click(object sender, EventArgs e)
        {
            SignUpWindow signUp = new SignUpWindow();
            signUp.Show();
        }


    }
}
