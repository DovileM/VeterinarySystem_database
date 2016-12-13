using System;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Windows.Forms;

namespace VeterinarySystem
{
    public partial class SignUpWindow : Form
    {
        private string _clinic_pCode;
        private string _city_fName;
        private string _street;
        private string _no;
        private string _phone;
        private string _sName;
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

            clinic_pCodeTextBox.Leave += GetClinic_PCode;
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
            clinic_pCodeTextBox.Visible = true;
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
            clinic_pCodeTextBox.Visible = true;
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
            clinic_pCodeTextBox.Visible = false;
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
            clinic_pCodeTextBox.Text = null;
            city_sNameTextBox.Text = null;
            sNameTextBox.Text = null;
            phoneTextBox.Text = null;
            streetTextBox.Text = null;
            noTextBox.Text = null;
        }

        private void SetFieldsNull()
        {
            _clinic_pCode = null;
            _no = null;
            _phone = null;
            _sName = null;
            _street = null;
            _city_fName = null;
        }
        #endregion

        #region Get Textbox as Text
        private void GetClinic_PCode(object sender, EventArgs e)
        {
            _clinic_pCode = (sender as TextBox).Text;
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
                    break;
                case 1:
                    SeeClinicLabels();
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
            bool ok = true;
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
                insert.Parameters.Add(new SqlParameter("@PC", _clinic_pCode));
                insert.Parameters.Add(new SqlParameter("@N", _city_fName));
                insert.Parameters.Add(new SqlParameter("@SN", _sName));
                if (string.IsNullOrEmpty(_phone))
                    insert.Parameters.Add(new SqlParameter("@P", DBNull.Value));
                else
                    insert.Parameters.Add(new SqlParameter("@P", _phone));
                Trace.WriteLine(_clinic_pCode + "  " + _city_fName + "  " + _sName + "  " + _phone);

            }
            else
            {
                insert.CommandText = "INSERT INTO Clinic (Name, City, Street, No, Phone) VALUES (@N, @C, @S, @No, @P)";
                insert.Parameters.Add(new SqlParameter("@N", _clinic_pCode));
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


    }
}
