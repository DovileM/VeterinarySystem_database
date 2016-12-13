using System;
using System.Data;
using System.Data.SqlClient;
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
            name.Text = null;
            pass.Text = null;
            pass.PasswordChar = '*';
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

            if(FindUser("Name", "SurName", dataSet.Tables["Owner"].Rows))
            {
                using(OwnerWindow owner = new OwnerWindow(_username,_password))
                {
                    Hide();
                    if (owner.ShowDialog() == DialogResult.OK)
                    {
                        Show();
                        name.Text = null;
                        pass.Text = null;
                    }

                }
                

            }
            else if(FindUser("Name", "SurName", dataSet.Tables["Vet"].Rows))
            {
                using (VetWindow vet = new VetWindow(_username, _password))
                {
                    Hide();
                    if (vet.ShowDialog() == DialogResult.OK)
                    {
                        Show();
                        name.Text = null;
                        pass.Text = null;
                    }
                }
            }
            else if(FindUser("Name", "City", dataSet.Tables["Clinic"].Rows))
            {
                using (ClinicWindow clinic = new ClinicWindow(_username, _password))
                {
                    Hide();
                    if (clinic.ShowDialog() == DialogResult.OK)
                    {
                        Show();
                        name.Text = null;
                        pass.Text = null;
                    }
                }

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
