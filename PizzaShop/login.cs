using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PizzaShop
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void lbutton_Click(object sender, EventArgs e)
        {
            if (File.Exists(AppContext.BaseDirectory + username.Text + ".txt"))
            {
                using (StreamReader sr = new StreamReader(AppContext.BaseDirectory + username.Text + ".txt"))
                {
                    string un = sr.ReadLine();
                    string pw = sr.ReadLine();

                    if (un == username.Text && pw == password.Text)
                    {
                        Home h = new Home();
                        Hide();
                        h.Show();
                    }
                        
                }

            }
            else
            {
                Hide();
                Register r = new Register();
                r.Show();
            }


        }
    }
}
