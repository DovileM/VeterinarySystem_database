using System;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace VeterinarySystem
{
    public partial class SignUpWindow : Form
    {
        private string _clinic;
        private string _pCode;
        private string _city_fName;
        private string _street;
        private string _no;
        private string _phone;
        private string _sName;
        private string _type;
        private int _selected;

        public SignUpWindow()
        {
            InitializeComponent();

        }
        private void SignUpWindow_Load(object sender, EventArgs e)
        {
            ClearLabels();
            ClearTextBoxes();
            SeeOwnerLabels();
            SetFieldsNull();
            choose.SelectedIndex = 0;
            _selected = 0;
            _type = "Owner";
            clinicTextBox.Leave += GetClinic;
            pCodeTextBox.Leave += GetPCode;
            city_sNameTextBox.Leave += GetCity_FName;
            sNameTextBox.Leave += GetSName;
            phoneTextBox.Leave += GetPhone;
            streetTextBox.Leave += GetStreet;
            noTextBox.Leave += GetNo;
        }

        #region See / Clear / Set Null
        private void SeeOwnerLabels()
        {
            pCodeLabel.Visible = true;
            pCodeTextBox.Visible = true;
            fNameLabel.Visible = true;
            city_sNameTextBox.Visible = true;
            sNameLabel.Visible = true;
            sNameTextBox.Visible = true;
            phoneOwnerLabel.Visible = true;
            phoneTextBox.Visible = true;
            ownerLabel.Visible = true;
            owner2Label.Visible = true;
        }

        private void SeeClinicLabels()
        {
            clinicNameLabel.Visible = true;
            clinicTextBox.Visible = true;
            cityLabel.Visible = true;
            city_sNameTextBox.Visible = true;
            streetLabel.Visible = true;
            streetTextBox.Visible = true;
            noLabel.Visible = true;
            noTextBox.Visible = true;
            phoneClinicLabel.Visible = true;
            phoneTextBox.Visible = true;
            clinicLabel.Visible = true;
            clinic2Label.Visible = true;
        }

        private void ClearLabels()
        {
            pCodeLabel.Visible = false;
            pCodeTextBox.Visible = false;
            clinicTextBox.Visible = false;
            fNameLabel.Visible = false;
            city_sNameTextBox.Visible = false;
            sNameLabel.Visible = false;
            sNameTextBox.Visible = false;
            phoneClinicLabel.Visible = false;
            phoneOwnerLabel.Visible = false;
            phoneTextBox.Visible = false;
            ownerLabel.Visible = false;
            owner2Label.Visible = false;
            clinicNameLabel.Visible = false;
            cityLabel.Visible = false;
            streetLabel.Visible = false;
            streetTextBox.Visible = false;
            noLabel.Visible = false;
            noTextBox.Visible = false;
            clinicLabel.Visible = false;
            clinic2Label.Visible = false;
        }

        private void ClearTextBoxes()
        {
            clinicTextBox.Text = null;
            pCodeTextBox.Text = null;
            city_sNameTextBox.Text = null;
            sNameTextBox.Text = null;
            phoneTextBox.Text = null;
            streetTextBox.Text = null;
            noTextBox.Text = null;
        }

        private void SetFieldsNull()
        {
            _clinic = null;
            _pCode = null;
            _no = null;
            _phone = null;
            _sName = null;
            _street = null;
            _city_fName = null;
        }
        #endregion

        #region Get Textbox as Text
        private void GetClinic(object sender, EventArgs e)
        {
            _clinic = (sender as TextBox).Text;
        }
        private void GetPCode(object sender, EventArgs e)
        {
            _pCode = (sender as TextBox).Text;
        }
        private void GetCity_FName(object sender, EventArgs e)
        {
            _city_fName = (sender as TextBox).Text;
        }
        private void GetSName(object sender, EventArgs e)
        {
            _sName = (sender as TextBox).Text;
        }
        private void GetPhone(object sender, EventArgs e)
        {
            _phone = (sender as TextBox).Text;
        }
        private void GetStreet(object sender, EventArgs e)
        {
            _street = (sender as TextBox).Text;
        }
        private void GetNo(object sender, EventArgs e)
        {
            _no = (sender as TextBox).Text;
        }
        #endregion


        private void cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void choose_SelectedIndexChanged(object sender, EventArgs e)
        {
            _selected = choose.SelectedIndex;
            ClearLabels();
            ClearTextBoxes();
            SetFieldsNull();
            switch (_selected)
            {
                case 0:
                    SeeOwnerLabels();
                    _type = "Owner";
                    break;
                case 1:
                    SeeClinicLabels();
                    _type = "Clinic";
                    break;
            }
        }

        private void ok_Click(object sender, EventArgs e)
        {
            bool ok = true;
            switch (_selected)
            {
                case 0:
                    ok = InsertIntoTable("Owner");
                    break;
                case 1:
                    ok = InsertIntoTable("Clinic");
                    break;
            }
            if (ok)
                Close();
            else
                MessageBox.Show("Something went wrong! Maybe some required fields are empty.", "Error", MessageBoxButtons.OK);
        }

        private bool InsertIntoTable(string table)
        {
            clinicTextBox.ForeColor = System.Drawing.Color.Black;
            pCodeTextBox.ForeColor = System.Drawing.Color.Black;
            city_sNameTextBox.ForeColor = System.Drawing.Color.Black;
            sNameTextBox.ForeColor = System.Drawing.Color.Black;
            phoneTextBox.ForeColor = System.Drawing.Color.Black;
            streetTextBox.ForeColor = System.Drawing.Color.Black;
            noTextBox.ForeColor = System.Drawing.Color.Black;
            bool ok = true;

            if (CheckValidation())
            {
                string str_connection = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Dovile\Desktop\Veterinary\VeterinarySystem\VeterinarySystem\DatabaseVeterinary.mdf;Integrated Security=True";

                SqlConnection connection = new SqlConnection();
                connection.ConnectionString = str_connection;
                connection.Open();

                SqlCommand insert = new SqlCommand();
                insert.Connection = connection;
                insert.CommandType = CommandType.Text;
                if (table.Equals("Owner"))
                {
                    insert.CommandText = "INSERT INTO Owner (PCode, Name, SurName, Phone) VALUES (@PC, @N, @SN, @P)";
                    insert.Parameters.Add(new SqlParameter("@PC", _pCode));
                    insert.Parameters.Add(new SqlParameter("@N", _city_fName));
                    insert.Parameters.Add(new SqlParameter("@SN", _sName));
                    if (string.IsNullOrEmpty(_phone))
                        insert.Parameters.Add(new SqlParameter("@P", DBNull.Value));
                    else
                        insert.Parameters.Add(new SqlParameter("@P", _phone));
                    Trace.WriteLine(_pCode + "  " + _city_fName + "  " + _sName + "  " + _phone);

                }
                else
                {
                    insert.CommandText = "INSERT INTO Clinic (Name, City, Street, No, Phone) VALUES (@N, @C, @S, @No, @P)";
                    insert.Parameters.Add(new SqlParameter("@N", _clinic));
                    insert.Parameters.Add(new SqlParameter("@C", _city_fName));
                    insert.Parameters.Add(new SqlParameter("@S", _street));
                    insert.Parameters.Add(new SqlParameter("@No", _no));
                    insert.Parameters.Add(new SqlParameter("@P", _phone));
                }

                try
                {
                    insert.ExecuteNonQuery();
                }
                catch (SqlException e)
                {
                    ok = false;
                    Trace.WriteLine(e.Message);
                }

                connection.Close();
                return ok;
            }
            return false;
        }
        private bool CheckValidation()
        {
            bool tf = true;
            if (_type.Equals("Owner"))
            {
                if (!Regex.IsMatch(pCodeTextBox.Text, @"^[3-4]\d{4}[0-3][0-9]\d{4}$"))
                {
                    pCodeTextBox.ForeColor = System.Drawing.Color.Red;
                    tf = false;
                }
                if (!string.IsNullOrEmpty(phoneTextBox.Text))
                    if (!Regex.IsMatch(phoneTextBox.Text, @"^86\d{7}$"))
                    {
                        phoneTextBox.ForeColor = System.Drawing.Color.Red;
                        tf = false;
                    }
            }
            else
            {
                if (!Regex.IsMatch(streetTextBox.Text, @"^[\p{L} ]+ g{0,1}.{0,1}$"))
                {
                    streetTextBox.ForeColor = System.Drawing.Color.Red;
                    tf = false;
                }
                if (!Regex.IsMatch(clinicTextBox.Text, @"^[\p{L} ]+$"))
                {
                    clinicTextBox.ForeColor = System.Drawing.Color.Red;
                    tf = false;
                }
                if (!Regex.IsMatch(phoneTextBox.Text, @"^86\d{7}$"))
                {
                    phoneTextBox.ForeColor = System.Drawing.Color.Red;
                    tf = false;
                }
                if (!Regex.IsMatch(noTextBox.Text, @"^\d{1,5}[A-H]{0,1}$"))
                {
                    noTextBox.ForeColor = System.Drawing.Color.Red;
                    tf = false;
                }
            }
            if (!Regex.IsMatch(city_sNameTextBox.Text, @"^[\p{L} ]+$"))
            {
                city_sNameTextBox.ForeColor = System.Drawing.Color.Red;
                tf = false;
            }

            return tf;
        }

    }
}
