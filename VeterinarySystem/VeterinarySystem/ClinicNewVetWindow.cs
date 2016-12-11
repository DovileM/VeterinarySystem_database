using System;
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
            if (string.IsNullOrEmpty(fName.Text) || string.IsNullOrEmpty(sName.Text) ||
               string.IsNullOrEmpty(pCode.Text))
            {
                MessageBox.Show("Some required fields are empty.", "Error", MessageBoxButtons.OK);
            }
            else
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
