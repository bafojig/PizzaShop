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
            InitializeComponent();
        }

        private void homePanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pizzab_Click(object sender, EventArgs e)
        {
            //NOT WORKING
        }

        private void drinkb_Click(object sender, EventArgs e)
        {
            //NOT WORKING
        }

        private void cartb_Click(object sender, EventArgs e)
        {
            //go to cart NOT WORKING
        }

        private void logoutb_Click(object sender, EventArgs e)
        {
            //exit program NOT WORKING
        }

        private void editb_Click(object sender, EventArgs e)
        {
            //go to edit account. NOT WORKING
        }

        private void pizzab_Click_1(object sender, EventArgs e)
        {

            Hide();
            Size s = new Size();
            s.Show();
        }

        private void drinkb_Click_1(object sender, EventArgs e)
        {
            Hide();
            Drinks d = new Drinks();
            d.Show();
        }

        private void cartb_Click_1(object sender, EventArgs e)
        {
            Hide();
            Cart c = new Cart();
            c.Show();
        }

        private void logoutb_Click_1(object sender, EventArgs e)
        {
            Hide();
            Title t = new Title();
            t.Show();
        }

        private void editb_Click_1(object sender, EventArgs e)
        {
            Hide();
            EditAccount ea = new EditAccount();
            ea.Show();
        }
    }
}
