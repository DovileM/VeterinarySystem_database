using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace VeterinarySystem
{
    public partial class OwnerSeeInformationWindow : Form
    {
        private string _pCode;
        private int[] _petID;
        public OwnerSeeInformationWindow(string type, string pCode)
        {
            InitializeComponent();
            _pCode = pCode;
            top5.Visible = false;
            if (type.Equals("Clinic"))
                ShowClinicsInformation();
            else if (type.Equals("Pet"))
                ShowPetsInformation();
            else if (type.Equals("Vet"))
                ShowVetsInformation();
            else if (type.Equals("Vet patients"))
                ShowVetsPatientsInformation();
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
                            }).OrderBy(p => p.End);

                var pets1 = dataBase.Pets.Where(p => p.Owner.Equals(_pCode)).Select(p => p);

                _petID = new int[pets.ToList().Count+pets1.ToList().Count];

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
            tableDataGridView.Rows.Clear();
            top5.Visible = true;
            if (!top5.Checked)
                label.Text = "All clinics' information:";
            else
                label.Text = "Top5 clinics' information:";
            string[] info = new string[] { "Clinic name", "City", "Adress", "Phone", "Vets" };
                tableDataGridView.ColumnCount = info.Length;
                for (int i = 0; i < info.Length; i++)
                {
                    tableDataGridView.Columns[i].Name = info[i];
                }

                using (VeterinaryEntities dataBase = new VeterinaryEntities())
                {
                var clinics = (from c in dataBase.Clinics
                            join vet in dataBase.Vets on c.Name equals vet.Clinic
                            join treat in dataBase.Treatments on vet.PCode equals treat.Vet
                            select new
                            {
                                Name = c.Name,
                                Phone = c.Phone,
                                City = c.City,
                                Adress = c.Street + " g. " + c.No,
                                Vets = dataBase.Vets.Where(v => v.Clinic.Equals(c.Name)).Select(v => v).Count(),
                                Pets = dataBase.Treatments.Where(t => t.Vet.Equals(vet.PCode)).Count()
                            }).GroupBy(c => c.Name, (key, c) => c.FirstOrDefault());

                if (top5.Checked)
                    clinics = clinics.OrderBy(c => c.Pets).Take(4);
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

        private void ShowVetsPatientsInformation()
        {
            label.Text = "All pets' information:";
            string[] info = new string[] { "Name","Owner", "Type", "Specie","Age","Weight","Color", "Treatment start", "Treatment end" };

            tableDataGridView.ColumnCount = info.Length;
            for (int i = 0; i < info.Length; i++)
            {
                tableDataGridView.Columns[i].Name = info[i];
            }

            using (VeterinaryEntities dataBase = new VeterinaryEntities())
            {
                var pets = (from vet in dataBase.Vets
                            join treat in dataBase.Treatments on vet.PCode equals treat.Vet
                            join pet in dataBase.Pets on treat.Animal equals pet.Id
                            join owner in dataBase.Owners on pet.Owner equals owner.PCode
                            where vet.PCode.Equals(_pCode)

                            select new
                            {
                                Name = pet.Name,
                                Type = pet.Type,
                                Species = pet.Species,
                                Age = pet.Born,
                                Weight = pet.Weight,
                                Color = pet.Color,
                                Owner = owner.Name +" "+owner.SurName,
                                Start = treat.Start,
                                End = treat.End,
                            });

                int i = 0;
                foreach (var pet in pets)
                {
                    tableDataGridView.Rows.Add();
                    tableDataGridView.Rows[i].Cells[0].Value = pet.Name;
                    tableDataGridView.Rows[i].Cells[1].Value = pet.Owner;
                    tableDataGridView.Rows[i].Cells[2].Value = pet.Type;
                    tableDataGridView.Rows[i].Cells[3].Value = pet.Species;
                    if (pet.Age == null)
                        tableDataGridView.Rows[i].Cells[4].Value = null;
                    else
                        tableDataGridView.Rows[i].Cells[4].Value = (DateTime.Today.Year - pet.Age.Value.Year).ToString() + " years " +
                                                               (DateTime.Today.Month - pet.Age.Value.Month).ToString() + " months";
                    tableDataGridView.Rows[i].Cells[5].Value = pet.Weight;
                    tableDataGridView.Rows[i].Cells[6].Value = pet.Color;
                    tableDataGridView.Rows[i].Cells[7].Value = pet.Start.ToShortDateString();
                    if (string.IsNullOrEmpty(pet.End.Value.ToString()))
                        tableDataGridView.Rows[i].Cells[8].Value = null;
                    else
                        tableDataGridView.Rows[i].Cells[8].Value = pet.End.Value.ToShortDateString();
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

        private void top5_CheckedChanged(object sender, EventArgs e)
        {
            ShowClinicsInformation();
        }
    }
}
