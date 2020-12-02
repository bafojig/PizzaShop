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
    public partial class Home : Form
    {

        

        public Home()
        {

        }

        private void homePanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pizzab_Click(object sender, EventArgs e)
        {
            Hide();
            Size s = new Size();
            s.Show();
        }

        private void drinkb_Click(object sender, EventArgs e)
        {
            //go to drink menu
        }

        private void cartb_Click(object sender, EventArgs e)
        {
            //go to cart
        }

        private void logoutb_Click(object sender, EventArgs e)
        {
            //exit program
        }

        private void editb_Click(object sender, EventArgs e)
        {
            //go to edit account.
        }

        private void cartb_Click_1(object sender, EventArgs e)
        {

        }
    }
}
