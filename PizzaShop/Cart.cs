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
    public partial class Cart : Form
    {
        public Cart()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void homeb_Click(object sender, EventArgs e)
        {
            Hide();
            Home h = new Home();
        }

        private void logoutb_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void moreb_Click(object sender, EventArgs e)
        {
            Hide();
            Home h = new Home();
        }

        private void cob_Click(object sender, EventArgs e)
        {

        }
    }
}
