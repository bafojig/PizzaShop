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
    public partial class Payment : Form
    {
        public Payment()
        {
            InitializeComponent();
        }

        //put order total in totalBox

        private void homeb_Click(object sender, EventArgs e)
        {
            //go back home
        }

        private void cartb_Click(object sender, EventArgs e)
        {
            //go back to cart
        }

        private void logoutb_Click(object sender, EventArgs e)
        {
            //exit program
        }

        private void placeOrderButton_Click(object sender, EventArgs e)
        {
            //place the order and show receipt, pass payment info to user to be saved
        }
    }
}
