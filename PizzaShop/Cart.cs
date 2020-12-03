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
            double d = 0 ;
            foreach(Item i in Program.Order.Items)
            {
                s = s + i.name + "...." + i.price.ToString() + "\n";
                d = d + i.price;
            }

            s = s + "/n/n" + "Subtotal:  " + d;
            
            richTextBox1.Text = s;
        }

        string user;


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
            Hide();
            Title t = new Title();
            t.Show();
        }

        private void moreb_Click(object sender, EventArgs e)
        {
            Hide();
            Home h = new Home();
            h.Show();
        }
    }
}
