﻿using System;
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

        public Toppings(Pizza p)
        {
            InitializeComponent();
            string[] meats = { "Pepperoni", "Bacon", "Anchovies", "Ham" };
            string[] veggies = { "Mushrooms", "Spinach", "Green Olives", "Pineapple" };
            pizza = p;

            vegBox.Items.AddRange(veggies);
            meatBox.Items.AddRange(meats);
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
            Program.Order.items.Add(pizza);
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
