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
    public partial class Size : Form
    {
        public Size()
        {
            InitializeComponent();
        }

        public Pizza p = new Pizza();

        private void backBtn_Click(object sender, EventArgs e)
        {
            Hide();
            Home h = new Home();
            h.Show();
         
        }

        private void nextBtn_Click(object sender, EventArgs e)
        {
            
            bool anythingselected = false;
            foreach (RadioButton rd in Cheesebox.Controls.OfType<RadioButton>())
            {
                if (rd.Checked)
                {
                    anythingselected = true;
                    p.cheese = rd.Text;
                }
            }
            foreach (RadioButton rd in Crustbox.Controls.OfType<RadioButton>())
            {
                if (rd.Checked)
                {
                    anythingselected = true;
                    p.crust = rd.Text;
                }
            }
            foreach (RadioButton rd in Sizebox.Controls.OfType<RadioButton>())
            {
                if (rd.Checked)
                {
                    anythingselected = true;
                    p.size = rd.Text;
                }
            }

            if (anythingselected)
            {
                Hide();
                Toppings t = new Toppings(p);
                t.Show();
            }


        }
    }
}
