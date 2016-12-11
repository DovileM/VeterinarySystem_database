using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VeterinarySystem
{
    public partial class OwnerRegistPetWindow : Form
    {
        private string _pCode;
        private int[] _petsId;
        private string[] _clinics;
        private string[] _vets;
        private int _selectedPet;
        private string _selectedVet;
        private string _selectedClinic;

        public OwnerRegistPetWindow(string pCode)
        {
            InitializeComponent();
            _pCode = pCode;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            using (VeterinaryEntities dataBase = new VeterinaryEntities())
            {
                var pets = dataBase.Pets.Where(p => p.Owner.Equals(_pCode)).Select(p => new { Name = p.Name, Type = p.Type, Id = p.Id });
                _petsId = new int[pets.Count()];
                int i = 0;
                foreach (var pet in pets)
                {
                    choosePet.Items.Add(pet.Name + ", " + pet.Type);
                    _petsId[i++] = pet.Id;
                }

                i = 0;
                var clinics = dataBase.Clinics.Select(c => new { Name = c.Name, City = c.City });
                _clinics = new string[clinics.Count()];
                foreach (var clinic in clinics)
                {
                    chooseClinic.Items.Add(clinic.Name +", "+clinic.City);
                    _clinics[i++] = clinic.Name;
                }
            }
        }

        private void choosePet_SelectedIndexChanged(object sender, EventArgs e)
        {
            _selectedPet = _petsId[choosePet.SelectedIndex];
        }

        private void chooseClinic_SelectedIndexChanged(object sender, EventArgs e)
        {
            chooseVet.Items.Clear();
            _selectedClinic = _clinics[chooseClinic.SelectedIndex];
            using(VeterinaryEntities dataBase = new VeterinaryEntities())
            {
                var vets = dataBase.Vets.Where(v => v.Clinic.Equals(_selectedClinic)).
                            Select(v => new {Name = v.Name, SurName = v.SurName, PCode = v.PCode});
                _vets = new string[vets.Count()];
                int i = 0;
                foreach (var vet in vets)
                {
                    chooseVet.Items.Add(vet.Name +" "+vet.SurName);
                    _vets[i++] = vet.PCode;
                }
            }
        }

        private void chooseVet_SelectedIndexChanged(object sender, EventArgs e)
        {
            _selectedVet = _vets[chooseVet.SelectedIndex];
        }

        private void clinicInfoButton_Click(object sender, EventArgs e)
        {
            OwnerClinicWindow clinic = new OwnerClinicWindow("Clinic", _pCode);
            clinic.Show();
        }

        private void ok_Click(object sender, EventArgs e)
        {
            using(VeterinaryEntities dataBase = new VeterinaryEntities())
            {
                var treat = dataBase.Treatments.Add(new Treatment {
                    Animal = _selectedPet,
                    Vet = _selectedVet,
                    Start = startDate.Value.Date
                    });
                dataBase.SaveChanges();
            }
            Close();
        }

        private void vetsInfoButton_Click(object sender, EventArgs e)
        {
            OwnerClinicWindow clinic = new OwnerClinicWindow("Vet", _selectedClinic);
            clinic.Show();
        }
    }
}
