using System;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace VeterinarySystem
{
    public partial class PetUpdateWindow : Form
    {
        private int _petId;
        public PetUpdateWindow(int id)
        {
            InitializeComponent();
            _petId = id;
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void update_Click(object sender, EventArgs e)
        {
            name.ForeColor = System.Drawing.Color.Black;
            type.ForeColor = System.Drawing.Color.Black;
            species.ForeColor = System.Drawing.Color.Black;
            weight.ForeColor = System.Drawing.Color.Black;
            color.ForeColor = System.Drawing.Color.Black;

            if (string.IsNullOrEmpty(name.Text) || string.IsNullOrEmpty(type.Text))
                MessageBox.Show("Can't update. Some required fields are empty", "Error", MessageBoxButtons.OK);
            else
            {
                if (CheckValidation())
                {
                    string str_connection = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Dovile\Desktop\Veterinary\VeterinarySystem\VeterinarySystem\DatabaseVeterinary.mdf;Integrated Security=True";

                    SqlConnection connection = new SqlConnection();
                    connection.ConnectionString = str_connection;
                    connection.Open();

                    SqlCommand update = new SqlCommand();
                    update.Connection = connection;
                    update.CommandType = CommandType.Text;
                    update.CommandText = "UPDATE Pet SET Name=@N, Type=@T, Species=@S, Born=@B, Weight=@W, Color=@C WHERE Id=" + _petId;

                    update.Parameters.Add(new SqlParameter("@N", name.Text));
                    update.Parameters.Add(new SqlParameter("@T", type.Text));
                    if (string.IsNullOrEmpty(species.Text))
                        update.Parameters.Add(new SqlParameter("@S", DBNull.Value));
                    else
                        update.Parameters.Add(new SqlParameter("@S", species.Text));
                    if (birth.Text.Length == 0)
                        update.Parameters.Add(new SqlParameter("@B", DBNull.Value));
                    else
                        update.Parameters.Add(new SqlParameter("@B", birth.Value.Date));
                    if (string.IsNullOrEmpty(weight.Text))
                        update.Parameters.Add(new SqlParameter("@W", DBNull.Value));
                    else
                        update.Parameters.Add(new SqlParameter("@W", weight.Text));
                    if (string.IsNullOrEmpty(color.Text))
                        update.Parameters.Add(new SqlParameter("@C", DBNull.Value));
                    else
                        update.Parameters.Add(new SqlParameter("@C", color.Text));

                    try
                    {
                        update.ExecuteNonQuery();
                    }
                    catch (SqlException) { }

                    connection.Close();
                    Close();
                }
            }
        }

        private bool CheckValidation()
        {
            bool tf = true;
            if (!Regex.IsMatch(name.Text, @"^[\p{L} ]+$"))
            {
                name.ForeColor = System.Drawing.Color.Red;
                tf = false;
            }
            if (!Regex.IsMatch(type.Text, @"^[\p{L} ]+$"))
            {
                type.ForeColor = System.Drawing.Color.Red;
                tf = false;
            }
            if (!Regex.IsMatch(color.Text, @"^[\p{L} ]+$"))
            {
                color.ForeColor = System.Drawing.Color.Red;
                tf = false;
            }
            if (!Regex.IsMatch(species.Text, @"^[\p{L} ]+$"))
            {
                species.ForeColor = System.Drawing.Color.Red;
                tf = false;
            }
            if (!Regex.IsMatch(weight.Text, @"^\d{0,3}.{0,1}\d{0,3}$"))
            {
                weight.ForeColor = System.Drawing.Color.Red;
                tf = false;
            }

            return tf;
        }

        private void PetUpdateWindow_Load(object sender, EventArgs e)
        {
            using (VeterinaryEntities dataBase = new VeterinaryEntities())
            {
                var pets = dataBase.Pets.Where(p => p.Id == _petId).Select(p => p);
                foreach (var pet in pets)
                {
                    name.Text = pet.Name;
                    type.Text = pet.Type;
                    species.Text = pet.Species;
                    weight.Text = pet.Weight.ToString();
                    color.Text = pet.Color;
                    birth.Text = pet.Born.ToString();
                }
            }
        }
    }
}
