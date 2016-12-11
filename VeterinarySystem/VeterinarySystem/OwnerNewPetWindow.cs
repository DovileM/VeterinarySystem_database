using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VeterinarySystem
{
    public partial class OwnerNewPetWindow : Form
    {
        private string _pCode;
        public OwnerNewPetWindow(string pCode)
        {
            InitializeComponent();
            _pCode = pCode;
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ok_Click(object sender, EventArgs e)
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

                insert.Parameters.Add(new SqlParameter("@N", name.Text ));
                insert.Parameters.Add(new SqlParameter("@O", _pCode));
                insert.Parameters.Add(new SqlParameter("@T", type.Text));
                if(string.IsNullOrEmpty(species.Text))
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
                Trace.WriteLine(_pCode);
                Trace.WriteLine(name.Text + "_1_" + type.Text + "_2_" + species.Text + "_3_" + birth.Value.Date + "_4_" + weight.Text + "_5_" + color.Text);

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
}
