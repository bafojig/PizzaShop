using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaShop
{
    class User
    {
        public string username;
        public string password;
        public string[] address;
        public PaymentInfo pi;
        public bool admin;

        public void editInfo()
        {
            
        }

        public void saveInfo()
        {
            using (StreamWriter sw = File.CreateText(AppContext.BaseDirectory + username + ".txt"))
            {
                sw.WriteLine(username);
                sw.WriteLine(password);
                sw.WriteLine(address);
                sw.WriteLine(pi);
                if (admin)
                    sw.WriteLine("Admin");
                else
                    sw.WriteLine("Not Admin");
            }
        }
        public void dailyReport(string d)
        {

        }

    }
}
