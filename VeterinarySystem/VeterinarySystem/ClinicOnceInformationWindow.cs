using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace VeterinarySystem
{
    public partial class ClinicOnceInformationWindow : Form
    {
        private string _clinic;
        public ClinicOnceInformationWindow(string clinic)
        {
            InitializeComponent();
            _clinic = clinic;
            chooseVet.Text = "Choose a vet";
            chooseVet.SelectedIndex = -1;
        }

        private void choose_SelectedIndexChanged(object sender, EventArgs e)
        {
            int select = choose.SelectedIndex;
            clearVisible();
            switch (select)
            {
                case 0:
                    SeeVetLabels();
                    SeeVets();
                    break;
                case 1:
                    SeeOwnerLabels();
                    SeeAnimals();
                    break;
            }
        }
        #region See / Clear
        private void SeeVetLabels()
        {
            chooseVetLabel.Visible = true;
            chooseVet.Visible = true;
            fName.Visible = true;
            fNameText.Visible = true;
            sName.Visible = true;
            sNameText.Visible = true;
            phone.Visible = true;
            phoneText.Visible = true;
            startedAt.Visible = true;
            pCodeText.Visible = true;
            animals.Visible = true;
            started_animalTypeText.Visible = true;
            seeAllAnimals.Visible = true;
            count.Visible = true;
            pCodeLabel.Visible = true;
        }
        
        private void SeeOwnerLabels()
        {
            chooseLabel.Visible = true;
            pCodeLabel.Visible = true;
            animalType.Visible = true;
            animalComboBox.Visible = true;
            animalsCount.Visible = true;
            pCodeText.Visible = true;
            started_animalTypeText.Visible = true;
            fName.Visible = true;
            fNameText.Visible = true;
            sName.Visible = true;
            sNameText.Visible = true;
            phone.Visible = true;
            phoneText.Visible = true;
            allOwnerAnimals.Visible = true;
        }

        private void clearVisible()
        {
            count.Visible = false;
            pCodeLabel.Visible = false;
            animalType.Visible = false;
            chooseVet.Visible = false;
            allOwnerAnimals.Visible = false;
            backLabel.Visible = false;
            chooseVetLabel.Visible = false;
            fName.Visible = false;
            fNameText.Visible = false;
            sName.Visible = false;
            sNameText.Visible = false;
            phone.Visible = false;
            phoneText.Visible = false;
            startedAt.Visible = false;
            pCodeText.Visible = false;
            animals.Visible = false;
            started_animalTypeText.Visible = false;
            seeAllAnimals.Visible = false;
            chooseLabel.Visible = false;
            animalComboBox.Visible = false;
            animalsCount.Visible = false;
        }
        #endregion

        private void SeeAnimals()
        {
            //using(VeterinaryEntities dataBase = new VeterinaryEntities())
            //{
            //    var animals = dataBase.Pets.Select(p => p.Name);
            //    foreach (var pet in animals)
            //    {
            //        animalComboBox.Items.Add(pet);
            //    }
            //}
        }
        private void SeeVets()
        {
            using (VeterinaryEntities dataBase = new VeterinaryEntities())
            {
                var vets = dataBase.Vets.Where(v => v.Clinic.Equals(_clinic)).Select(v => new {Name =  v.Name, SurName = v.SurName}).
                    OrderBy(v => v.SurName);
                foreach (var vet in vets)
                {
                    string user = vet.Name + " " + vet.SurName;
                    chooseVet.Items.Add(user);
                }
            }
        }

        private void animalComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void chooseVet_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selected = chooseVet.SelectedIndex;

            if (selected >= 0)
            {
                using (VeterinaryEntities dataBase = new VeterinaryEntities())
                {
                    var vets = dataBase.Vets.Where(v => v.Clinic.Equals(_clinic)).
                        Select(v => new { Name = v.Name, SurName = v.SurName, PCode = v.PCode, Phone = v.Phone, Started = v.StartedAt }).
                        OrderBy(v => v.SurName).Skip(selected).Take(1);
                    foreach (var vet in vets)
                    {
                        var pets = dataBase.Treatments.Where(t => t.Vet.Equals(vet.PCode) && (t.End >= DateTime.Today)).Count();

                        fNameText.Text = vet.Name;
                        sNameText.Text = vet.SurName;
                        phoneText.Text = vet.Phone;
                        started_animalTypeText.Text = vet.Started.ToString();
                        pCodeText.Text = vet.PCode;
                        count.Text = pets.ToString();
                    }
                }
            }
        }
    }
}
