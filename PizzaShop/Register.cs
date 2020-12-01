using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace PizzaShop
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        string user;

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Register_Load(object sender, EventArgs e)
        {

        }

        private void rbutton_Click(object sender, EventArgs e)
        {
            if (password.Text == confirmbox.Text)
            {

                if (File.Exists(AppContext.BaseDirectory + username.Text + ".txt"))
                {
                    errorLabel.Text = "Username already taken.";
                }
                else
                {
                    Program.User.Username = username.Text;
                    Program.User.Password = password.Text;
                    Program.User.saveInfo();
                }

                Home h = new Home();
                h.Show();
                Hide();
            }
            else
                errorLabel.Text = "Passwords don't match";
        }
    }
}
