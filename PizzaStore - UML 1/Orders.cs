
namespace PizzaStore
{
    public class Orders
    {//instance fields.
        private int _orderNumber;
        private Customers _customers; //Customers from their class.
        private MenuCard _pizza; //Pizza from their class.
        private int _deliveryFee;
        static private int _orderNumberCounter = 1;
        private double _totalPrice;
        private double _taxFee;
   

        public Orders(int ordernumber, Customers customers ,MenuCard pizzaName)
        {
            _customers = customers;
            _orderNumber = _orderNumberCounter ++;
            _pizza = pizzaName;
            _deliveryFee = 40;
            _taxFee = 1.25;

        }
        public override string ToString()
        {
            CalculateTotalPrice();
            string orderMessage = "\n" +_customers + "\nYour order number is "
                + _orderNumber + "\nYou've ordered: " + _pizza  + "\nThe total price inc delivery fee is " +_totalPrice + "kr";
                return orderMessage;

        }
        public Customers CustomerName
        {
            get { return CustomerName; }
        }

        public int OrderNumber
        {
            get { return _orderNumber; }
        }
        public string PizzaName
        {
            get { return _pizza.PizzaName; }
        }
        public int PizzaPrice
        {
            get { return _pizza.PizzaPrice; }
        }
 
        public double TotalPrice
        {
            get { return _totalPrice; }
        }

        public void CalculateTotalPrice()
        {
            _totalPrice = (_pizza.PizzaPrice * _taxFee) + _deliveryFee;
           
             
        }

    }
}
