using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PizzaShop
{
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();

            string readContents;
            using (StreamReader streamReader = new StreamReader(AppContext.BaseDirectory + "orders.txt"))
            {
                char[] key = { '$' };
                readContents = streamReader.ReadToEnd();
                string[] lines = readContents.Split(key, StringSplitOptions.RemoveEmptyEntries);
                checkedListBox1.Items.AddRange(lines);

            }

            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hide();
            EditAccount edit = new EditAccount();
            edit.Show();
        }
    }
}
