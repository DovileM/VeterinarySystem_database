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
    public partial class ClinicAllInformationWindow : Form
    {
        private string _clinic;

        public ClinicAllInformationWindow(string name)
        {
            InitializeComponent();
            _clinic = name;
        }

        private void choose_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selected = choose.SelectedIndex;
            DeleteTable();
            switch (selected)
            {
                case 0:
                    PaintTableVets();
                    break;
                case 1:
                    PaintTableOwners();
                    break;
                case 2:
                    PaintTablePets();
                    break;
            }
        }

        private void DeleteTable()
        {
            tableDataGridView.DataSource = null;
            tableDataGridView.Rows.Clear();
        }

        private void PaintTablePets()
        {
            string[] info = new string[] { "Name", "Owner name", "Type", "Species", "Birth", "Weight", "Color" };

            tableDataGridView.ColumnCount = info.Length;
            for (int i = 0; i < info.Length; i++)
            {
                tableDataGridView.Columns[i].Name = info[i];

            }
            using (VeterinaryEntities dataBase = new VeterinaryEntities())
            {
                var pets = (from pet in dataBase.Pets
                                  join own in dataBase.Owners on pet.Owner equals own.PCode

                                  select new
                                  {
                                      Name = pet.Name,
                                      Owner = own.Name + " " + own.SurName,
                                      Type = pet.Type,
                                      Species = pet.Species,
                                      Birth = pet.Born,
                                      Weight = pet.Weight,
                                      Color = pet.Color
                                  });

                int i = 0;

                foreach (var pet in pets)
                {
                    tableDataGridView.Rows.Add();
                    tableDataGridView.Rows[i].Cells[0].Value = pet.Name;
                    tableDataGridView.Rows[i].Cells[1].Value = pet.Owner;
                    tableDataGridView.Rows[i].Cells[2].Value = pet.Type;
                    tableDataGridView.Rows[i].Cells[3].Value = pet.Species;
                    if (string.IsNullOrEmpty(pet.Birth.ToString()))
                        tableDataGridView.Rows[i].Cells[4].Value = null;
                    else
                        tableDataGridView.Rows[i].Cells[4].Value = pet.Birth.Value.Date.ToShortDateString();

                    if(string.IsNullOrEmpty(pet.Weight.ToString()))
                        tableDataGridView.Rows[i].Cells[5].Value = null;
                    else
                        tableDataGridView.Rows[i].Cells[5].Value = pet.Weight+" kg.";
                    tableDataGridView.Rows[i].Cells[6].Value = pet.Color;

                    i++;
                }
            }
        }

        private void PaintTableOwners()
        {
            string[] info = new string[] { "Personal code", "First name", "Second name", "Phone", "Pets"};

            tableDataGridView.ColumnCount = info.Length;
            for (int i = 0; i < info.Length; i++)
            {
                tableDataGridView.Columns[i].Name = info[i];

            }
            using (VeterinaryEntities dataBase = new VeterinaryEntities())
            {
                var ownersList = dataBase.Owners.ToList();
                var owners = ownersList.Select(o => new
                {
                    PCode = o.PCode,
                    Name = o.Name,
                    SurName = o.SurName,
                    Phone = o.Phone,
                    Pets = dataBase.Pets.Where(p => p.Owner.Equals(o.PCode)).Count()
                });

                int i = 0;
                foreach (var owner in owners)
                {
                    tableDataGridView.Rows.Add();
                    tableDataGridView.Rows[i].Cells[0].Value = owner.PCode;
                    tableDataGridView.Rows[i].Cells[1].Value = owner.Name;
                    tableDataGridView.Rows[i].Cells[2].Value = owner.SurName;
                    tableDataGridView.Rows[i].Cells[3].Value = owner.Phone;
                    tableDataGridView.Rows[i].Cells[4].Value = owner.Pets;
                    i++;
                }
            }
        }

        private void PaintTableVets()
        {
            string[] info = new string[] {"Personal code", "First name", "Second name", "Phone", "Experience", "Treating pets"} ;
            tableDataGridView.ColumnCount = info.Length;


            for (int i = 0; i < info.Length; i++)
            {
                tableDataGridView.Columns[i].Name = info[i];
            }

            using (VeterinaryEntities dataBase = new VeterinaryEntities())
            {
                var vetList = dataBase.Vets.ToList();
                    var vets = vetList.Where(v => v.Clinic.Equals(_clinic)).Select(v => new
                    {
                        PCode = v.PCode,
                        Name = v.Name,
                        SurName = v.SurName,
                        Phone = v.Phone,
                        Experience = v.StartedAt,
                        Pets = dataBase.Treatments.Where(s => s.Vet.Equals(v.PCode)).Count()
                    });

                int i = 0;
                foreach (var vet in vets)
                {
                    tableDataGridView.Rows.Add();
                    tableDataGridView.Rows[i].Cells[0].Value = vet.PCode;
                    tableDataGridView.Rows[i].Cells[1].Value = vet.Name;
                    tableDataGridView.Rows[i].Cells[2].Value = vet.SurName;
                    tableDataGridView.Rows[i].Cells[3].Value = vet.Phone;
                    if (string.IsNullOrEmpty(vet.Experience.ToString()))
                        tableDataGridView.Rows[i].Cells[4].Value = null;
                    else
                        tableDataGridView.Rows[i].Cells[4].Value = (DateTime.Today.Year - vet.Experience.Value.Year) +" years";
                    tableDataGridView.Rows[i].Cells[5].Value = vet.Pets;
                    i++;
                }
            }



        }

        private void cancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
