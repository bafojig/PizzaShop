namespace PizzaShop
{
    public class PaymentInfo
    {
        public string method;
        public string cardNum;
        public string expDate;
        public string zip;
        public string secCode;

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