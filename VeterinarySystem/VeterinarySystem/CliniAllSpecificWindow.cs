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
    public partial class ClinicAllSpecificWindow : Form
    {
        private string _pCode;
        private string _clinic;

        public ClinicAllSpecificWindow(string clinic, string PCode, string type)
        {
            InitializeComponent();
            _clinic = clinic;
            _pCode = PCode;
            if (type.Equals("Owner"))
                ShowOwner();
            else if (type.Equals("Vet"))
                ShowVet();
        }

        private void ShowOwner()
        {
            string[] info = new string[] { "Name", "Type", "Species", "Birth", "Weight", "Color"};

            tableDataGridView.ColumnCount = info.Length;
            for (int i = 0; i < info.Length; i++)
            {
                tableDataGridView.Columns[i].Name = info[i];

            }

            using (VeterinaryEntities dataBase = new VeterinaryEntities())
            {
                var pets = (from pet in dataBase.Pets
                            join owner in dataBase.Owners on pet.Owner equals owner.PCode
                            join treat in dataBase.Treatments on pet.Id equals treat.Animal
                            join vet in dataBase.Vets on treat.Vet equals vet.PCode
                            where owner.PCode.Equals(_pCode)
                            select new
                            {
                                Clinic = vet.Clinic,
                                Name = pet.Name,
                                Type = pet.Type,
                                Species = pet.Species,
                                Birth = pet.Born,
                                Weight = pet.Weight,
                                Color = pet.Color,
                            }).Distinct();

                Trace.WriteLine(pets.ToList().Count);
                if (pets.ToList().Count == 1)
                {
                    Close();
                    MessageBox.Show("This owner do not have more pets.", "Sorry", MessageBoxButtons.OK);
                }
                else
                {
                    var ownerInfo = dataBase.Owners.Where(o => _pCode.Equals(o.PCode)).Select(o => new { Name = o.Name, Surname = o.SurName });

                    foreach (var owner in ownerInfo)
                        label.Text = $"{owner.Name} {owner.Surname}'s all pets' info:";

                    int i = 0;

                    foreach (var pet in pets)
                    {
                        tableDataGridView.Rows.Add();
                        tableDataGridView.Rows[i].Cells[0].Value = pet.Name;
                        tableDataGridView.Rows[i].Cells[1].Value = pet.Type;
                        tableDataGridView.Rows[i].Cells[2].Value = pet.Species;
                        if (string.IsNullOrEmpty(pet.Birth.ToString()))
                            tableDataGridView.Rows[i].Cells[3].Value = null;
                        else
                            tableDataGridView.Rows[i].Cells[3].Value = pet.Birth.Value.Date.ToShortDateString();

                        if (string.IsNullOrEmpty(pet.Weight.ToString()))
                            tableDataGridView.Rows[i].Cells[4].Value = null;
                        else
                            tableDataGridView.Rows[i].Cells[4].Value = pet.Weight + " kg.";
                        tableDataGridView.Rows[i].Cells[5].Value = pet.Color;

                        i++;
                    }
                }
            }
        }

        private void ShowVet()
        {
            string[] info = new string[] { "Name", "Owner name", "Type", "Species", "Birth", "Weight", "Color","Start", "End" };

            tableDataGridView.ColumnCount = info.Length;
            for (int i = 0; i < info.Length; i++)
            {
                tableDataGridView.Columns[i].Name = info[i];

            }
            using (VeterinaryEntities dataBase = new VeterinaryEntities())
            {
                var pets = (from pet in dataBase.Pets
                            join owner in dataBase.Owners on pet.Owner equals owner.PCode
                            join treat in dataBase.Treatments on pet.Id equals treat.Animal
                            join vet in dataBase.Vets on treat.Vet equals vet.PCode
                            where treat.Vet.Equals(_pCode)
                            select new
                            {
                                Clinic = vet.Clinic,
                                Name = pet.Name,
                                Owner = owner.Name + " " + owner.SurName,
                                Type = pet.Type,
                                Species = pet.Species,
                                Birth = pet.Born,
                                Weight = pet.Weight,
                                Color = pet.Color,
                                Start = treat.Start,
                                End = treat.End
                            }).OrderBy( p => p.Start);

                var vetInfo = dataBase.Vets.Where(v => _pCode.Equals(v.PCode)).Select(v => new { Name = v.Name, SurName = v.SurName });

                int i = 0;
                foreach (var vet in vetInfo)
                    label.Text = $"{vet.Name} {vet.SurName}'s treating pets' info:";

                foreach (var pet in pets)
                {
                    if (pet.Clinic.Equals(_clinic))
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

                        if (string.IsNullOrEmpty(pet.Weight.ToString()))
                            tableDataGridView.Rows[i].Cells[5].Value = null;
                        else
                            tableDataGridView.Rows[i].Cells[5].Value = pet.Weight + " kg.";
                        tableDataGridView.Rows[i].Cells[6].Value = pet.Color;
                        tableDataGridView.Rows[i].Cells[7].Value = pet.Start.Date.ToShortDateString();
                        tableDataGridView.Rows[i].Cells[8].Value = pet.End.Date.ToShortDateString();


                        i++;
                    }
                }
            }
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
