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
    public partial class Receipt : Form
    {
        public Receipt()
        {
            InitializeComponent();
        }

        //fill in rcptBox with info from the order.

        private void homeb_Click(object sender, EventArgs e)
        {
            //go home 
            Hide();
            Home h = new Home();
            h.Show();
        }

        private void cartb_Click(object sender, EventArgs e)
        {
            //go to cart
            Hide();
            Cart c = new Cart();
            c.Show();
        }

        private void logoutb_Click(object sender, EventArgs e)
        {
            //exit program
            Hide();
            Title t = new Title();
            t.Show();
        }

        private void Receipt_Load(object sender, EventArgs e)
        {

        }
    }
}
