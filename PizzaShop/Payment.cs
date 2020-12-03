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
    public partial class Payment : Form
    {
        public Payment()
        {
            InitializeComponent();
            totalBox.Text = "" + Program.Order.getTotal();
        }

        

        private void homeb_Click(object sender, EventArgs e)
        {
            //go back home
            Hide();
            Home h = new Home();
            h.Show();
        }

        private void cartb_Click(object sender, EventArgs e)
        {
            //go back to cart
            Hide();
            Cart c = new Cart();
            c.Show();
        }

        private void logoutb_Click(object sender, EventArgs e)
        {
            //exit program
            Hide();
            Title t = new Title();
            t.Show();
        }

        private void placeOrderButton_Click(object sender, EventArgs e)
        {
            //place the order and show receipt, pass payment info to user to be saved

            if (ccBox.Text == "")
            {
                System.Windows.Forms.MessageBox.Show("Card Number is null");
            }
            if (monthBox.Text == "")
            {
                System.Windows.Forms.MessageBox.Show("Expiration month is null");
            }
            if (yearBox.Text == "")
            {
                System.Windows.Forms.MessageBox.Show("Expiration year is null");
            }
            if (ZipCodeBox.Text == "")
            {
                System.Windows.Forms.MessageBox.Show("Zipcode is null");
            }
            if (SecurityCode.Text == "")
            {
                System.Windows.Forms.MessageBox.Show("Security Code is null");
            }

            PaymentInfo pi = new PaymentInfo();
            
            pi.cardNum = ccBox.Text;
            pi.expDate = monthBox.Text + "/" + yearBox.Text;
            pi.zip = ZipCodeBox.Text;
            pi.secCode = SecurityCode.Text;

            if (checkButton.Checked)
                pi.method = "Check";
            else if (ccButton.Checked)
                pi.method = "Credit Card";
            else
                pi.method = "Debit Card";

            Program.User.Pi = pi;
            Program.User.saveInfo();

            string readContents;
            
            string path = AppContext.BaseDirectory + "orders.txt";
            if (!File.Exists(path))
            {
                // Create a file to write to.
                using (StreamWriter sw = File.CreateText(path))
                {
                    sw.Write(Program.Order.stringThis());
                }
                using (StreamReader streamReader = new StreamReader(AppContext.BaseDirectory + "orders.txt"))
                {
                    char[] key = { '$' };
                    readContents = streamReader.ReadToEnd();
                    string[] lines = readContents.Split(key, StringSplitOptions.RemoveEmptyEntries);
                    Program.Order.OrderNum1 = lines.Length;

                }
            }
            else
            {
                using (StreamReader streamReader = new StreamReader(AppContext.BaseDirectory + "orders.txt"))
                {
                    char[] key = { '$' };
                    readContents = streamReader.ReadToEnd();
                    string[] lines = readContents.Split(key, StringSplitOptions.RemoveEmptyEntries);
                    Program.Order.OrderNum1 = lines.Length;
                }


                using (StreamWriter sw = File.AppendText(path))
                {
                    sw.Write(Program.Order.stringThis());
                }
            }




                string payment = PaymentGroup.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked).Text;



            Hide();
            Receipt re = new Receipt();
            re.Show();

        }
    }
}
