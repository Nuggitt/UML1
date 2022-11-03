
namespace PizzaStore
{
    public class MenuCard
    {
        //instance fields
        private string _pizzaName;
        private string _pizzaNumber;
        private int _pizzaPrice;
        
        //Constructor
        public MenuCard(string pizzaName, string pizzaNumber, 
            int pizzaPrice)
        {
            _pizzaName = pizzaName;
            _pizzaNumber = pizzaNumber;
            _pizzaPrice = pizzaPrice;
        }

        public override string ToString()
        {
            string pizzaNameMessage = "#:" + _pizzaNumber + _pizzaName + "--Price: " + _pizzaPrice + "kr ";
            return pizzaNameMessage;
        }   

        //Properties
        public string PizzaName
        {
            get { return _pizzaName; }
        }
        public string PizzaNumber
        {
            get { return _pizzaNumber; } 
        }
        public int PizzaPrice
        {
            get { return _pizzaPrice; }
        }

        //methods

    }
}
