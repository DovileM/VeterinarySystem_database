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
    public partial class ClinicInformation : Form
    {
        public ClinicInformation()
        {
            InitializeComponent();
        }

        private void ClinicInformation_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void choose_SelectedIndexChanged(object sender, EventArgs e)
        {
            int select = choose.SelectedIndex;
            switch (select)
            {
                case 1:
                    clearVisible();
                    seeVetLabels();
                    break;
                case 2:
                    clearVisible();

                    break;
                case 3:
                    clearVisible();
                    seeOwnerLabels();
                    break;
                case 4:
                    clearVisible();

                    break;
            }
        }

        private void seeVetLabels()
        {
            pCode.Visible = true;
            pCodeTextBox.Visible = true;
            fName.Visible = true;
            fNameText.Visible = true;
            sName.Visible = true;
            sNameText.Visible = true;
            phone.Visible = true;
            phoneText.Visible = true;
            startedAt.Visible = true;
            startedAtText.Visible = true;
            animals.Visible = true;
            animalText.Visible = true;
            seeAllAnimals.Visible = true;
        }
        
        private void seeOwnerLabels()
        {
            chooseLabel.Visible = true;
            animalComboBox.Visible = true;
            pCodeLabel.Visible = true;
            gifLabel.Visible = true;
            fName.Visible = true;
            fNameText.Visible = true;
            sName.Visible = true;
            sNameText.Visible = true;
            phone.Visible = true;
            phoneText.Visible = true;
            startedAt.Visible = true;
        }

        private void clearVisible()
        {
            pCode.Visible = false;
            pCodeTextBox.Visible = false;
            fName.Visible = false;
            fNameText.Visible = false;
            sName.Visible = false;
            sNameText.Visible = false;
            phone.Visible = false;
            phoneText.Visible = false;
            startedAt.Visible = false;
            startedAtText.Visible = false;
            animals.Visible = false;
            animalText.Visible = false;
            seeAllAnimals.Visible = false;
            chooseLabel.Visible = false;
            animalComboBox.Visible = false;
            pCodeLabel.Visible = false;
            gifLabel.Visible = false;
        }
    }
}
