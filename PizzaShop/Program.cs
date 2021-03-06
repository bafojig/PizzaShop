﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PizzaShop
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        /// 

        
        public static class User
        {
            private static string username;
            private static string password;
            private static string[] address;
            private static PaymentInfo pi;
            private static bool admin;
          

            public static string Username { get => username; set => username = value; }
            public static string Password { get => password; set => password = value; }
            public static string[] Address { get => address; set => address = value; }
            public static PaymentInfo Pi { get => pi; set => pi = value; }
            public static bool Admin { get => admin; set => admin = value; }

            public static void saveInfo()
            {
                using (StreamWriter sw = File.CreateText(AppContext.BaseDirectory + Username + ".txt"))
                {
                    sw.WriteLine(Username);
                    sw.WriteLine(Password);
                    if (Address != null)
                    {
                        sw.WriteLine(Address.ToString());
                    }
                    sw.WriteLine(Pi);
                    sw.WriteLine(Admin);
                }
            }

            public static void loadInfo()
            {

            }
            public static void dailyReport(string d)
            {

            }

            
           
        }

        public static class Order
        {
            private static int OrderNum;
            private static double subtotal;
            private static double delFee;
            private static string signature;
            private static double price;

            public static int OrderNum1 { get => OrderNum; set => OrderNum = value; }
            public static string Date { get; set; }

            public static double Subtotal { get => subtotal; set => subtotal = value; }
            public static double DelFee { get => delFee; set => delFee = value; }
            public static string Signature { get => signature; set => signature = value; }
            public static List<Item> Items { get; set; }
            public static double Price { get => price; set => price = value; }

            public static double getTotal()
            {
                string s = "";
                double d = 0;
                double t;
                if (Order.Items != null)
                {
                    foreach (Item i in Program.Order.Items)
                    {

                        d = d + i.price;
                    }
                    t = d + (d * .07);



                    return t;
                }
                else return t = 0;
            }

            public static string stringThis()
            {
                return OrderNum + " " + Items[0].name + " plus more" + "..." + getTotal() + '$';
            }


        }

        
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Title());


        }
    }
}
