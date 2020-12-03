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
    public partial class CheckOut : Form
    {
        public CheckOut()
        {
            InitializeComponent();
            
        }

        string user;


        private void CheckOut_Load(object sender, EventArgs e)
        {

        }

        private void homeb_Click(object sender, EventArgs e)
        {
            Hide();
            Home h = new Home();
            h.Show();
        }

        private void cartb_Click(object sender, EventArgs e)
        {
            Hide();
            Cart c = new Cart();
            c.Show();
        }

        private void logoutb_Click(object sender, EventArgs e)
        {
            Hide();
            Title t = new Title();
            t.Show();
        }

        private void toPayment_Click(object sender, EventArgs e)
        {
            if (streetText.Text == "")
            {
                System.Windows.Forms.MessageBox.Show("Street is null");
            }
            if (zipText.Text == "")
            {
                System.Windows.Forms.MessageBox.Show("Zipcode is null");
            }
            if (cityText.Text == "")
            {
                System.Windows.Forms.MessageBox.Show("City is null");
            }
            if (stateText.Text == "")
            {
                System.Windows.Forms.MessageBox.Show("State is null");
            }
            string delcar = DelcarGroupBox.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked).Text;
        }
    }
}
