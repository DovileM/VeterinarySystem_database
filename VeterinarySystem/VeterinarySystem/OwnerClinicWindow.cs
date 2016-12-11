using System;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Windows.Forms;

namespace VeterinarySystem
{
    public partial class OwnerClinicWindow : Form
    {
        private string _pCode;
        private int[] _petID;
        public OwnerClinicWindow(string type, string pCode)
        {
            InitializeComponent();
            _pCode = pCode;
            if (type.Equals("Clinic"))
                ShowClinicsInformation();
            else if (type.Equals("Pet"))
                ShowPetsInformation();
            else if (type.Equals("Vet"))
                ShowVetsInformation();
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ShowPetsInformation()
        {
            label.Text = "All pets' information:";
            string[] info = new string[] { "Name", "Type", "Specie", "Treatment start", "Treatment end", "Vet", "Clinic" };

            tableDataGridView.ColumnCount = info.Length;
            for (int i = 0; i < info.Length; i++)
            {
                tableDataGridView.Columns[i].Name = info[i];
            }

            using (VeterinaryEntities dataBase = new VeterinaryEntities())
            {
                var pets = (from pet in dataBase.Pets
                            join treat in dataBase.Treatments on pet.Id equals treat.Animal
                            join vet in dataBase.Vets on treat.Vet equals vet.PCode
                            where pet.Owner.Equals(_pCode)

                            select new
                            {
                                Clinic = vet.Clinic,
                                Name = pet.Name,
                                Type = pet.Type,
                                Species = pet.Species,
                                Start = treat.Start,
                                End = treat.End,
                                Vet = vet.Name + " " + vet.SurName,
                                Id = pet.Id
                            });

                var pets1 = dataBase.Pets.Where(p => p.Owner.Equals(_pCode)).Select(p => p);

                _petID = new int[pets1.ToList().Count];

                int i = 0;
                string[] petsNames = new string[pets.ToList().Count];
                foreach (var pet in pets)
                {
                    petsNames[i] = pet.Name;
                    tableDataGridView.Rows.Add();
                    tableDataGridView.Rows[i].Cells[0].Value = pet.Name;
                    tableDataGridView.Rows[i].Cells[1].Value = pet.Type;
                    tableDataGridView.Rows[i].Cells[2].Value = pet.Species;
                    tableDataGridView.Rows[i].Cells[3].Value = pet.Start.ToShortDateString();
                    if(string.IsNullOrEmpty(pet.End.Value.ToString()))
                        tableDataGridView.Rows[i].Cells[4].Value = null;
                    else
                        tableDataGridView.Rows[i].Cells[4].Value = pet.End.Value.ToShortDateString();
                    tableDataGridView.Rows[i].Cells[5].Value = pet.Vet;
                    tableDataGridView.Rows[i].Cells[6].Value = pet.Clinic;
                    _petID[i] = pet.Id;
                    i++;
                }

                int n = i;
                foreach (var pet in pets1)
                {
                    bool found = false;
                    for (int j = 0; j < petsNames.Length; j++)
                    {
                        if (pet.Name.Equals(petsNames[j]))
                        {
                            found = true;
                            break;
                        }
                    }
                    if (!found)
                    {
                        _petID[n] = pet.Id;
                        tableDataGridView.Rows.Add();
                        tableDataGridView.Rows[i].Cells[0].Value = pet.Name;
                        tableDataGridView.Rows[i].Cells[1].Value = pet.Type;
                        tableDataGridView.Rows[i].Cells[2].Value = pet.Species;
                        i++;
                        n++;
                    }
                }
            }
        }

        private void ShowClinicsInformation()
        {
            label.Text = "All clinics' information:";
            string[] info = new string[] { "Clinic name", "City", "Adress", "Phone", "Vets" };

            tableDataGridView.ColumnCount = info.Length;
            for (int i = 0; i < info.Length; i++)
            {
                tableDataGridView.Columns[i].Name = info[i];
            }

            using (VeterinaryEntities dataBase = new VeterinaryEntities())
            {
                var clinics = dataBase.Clinics.Select(c => new
                {
                    Name = c.Name,
                    Phone = c.Phone,
                    City = c.City,
                    Adress = c.Street + " g. " + c.No,
                    Vets = dataBase.Vets.Where(v => v.Clinic.Equals(c.Name)).Select(v => v).Count()
                }).OrderBy(c => c.City);

                int i = 0;
                foreach (var clinic in clinics)
                {
                    tableDataGridView.Rows.Add();
                    tableDataGridView.Rows[i].Cells[0].Value = clinic.Name;
                    tableDataGridView.Rows[i].Cells[1].Value = clinic.City;
                    tableDataGridView.Rows[i].Cells[2].Value = clinic.Adress;
                    tableDataGridView.Rows[i].Cells[3].Value = clinic.Phone;
                    tableDataGridView.Rows[i].Cells[4].Value = clinic.Vets;
                    i++;
                }
            }
        }

        private void ShowVetsInformation()
        {
            label.Text = $"All clinic:{_pCode} vets' information:";
            string[] info = new string[] { "Name", "Surname", "Experience", "Phone", "Treated pets" };

            tableDataGridView.ColumnCount = info.Length;
            for (int i = 0; i < info.Length; i++)
            {
                tableDataGridView.Columns[i].Name = info[i];
            }

            using (VeterinaryEntities dataBase = new VeterinaryEntities())
            {
                var vets = dataBase.Vets.Where(v => v.Clinic.Equals(_pCode)).Select(v => new
                {
                    Name = v.Name,
                    SurName = v.SurName,
                    Phone = v.Phone,
                    Experience = v.StartedAt,
                    Pets = dataBase.Treatments.Where(s => s.Vet.Equals(v.PCode)).Count()
                }).OrderBy(v => v.Experience);

                int i = 0;
                foreach (var vet in vets)
                {
                    tableDataGridView.Rows.Add();
                    tableDataGridView.Rows[i].Cells[0].Value = vet.Name;
                    tableDataGridView.Rows[i].Cells[1].Value = vet.SurName;
                    if (string.IsNullOrEmpty(vet.Experience.ToString()))
                        tableDataGridView.Rows[i].Cells[2].Value = null;
                    else
                        tableDataGridView.Rows[i].Cells[2].Value = (DateTime.Today.Year - vet.Experience.Value.Year) + " years"; ;
                    tableDataGridView.Rows[i].Cells[3].Value = vet.Phone;
                    tableDataGridView.Rows[i].Cells[4].Value = vet.Pets;
                    i++;
                }
            }
        }

        private void tableDataGridView_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            UpdateDeleteWindow update_delete = new UpdateDeleteWindow(_petID[e.RowIndex]);
            update_delete.Closed += UpdateDeleteWindow_IsClosed;
            update_delete.Show();
        }
        private void UpdateDeleteWindow_IsClosed(object sender, EventArgs e)
        {
            tableDataGridView.Rows.Clear();
            ShowPetsInformation();
        }
    }
}
