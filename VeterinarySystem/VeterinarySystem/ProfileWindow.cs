using System;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Windows.Forms;

namespace VeterinarySystem
{
    public partial class ProfileWindow : Form
    {
        private string _username;
        private string _password;
        private string _table;

        public ProfileWindow(string name, string pass, string table)
        {
            InitializeComponent();
            _username = name;
            _password = pass;
            _table = table;
            ClearLabels();
            if (table.Equals("Clinic"))
            {
                SeeClinicLabels();
                ShowClinicData();
            }
            else if (table.Equals("Owner"))
            {
                SeeOwner_VetLabels();
                ShowOwnerData();
            }
            else if (table.Equals("Vet"))
            {
                SeeOwner_VetLabels();
                startedDate.Visible = true;
                startedLabel.Visible = true;
                ShowVetData();
            }
        }

        #region See / Clear / Show
        private void SeeClinicLabels()
        {
            clinicLabel.Visible = true;
            clinic_pCode.Visible = true;
            city_fNameTextBox.Visible = true;
            cityLabel.Visible = true;
            streetLabel.Visible = true;
            streetTextBox.Visible = true;
            noLabel.Visible = true;
            noTextBox.Visible = true;
            phoneLabel.Visible = true;
            phoneTextBox.Visible = true;
            cityLabel.Visible = true;
        }

        private void SeeOwner_VetLabels()
        {
            pCodeLabel.Visible = true;
            clinic_pCode.Visible = true;
            fNameLabel.Visible = true;
            city_fNameTextBox.Visible = true;
            sNameLabel.Visible = true;
            sNameTextBox.Visible = true;
            phoneLabel.Visible = true;
            phoneTextBox.Visible = true;
        }

        private void ClearLabels()
        {
            pCodeLabel.Visible = false;
            clinic_pCode.Visible = false;
            fNameLabel.Visible = false;
            city_fNameTextBox.Visible = false;
            sNameLabel.Visible = false;
            sNameTextBox.Visible = false;
            phoneLabel.Visible = false;
            phoneTextBox.Visible = false;
            clinicLabel.Visible = false;
            cityLabel.Visible = false;
            streetLabel.Visible = false;
            streetTextBox.Visible = false;
            noLabel.Visible = false;
            noTextBox.Visible = false;
            startedLabel.Visible = false;
            startedDate.Visible = false;
        }

        private void ShowClinicData()
        {
            using (VeterinaryEntities dataBase = new VeterinaryEntities())
            {
                var smth = dataBase.Clinics.Where(c => c.Name.Equals(_username) && c.City.Equals(_password)).Select(p => p);
                foreach (var item in smth)
                {
                    clinic_pCode.Text = item.Name.ToString();
                    city_fNameTextBox.Text = item.City.ToString();
                    streetTextBox.Text = item.Street.ToString();
                    noTextBox.Text = item.No.ToString();
                    phoneTextBox.Text = item.Phone.ToString();
                }
            }
        }

        private void ShowOwnerData()
        {
            using (VeterinaryEntities dataBase = new VeterinaryEntities())
            {
                var owners = dataBase.Owners.Where(c => c.Name.Equals(_username) && c.SurName.Equals(_password)).Select(p => p);
                foreach (var owner in owners)
                {
                    Trace.WriteLine(owner.ToString());
                    clinic_pCode.Text = owner.PCode.ToString();
                    city_fNameTextBox.Text = owner.Name.ToString();
                    sNameTextBox.Text = owner.SurName.ToString();
                    streetTextBox.Text = owner.SurName.ToString();
                    phoneTextBox.Text = owner.Phone.ToString();
                }
            }
        }

        private void ShowVetData()
        {
            using (VeterinaryEntities dataBase = new VeterinaryEntities())
            {
                var vets = dataBase.Vets.Where(c => c.Name.Equals(_username) && c.SurName.Equals(_password)).Select(p => p);
                foreach (var vet in vets)
                {
                    Trace.WriteLine(vet.ToString());
                    clinic_pCode.Text = vet.PCode.ToString();
                    city_fNameTextBox.Text = vet.Name.ToString();
                    sNameTextBox.Text = vet.SurName.ToString();
                    streetTextBox.Text = vet.SurName.ToString();
                    phoneTextBox.Text = vet.Phone.ToString();
                    startedDate.Text = vet.StartedAt.ToString();
                }
            }
        }

        #endregion


        private void cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ok_Click(object sender, EventArgs e)
        {
            if (_table.Equals("Clinic"))
            {
                using(VeterinaryEntities dataBase = new VeterinaryEntities())
                {
                    Clinic clinic = dataBase.Clinics.FirstOrDefault(c => c.Name.Equals(_username) && c.City.Equals(_password));
                        clinic.City = city_fNameTextBox.Text;
                        clinic.Street = streetTextBox.Text;
                        clinic.No = noTextBox.Text;
                        clinic.Phone = phoneTextBox.Text;
                    dataBase.SaveChanges();
                }
            }
            else if (_table.Equals("Owner"))
            {
                using (VeterinaryEntities dataBase = new VeterinaryEntities())
                {
                    Owner owner = dataBase.Owners.FirstOrDefault(c => c.Name.Equals(_username) && c.SurName.Equals(_password));
                        owner.Name = city_fNameTextBox.Text;
                        owner.SurName = streetTextBox.Text;
                        owner.Phone = phoneTextBox.Text;
                    dataBase.SaveChanges();
                }
            }
            else if (_table.Equals("Vet"))
            {
                using (VeterinaryEntities dataBase = new VeterinaryEntities())
                {
                    Vet vet = dataBase.Vets.FirstOrDefault(c => c.Name.Equals(_username) && c.SurName.Equals(_password));
                    vet.Name = city_fNameTextBox.Text;
                    vet.SurName = streetTextBox.Text;
                    vet.Phone = phoneTextBox.Text;
                    vet.StartedAt = startedDate.Value.Date;
                    dataBase.SaveChanges();
                }
            }
            Close();
        }

        private void delete_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Do you want to delete account?", "Warning!", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                if (_table.Equals("Clinic"))
                {
                    using (VeterinaryEntities dataBase = new VeterinaryEntities())
                    {
                        Clinic clinic = dataBase.Clinics.FirstOrDefault(c => c.Name.Equals(_username) && c.City.Equals(_password));
                        dataBase.Clinics.Remove(clinic);
                        dataBase.SaveChanges();
                    }
                }
                else if (_table.Equals("Owner"))
                {
                    using (VeterinaryEntities dataBase = new VeterinaryEntities())
                    {
                        Owner owner = dataBase.Owners.FirstOrDefault(c => c.Name.Equals(_username) && c.SurName.Equals(_password));
                        dataBase.Owners.Remove(owner);
                        dataBase.SaveChanges();
                    }
                }
                DialogResult = DialogResult.OK;
                Close();
            }
        }
    }
}
