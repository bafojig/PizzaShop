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
            string s = "";
            double d = 0;
            double t;
            if (Program.Order.Items != null)
            {
                foreach (Item i in Program.Order.Items)
                {
                    s = s + i.name + "...." + i.price.ToString() + "\n";
                    d = d + i.price;
                }
                t = d + (d * .07);
                s = s + "\n\n" + "Subtotal:  " + d + "\nTax: " + "\nTotal: " + t;

                rcptBox.Text = s;
            }
        }

        //fill in rcptBox with info from the order.

        private void homeb_Click(object sender, EventArgs e)
        {
            //go home 
            Program.Order.Items = null;
            Hide();
            Home h = new Home();
            h.Show();
        }

        private void cartb_Click(object sender, EventArgs e)
        {
            //go to cart
            Program.Order.Items = null;
            Hide();
            Cart c = new Cart();
            c.Show();
        }

        private void logoutb_Click(object sender, EventArgs e)
        {
            //exit program
            Program.Order.Items = null;
            Hide();
            Title t = new Title();
            t.Show();
        }

        private void Receipt_Load(object sender, EventArgs e)
        {

        }
    }
}
