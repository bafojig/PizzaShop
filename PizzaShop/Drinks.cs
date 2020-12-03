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
    public partial class Drinks : Form
    {
        public Drinks()
        {
            InitializeComponent();
            
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void drinkBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void addCart_Click(object sender, EventArgs e)
        {

            string name = drinkBox.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked).Text;
            string size = SizeOptionGroup.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked).Text;
            double price;
            if (size == "Small")
                price = 1.75;
            else if (size == "Medium")
                price = 2.00;
            else price = 2.50;

            Item d = new Item();
            d.name = name;
            d.price = price;

            List<Item> i = new List<Item>();

            if (Program.Order.Items != null)
                i = Program.Order.Items;

            i.Add(d);

            Program.Order.Items = i;

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
