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
    public partial class LogInWindow : Form
    {
        private string _username;
        private string _password;
        public LogInWindow()
        {
            InitializeComponent();
        }

        private void LogInWindow_Load(object sender, EventArgs e)
        {
            name.Leave += GetUsername;
            pass.Leave += GetPassword;
        }

        private void GetUsername(object sender, EventArgs e)
        {
            _username = (sender as TextBox).Text;
        }
        private void GetPassword(object sender, EventArgs e)
        {
            _password = (sender as TextBox).Text;
        }

        private void loginbutton_Click(object sender, EventArgs e)
        {

        }

        private void signUpButton_Click(object sender, EventArgs e)
        {
            SignUpWindow signUp = new SignUpWindow();
            signUp.Show();
        }


    }
}
