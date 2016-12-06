using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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

        private void PaintTablePets()
        {
            throw new NotImplementedException();
        }

        private void PaintTableOwners()
        {
            throw new NotImplementedException();
        }

        private void PaintTableVets()
        {

        }
    }
}
