using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace Sandwich_Shop
{
    public partial class LoginForm : Form
    {
        public UserData UserData = new UserData();

        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            if ((UsernameTextBox.Text == UserData.userName) && (PasswordTextBox.Text == UserData.Password))
            {
                this.Hide();
                MainForm mainForm = new MainForm();
                mainForm.Show();


            }

            else
            {
                MessageBox.Show("Wrong Username or Password");
            }
        }
    }
}
