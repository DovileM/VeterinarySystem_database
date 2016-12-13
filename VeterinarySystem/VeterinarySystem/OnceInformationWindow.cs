using System;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Windows.Forms;

namespace VeterinarySystem
{
    public partial class OnceInformationWindow : Form
    {
        private string _pCode;
        private string _clinic;
        public OnceInformationWindow(string type, string clinic)
        {
            InitializeComponent();
            if (type.Equals("Clinic"))
            {
                choose.Visible = true;
                _clinic = clinic;
                chooseVet.Text = "Choose a vet";
                chooseVet.SelectedIndex = -1;
            }
            else if (type.Equals("Vet"))
            {
                _pCode = clinic;
                clearVisible();
                choose.Visible = false;
                SeeOwnerLabels();
                SeeVetAnimals();
            }
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
            animalComboBox.Visible = true;
            animalsCount.Visible = true;
            pCodeText.Visible = true;
            fName.Visible = true;
            fNameText.Visible = true;
            sName.Visible = true;
            sNameText.Visible = true;
            phone.Visible = true;
            phoneText.Visible = true;
            allOwnerAnimals.Visible = true;
            count.Visible = true;
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

            using (VeterinaryEntities dataBase = new VeterinaryEntities())
            {
                var pets = (from pet in dataBase.Pets
                            join owner in dataBase.Owners on pet.Owner equals owner.PCode
                            join treat in dataBase.Treatments on pet.Id equals treat.Animal
                            join vet in dataBase.Vets on treat.Vet equals vet.PCode
                            select new
                            {
                                PName = pet.Name,
                                PType = pet.Type,
                                Clinic = vet.Clinic
                            }).Distinct();

                foreach (var pet in pets)
                {
                    if(pet.Clinic.Equals(_clinic))
                        animalComboBox.Items.Add(pet.PName + ", " + pet.PType.ToLower());
                }

            }
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

        private void SeeVetAnimals()
        {
            int selected = animalComboBox.SelectedIndex;

            using (VeterinaryEntities dataBase = new VeterinaryEntities())
            {
                var pets = (from pet in dataBase.Pets
                            join owner in dataBase.Owners on pet.Owner equals owner.PCode
                            join treat in dataBase.Treatments on pet.Id equals treat.Animal
                            join vet in dataBase.Vets on treat.Vet equals vet.PCode
                            where vet.PCode == _pCode
                            select new
                            {
                                PName = pet.Name,
                                PType = pet.Type,
                                Clinic = vet.Clinic
                            }).Distinct();

                foreach (var pet in pets)
                {
                        animalComboBox.Items.Add(pet.PName + ", " + pet.PType.ToLower());
                    _clinic = pet.Clinic;
                }
            }
        }


        private void animalComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selected = animalComboBox.SelectedIndex;

            using (VeterinaryEntities dataBase = new VeterinaryEntities())
            {
                var owners = (from pet in dataBase.Pets
                            join owner in dataBase.Owners on pet.Owner equals owner.PCode
                            join treat in dataBase.Treatments on pet.Id equals treat.Animal
                            join vet in dataBase.Vets on treat.Vet equals vet.PCode
                            select new
                            {
                                FName = owner.Name,
                                SName = owner.SurName,
                                Phone = owner.Phone,
                                PCode = owner.PCode,
                                Pets = dataBase.Pets.Where(p => p.Owner.Equals(owner.PCode)).Count(),
                                PName = pet.Name,
                                PType = pet.Type,
                                Clinic = vet.Clinic
                            }).Distinct();

                int i = 0;
                foreach (var owner in owners)
                {
                    if (owner.Clinic.Equals(_clinic))
                    {
                        if (i == selected)
                        {
                            _pCode = owner.PCode;
                            pCodeText.Text = owner.PCode;
                            fNameText.Text = owner.FName;
                            sNameText.Text = owner.SName;
                            phoneText.Text = owner.Phone;
                            count.Text = owner.Pets.ToString();
                        }
                        i++;
                    }
                }
            }
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
                        _pCode = vet.PCode;
                        count.Text = pets.ToString();
                    }
                }
            }
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void allOwnerAnimals_Click(object sender, EventArgs e)
        {
            ClinicAllSpecificWindow info = new ClinicAllSpecificWindow(_clinic, _pCode, "Owner");
            try
            {
                info.Show();
            }
            catch (Exception) { }
        }

        private void seeAllAnimals_Click(object sender, EventArgs e)
        {
            ClinicAllSpecificWindow info = new ClinicAllSpecificWindow(_clinic, _pCode, "Vet");
            try
            {
                info.Show();
            }
            catch (Exception) { }
        }
    }
}
