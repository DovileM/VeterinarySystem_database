using System;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Windows.Forms;
using System.Linq;

namespace VeterinarySystem
{
    public partial class OwnerNewPetWindow : Form
    {
        private string _pCode;
        private string _type;
        private int[] _petsId;
        private int _petId;
        public OwnerNewPetWindow(string pCode, string type)
        {
            InitializeComponent();
            _pCode = pCode;
            _type = type;
            if (type.Equals("Vet"))
            {
                ShowVetLabels();
                ShowPetData();
            }
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ShowVetLabels()
        {
            nameLabel.Text = "Name:";
            typeLabel.Text = "Type:";
            name.Enabled = false;
            type.Enabled = false;
            species.Enabled = false;
            color.Enabled = false;
            weight.Enabled = false;
            required.Visible = false;
            birthLabel.Text = "Start:";
            endDate.Visible = true;
            endLabel.Visible = true;
            petsLabel.Visible = true;
            choosePet.Visible = true;
        }

        private void ShowPetData()
        {
            using(VeterinaryEntities dataBase = new VeterinaryEntities())
            {
                var pets = from p in dataBase.Pets
                           join t in dataBase.Treatments on p.Id equals t.Animal
                           where t.Vet == _pCode && t.End == null
                           select new { Name = p.Name, Type = p.Type, Id = p.Id };
                _petsId = new int[pets.Count()];
                int i = 0;
                foreach (var pet in pets)
                {
                    choosePet.Items.Add(pet.Name+", "+pet.Type);
                    _petsId[i++] = pet.Id;
                }
            }
        }


        private void ok_Click(object sender, EventArgs e)
        {
            if (type.Equals("Vet"))
            {
                using(VeterinaryEntities dataBase = new VeterinaryEntities())
                {
                    Treatment treat = dataBase.Treatments.Where(t => t.Animal == _petId && t.Vet.Equals(_pCode)).Select(t => t).First();
                    treat.End = endDate.Value.Date;
                    dataBase.SaveChanges();
                }
            }
            else
            {
                if (string.IsNullOrEmpty(name.Text) || string.IsNullOrEmpty(type.Text))
                    MessageBox.Show("Some required fields are empty.", "Error", MessageBoxButtons.OK);
                else
                {
                    string str_connection = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Dovile\Desktop\Veterinary\VeterinarySystem\VeterinarySystem\DatabaseVeterinary.mdf;Integrated Security=True";

                    SqlConnection connection = new SqlConnection();
                    connection.ConnectionString = str_connection;
                    connection.Open();

                    SqlCommand insert = new SqlCommand("INSERT INTO Pet (Name, Owner, Type, Species, Born, Weight, Color) " +
                                                        "VALUES (@N, @O, @T, @S, @B, @W, @C)", connection);

                    insert.Parameters.Add(new SqlParameter("@N", name.Text));
                    insert.Parameters.Add(new SqlParameter("@O", _pCode));
                    insert.Parameters.Add(new SqlParameter("@T", type.Text));
                    if (string.IsNullOrEmpty(species.Text))
                        insert.Parameters.Add(new SqlParameter("@S", DBNull.Value));
                    else
                        insert.Parameters.Add(new SqlParameter("@S", species.Text));
                    if (string.IsNullOrEmpty(birth.Text))
                        insert.Parameters.Add(new SqlParameter("@B", DBNull.Value));
                    else
                        insert.Parameters.Add(new SqlParameter("@B", birth.Value.Date));
                    if (string.IsNullOrEmpty(weight.Text))
                        insert.Parameters.Add(new SqlParameter("@W", DBNull.Value));
                    else
                        insert.Parameters.Add(new SqlParameter("@W", weight.Text));
                    if (string.IsNullOrEmpty(color.Text))
                        insert.Parameters.Add(new SqlParameter("@C", DBNull.Value));
                    else
                        insert.Parameters.Add(new SqlParameter("@C", color.Text));

                    try
                    {
                        insert.ExecuteNonQuery();
                    }
                    catch (SqlException) { }

                    connection.Close();
                    Close();
                }
            }
        }

        private void choosePet_SelectedIndexChanged(object sender, EventArgs e)
        {
            _petId = _petsId[choosePet.SelectedIndex];
            using(VeterinaryEntities dataBase = new VeterinaryEntities())
            {
                var pet = (from p in dataBase.Pets
                           join t in dataBase.Treatments on p.Id equals t.Animal
                           where t.Vet == _pCode && t.End == null && _petId == t.Animal
                           select new {
                               Name = p.Name, 
                               Type = p.Type,
                               Species = p.Species,
                               Weight = p.Weight,
                               Color = p.Color,
                               Start = t.Start,
                               Id = p.Id
                           }).FirstOrDefault();
                
                name.Text = pet.Name;
                type.Text = pet.Type;
                species.Text = pet.Species;
                weight.Text = pet.Weight.ToString();
                color.Text = pet.Color;
                birth.Text = pet.Start.ToShortDateString();
                endDate.MinDate = pet.Start;
            }
        }
    }
}
