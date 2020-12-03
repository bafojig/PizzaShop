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
    public partial class Drinks : Form
    {
        public Drinks()
        {
            InitializeComponent();
            string[] drinks = { "Coke", "Coke Zero", "Sprite", "Dr. Pepper", "Diet Dr. Pepper" };
            drinkBox.Items.AddRange(drinks);
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void drinkBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void addCart_Click(object sender, EventArgs e)
        {
            List<string> drinks = new List<string>();
            Item i = new Item();
            i.price = 2.00;
            foreach (string s in drinkBox.CheckedItems)
            {
                i.name = s;
                Program.Order.items.Add(i);
            }
            Hide();
            Cart c = new Cart();
            c.Show();
        }

        private void backbutton_Click(object sender, EventArgs e)
        {
            Hide();
            Home h = new Home();
            h.Show();
        }
    }
}
