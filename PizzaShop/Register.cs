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
                User u = new User
                {
                    username = username.Text,
                    password = password.Text
                };

                if (File.Exists(AppContext.BaseDirectory + u.username + ".txt"))
                {
                    errorLabel.Text = "Username already taken.";
                }
                else
                    u.saveInfo();

                Home h = new Home();
                h.Show();
                Hide();
            }
            else
                errorLabel.Text = "Passwords don't match";
        }
    }
}
