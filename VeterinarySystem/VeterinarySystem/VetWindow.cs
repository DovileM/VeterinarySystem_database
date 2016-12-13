using System;
using System.Windows.Forms;
using System.Linq;
using System.Diagnostics;

namespace VeterinarySystem
{
    public partial class VetWindow : Form
    {
        private string _username;
        private string _password;
        private string _pCode;
        public VetWindow(string user, string pass)
        {
            InitializeComponent();
            _username = user;
            _password = pass;
        }

        private void Vet_Load(object sender, EventArgs e)
        {
            using (VeterinaryEntities dataBase = new VeterinaryEntities())
            {
                var vets = from v in dataBase.Vets
                            where v.Name == _username && v.SurName == _password
                            select new { PCode = v.PCode};
                foreach (var vet in vets)
                {
                    _pCode = vet.PCode;
                }
                Trace.WriteLine(_username+"  "+_password+"  "+_pCode);
            }
        }

        private void editProfile_Click(object sender, EventArgs e)
        {
            ProfileWindow profile = new ProfileWindow(_username, _password ,"Vet");
            profile.Show();
        }

        private void logout_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }

        private void patientsInfo_Click(object sender, EventArgs e)
        {
            OwnerSeeInformationWindow patientsInfo = new OwnerSeeInformationWindow("Vet patients", _pCode);
            patientsInfo.Show();
        }

        private void ownerInfo_Click(object sender, EventArgs e)
        {
            OnceInformationWindow owner = new OnceInformationWindow("Vet",_pCode);
            owner.Show();
        }

        private void newPatient_Click(object sender, EventArgs e)
        {
            using (VeterinaryEntities dataBase = new VeterinaryEntities())
            {
                int pets = dataBase.Treatments.Where(t => t.Vet.Equals(_pCode) && t.End == null).Count();
                if (pets == 0)
                    MessageBox.Show("Sad, but no new patients!", "Error", MessageBoxButtons.OK);
                else
                {
                    OwnerNewPetWindow pet = new OwnerNewPetWindow(_pCode,"Vet");
                    pet.Show();
                }
            }
        }

        private void editPatient_Click(object sender, EventArgs e)
        {
            using (VeterinaryEntities dataBase = new VeterinaryEntities())
            {
                int pets = dataBase.Treatments.Where(t => t.Vet.Equals(_pCode)).Count();
                if (pets == 0)
                    MessageBox.Show("Sad, but you do not have any treatments!", "Error", MessageBoxButtons.OK);
                else
                {
                    OwnerNewPetWindow pet = new OwnerNewPetWindow(_pCode, "VetEdit");
                    pet.Show();
                }
            }
        }
    }
}
