using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
                SeeOwnerLabels();
            }

        }

        private void SeeClinicLabels()
        {
            clinicLabel.Visible = true;
            clinic_pCodeTextBox.Visible = true;
            clinic_pCodeTextBox.Visible = true;
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

        private void SeeOwnerLabels()
        {
            pCodeLabel.Visible = true;
            clinic_pCodeTextBox.Visible = true;
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
            clinic_pCodeTextBox.Visible = false;
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
        }

        private void ShowClinicData()
        {
            using (VeterinaryEntities dataBase = new VeterinaryEntities())
            {
                var smth = dataBase.Clinics.Where(c => c.Name.Equals(_username) && c.City.Equals(_password)).Select(p => p);
                foreach (var item in smth)
                {
                    Trace.WriteLine(item.ToString());
                    clinic_pCodeTextBox.Text = item.Name.ToString();
                    city_fNameTextBox.Text = item.City.ToString();
                    streetTextBox.Text = item.Street.ToString();
                    noTextBox.Text = item.No.ToString();
                    phoneTextBox.Text = item.Phone.ToString();
                }
            }
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
