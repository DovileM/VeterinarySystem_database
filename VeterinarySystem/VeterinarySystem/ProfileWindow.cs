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
            ClearLabels();
            if (table.Equals("Clinic"))
            {
                SeeClinicLabels();
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
            //naudoti SELECT per ENTITY FRAMEWORK
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
