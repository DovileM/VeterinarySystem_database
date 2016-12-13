using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace VeterinarySystem
{
    public partial class ClinicNewVetWindow : Form
    {
        private DateTime? _date;
        private string _phone;

        private string _username;

        public ClinicNewVetWindow(string name)
        {
            InitializeComponent();
            _date = null;
            _phone = null;
            _username = name;
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ok_Click(object sender, EventArgs e)
        {
            fName.ForeColor = System.Drawing.Color.Black;
            sName.ForeColor = System.Drawing.Color.Black;
            pCode.ForeColor = System.Drawing.Color.Black;
            phone.ForeColor = System.Drawing.Color.Black;

            if (string.IsNullOrEmpty(fName.Text) || string.IsNullOrEmpty(sName.Text) ||
                   string.IsNullOrEmpty(pCode.Text))
                {
                    MessageBox.Show("Some required fields are empty.", "Error", MessageBoxButtons.OK);
                }
                else
                {
                if (CheckValidation())
                {
                    using (VeterinaryEntities dataBase = new VeterinaryEntities())
                    {
                        dataBase.Vets.Add(new Vet
                        {
                            Clinic = _username,
                            Name = fName.Text,
                            SurName = sName.Text,
                            PCode = pCode.Text,
                            Phone = _phone,
                            StartedAt = _date
                        });
                        dataBase.SaveChanges();
                    }
                    Close();
                }
                }
        }

        private bool CheckValidation()
        {
            bool tf = true;
            if (!Regex.IsMatch(fName.Text, @"^[\p{L} ]+$"))
            {
                fName.ForeColor = System.Drawing.Color.Red;
                tf = false;
            }
            if (!Regex.IsMatch(sName.Text, @"^[\p{L} ]+$"))
            {
                sName.ForeColor = System.Drawing.Color.Red;
                tf = false;
            }
            if (!Regex.IsMatch(pCode.Text, @"^[3-4]\d{4}[0-3][0-9]\d{4}$"))
            {
                pCode.ForeColor = System.Drawing.Color.Red;
                tf = false;
            }
            if(!string.IsNullOrEmpty(phone.Text))
                if (!Regex.IsMatch(phone.Text, @"^86\d{7}$"))
                {
                    phone.ForeColor = System.Drawing.Color.Red;
                    tf = false;
                }

            return tf;
        }

        private void phone_Leave(object sender, EventArgs e)
        {
            _phone = phone.Text;
        }

        private void startedAt_ValueChanged(object sender, EventArgs e)
        {
            _date = startedAt.Value.Date;
        }
    }
}
