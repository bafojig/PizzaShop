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
    public partial class Toppings : Form
    {
        public Toppings()
        {
            InitializeComponent();
            string[] meats = { "Pepperoni", "Bacon", "Anchovies", "Ham" };
            string[] veggies = { "Mushrooms", "Spinach", "Green Olives", "Pineapple" };

            vegBox.Items.AddRange(veggies);
            meatBox.Items.AddRange(meats);
        }

        public Pizza p;

        private void addCart_Click(object sender, EventArgs e)
        {
            List<string> tops = new List<string>();
            foreach (string s in meatBox.CheckedItems)
            {
                tops.Add(s);
            }
            foreach (string s in vegBox.CheckedItems)
            {
                tops.Add(s);
            }

            p.toppings = tops;
            p.name = p.size + " " + "pizza with " + p.toppings.ToString();
            Program.Order.items.Add(p);
            Hide();
            Cart c = new Cart();
            c.Show();
        }

        private void backbutton_Click(object sender, EventArgs e)
        {
            Hide();
            Size s = new Size();
            s.p = p;
        }

        private void meatBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
