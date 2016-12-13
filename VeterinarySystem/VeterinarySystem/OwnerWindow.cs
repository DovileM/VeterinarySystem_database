using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace VeterinarySystem
{
    public partial class OwnerWindow : Form
    {
        private string _username;
        private string _password;
        private string _pCode;
        public OwnerWindow(string user, string pass)
        {
            InitializeComponent();
            _username = user;
            _password = pass;
            using (VeterinaryEntities dataBase = new VeterinaryEntities())
            {
                var owners = dataBase.Owners.Where(o => o.Name.Equals(_username) && o.SurName.Equals(_password)).
                        Select(o => new {pCode = o.PCode});
                foreach (var owner in owners)
                    _pCode = owner.pCode;
            }
        }

        private void editProfile_Click(object sender, EventArgs e)
        {
            ProfileWindow profile = new ProfileWindow(_username, _password,"Owner");
            profile.Show();
        }

        private void logout_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }

        private void seeClinicInfo_Click(object sender, EventArgs e)
        {
            OwnerSeeInformationWindow clinic = new OwnerSeeInformationWindow("Clinic", _pCode);
            clinic.Show();
        }

        private void seePetInfo_Click(object sender, EventArgs e)
        {
            OwnerSeeInformationWindow pet = new OwnerSeeInformationWindow("Pet", _pCode);
            pet.Show();
        }

        private void insertNewPet_Click(object sender, EventArgs e)
        {
            OwnerNewPetWindow newPet = new OwnerNewPetWindow(_pCode,"Owner");
            newPet.Show();
        }

        private void sickPet_Click(object sender, EventArgs e)
        {
            PetTreatmentWindow sickPet = new PetTreatmentWindow(_pCode);
            sickPet.Show();
        }
    }
}
