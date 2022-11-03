


namespace PizzaStore
{
    public class BigMammaPizza
    {
        //instance fields
        private string _name;
        private string _phone;
        private string _adress;

        public BigMammaPizza(string name, string phone, string adress)
        {
            _name = name;
            _phone = phone;
            _adress = adress;
        }

        public override string ToString()
        {
            string pizzaPlaceMessage = "Welcome to " + _name + "Our adress is " + _adress + "Contact information " + Phone;
            return pizzaPlaceMessage;
        }
        
        //Properties
        public string Name
        {
            get { return _name; }
        }
        public string Phone
        {
            get { return _phone; }
        }
        public string Adress
        {
            get { return _adress; }
        }
        //methods
        public void WelcomeMessage()
        {
            Console.WriteLine("Welcome to Big Mamma Pizza");
        }
    }

}
