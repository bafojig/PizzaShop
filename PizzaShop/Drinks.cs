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
    public partial class Address : Form
    {
        public Address()
        {
            InitializeComponent(); 
            string[] drinks = { "Coke", "Coke Zero", "Sprite", "Dr. Pepper" };
            drinkBox.Items.AddRange(drinks);
        }

        string user;

        private void backbutton_Click(object sender, EventArgs e)
        {
            Hide();
            Size s = new Size();
            s.p = p;
        }

        private void addCart_Click(object sender, EventArgs e)
        {
            List<string> drinks = new List<string>();
            foreach (string s in drinkBox.CheckedItems)
            {
                Item i = new Item();
                i.name = s;
                i.price = 2.00;
                Program.Order.items.Add(i);
            }
            Hide();
            Cart c = new Cart();
            c.Show();
        }

        private void drinkBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
