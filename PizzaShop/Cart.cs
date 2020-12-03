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
            string s = "";
            double total;
            foreach (Item i in Program.Order.Items)
            {
                s = s + "\n" + i.name + "..." + i.price; 
                
            }


            cartList.Text = s;
            

        }


        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void homeb_Click(object sender, EventArgs e)
        {



            Hide();
            Home h = new Home();
            h.Show();
        }

        private void logoutb_Click(object sender, EventArgs e)
        {

        }

        private void moreb_Click(object sender, EventArgs e)
        {

        }

        private void cob_Click(object sender, EventArgs e)
        {

        }
    }
}
