using System;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;

namespace VeterinarySystem
{
    public partial class UpdateDeleteWindow : Form
    {
        private int _petId;
        private string _petName;
        public UpdateDeleteWindow(int id)
        {
            InitializeComponent();
            _petId = id;
            using(VeterinaryEntities dataBase = new VeterinaryEntities())
            {
                var pets = dataBase.Pets.Where(p => p.Id == _petId).Select(p => new { Name = p.Name });
                foreach (var pet in pets)
                {
                    name.Text = pet.Name + "?";
                    _petName = pet.Name;
                }
            }
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void delete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show($"Delete {_petName}?", "Warnning", MessageBoxButtons.YesNo);
            if(result == DialogResult.Yes)
            {
                string str_connection = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Dovile\Desktop\Veterinary\VeterinarySystem\VeterinarySystem\DatabaseVeterinary.mdf;Integrated Security=True";

                SqlConnection connection = new SqlConnection();
                connection.ConnectionString = str_connection;
                connection.Open();

                SqlCommand delete = new SqlCommand();
                delete.Connection = connection;
                delete.CommandType = CommandType.Text;
                delete.CommandText = $"DELETE FROM Pet WHERE Id ={_petId}";

                try
                {
                    delete.ExecuteNonQuery();
                }
                catch (SqlException) { }

                connection.Close();
            }
            Close();
        }

        private void update_Click(object sender, EventArgs e)
        {
            PetUpdateWindow petUpdate = new PetUpdateWindow(_petId);
            petUpdate.Closed += PetUpdateWindow_IsClosed;
            petUpdate.Show();
        }
        private void PetUpdateWindow_IsClosed(object sender, EventArgs e)
        {
            Close();
        }
    }
}
