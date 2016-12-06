using System;
using System.Windows.Forms;

namespace VeterinarySystem
{
    public partial class ClinicWindow : Form
    {
        private string _username;
        private string _password;
        public ClinicWindow(string name, string pass)
        {
            InitializeComponent();
            _username = name;
            _password = pass;
        }

        private void logout_Click(object sender, EventArgs e)
        {
            LogInWindow login = new LogInWindow();
            login.Show();
            Close();
        }

        private void editProfile_Click(object sender, EventArgs e)
        {
            ProfileWindow profile = new ProfileWindow(_username, _password, "Clinic");
            profile.Show();
        }

        private void onceInformation_Click(object sender, EventArgs e)
        {
            ClinicOnceInformationWindow onceInfo = new ClinicOnceInformationWindow();
            onceInfo.Show();
        }

        private void allInformation_Click(object sender, EventArgs e)
        {
            ClinicAllInformationWindow allInfo = new ClinicAllInformationWindow();
            allInfo.Show();
        }

        private void insertNewVet_Click(object sender, EventArgs e)
        {
            ClinicNewVetWindow vet = new ClinicNewVetWindow();
            vet.Show();
        }
    }
}
