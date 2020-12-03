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

        public Pizza pizza;
        public double price;
        public string name;

        public Toppings(Pizza p)
        {
            InitializeComponent();
            string[] meats = { "Pepperoni", "Bacon", "Anchovies", "Ham" };
            string[] veggies = { "Mushrooms", "Spinach", "Green Olives", "Pineapple" };
            meatBox.Items.AddRange(meats);
            vegBox.Items.AddRange(veggies);
            pizza = p;
        }

        

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
            

            pizza.toppings = tops;

            if (pizza.size == "Small")
                price = 5.00;
            else if (pizza.size == "Medium")
                price = 7.00;
            else if (pizza.size == "Large")
                price = 10.00;
            else
                price = 12.00;

            pizza.price = price + (pizza.toppings.Count * .50);

            string toppings = "";
            foreach (string s in pizza.toppings)
            {
                toppings = toppings + ", " + s;
            }

            name = pizza.size + pizza.crust + " with " + pizza.cheese + " with " + toppings;

            pizza.name = name;
            
            List<Item> i = new List<Item>();

            if (Program.Order.Items != null)
                i = Program.Order.Items;

            i.Add(pizza);

            Program.Order.Items = i;
            
            Hide();
            Cart c = new Cart();
            c.Show();
        }

        private void backbutton_Click(object sender, EventArgs e)
        {
            Hide();
            Size s = new Size();
            s.p = pizza;
        }

        private void meatBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
