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
    public partial class Title : Form
    {
        public Title()
        {
            InitializeComponent();
        }

        

        private void registerBtn_Click(object sender, EventArgs e)
        {
            Hide();
            Register r = new Register();
            r.Show();
            Console.Write("blah");
        }

        private void Title_Load(object sender, EventArgs e)
        {

        }

        private void registerBtn_Click_1(object sender, EventArgs e)
        {
            Hide();
            Register r = new Register();
            r.Show();
            Console.Write("blah");
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Hide();
            Login r = new Login();
            r.Show();
            
        }
    }
}
