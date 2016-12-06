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
            DialogResult = DialogResult.OK;
            Close();
        }

        private void editProfile_Click(object sender, EventArgs e)
        {
            using (ProfileWindow profile = new ProfileWindow(_username, _password, "Clinic"))
            {
                if (profile.ShowDialog() == DialogResult.OK)
                {
                    Close();
                    DialogResult = DialogResult.OK;
                }
            }
        }

        private void onceInformation_Click(object sender, EventArgs e)
        {
            ClinicOnceInformationWindow onceInfo = new ClinicOnceInformationWindow(_username);
            onceInfo.Show();
        }

        private void allInformation_Click(object sender, EventArgs e)
        {
            ClinicAllInformationWindow allInfo = new ClinicAllInformationWindow(_username);
            allInfo.Show();
        }

        private void insertNewVet_Click(object sender, EventArgs e)
        {
            ClinicNewVetWindow vet = new ClinicNewVetWindow(_username);
            vet.Show();
        }
    }
}
