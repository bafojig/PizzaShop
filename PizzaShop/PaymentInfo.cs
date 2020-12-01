namespace PizzaShop
{
    public class PaymentInfo
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

        public override string ToString()
        {
            return cardNum + "\n" + expDate + "\n" + zip + "\n" + secCode;
        }

    }
}