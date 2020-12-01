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

        public void saveInfo()
        {
            using (StreamWriter sw = File.CreateText(AppContext.BaseDirectory + username + ".txt"))
            {
                sw.WriteLine(username);
                sw.WriteLine(password);
                sw.WriteLine(address.ToString());
                sw.WriteLine(pi);
                sw.WriteLine(admin);
            }
        }

        public void loadInfo()
        {
            
        }
        public void dailyReport(string d)
        {

        }
   

    }
}
