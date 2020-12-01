namespace PizzaShop
{
    class PaymentInfo
    {
        bool credit;
        string cardNum;
        string expDate;
        string zip;
        string secCode;
        
        public bool checkValidity()
        {
            return true;
        }

    }
}