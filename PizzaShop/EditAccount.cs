using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PizzaShop
{
    public partial class EditAccount : Form
    {
        public EditAccount()
        {
            InitializeComponent();
        }

        string user;

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void EditAccount_Load(object sender, EventArgs e)
        {

        }

        private void homeb_Click(object sender, EventArgs e)
        {
            Hide();
            Home h = new Home();
            h.Show();
        }

        private void cartb_Click(object sender, EventArgs e)
        {
            Hide();
            Cart c = new Cart();
            c.Show();
        }

        private void logoutb_Click(object sender, EventArgs e)
        {
            Hide();
            Title t = new Title();
            t.Show();
        }
    }
}
