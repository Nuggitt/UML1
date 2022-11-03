

using System.Reflection.Metadata.Ecma335;

namespace PizzaStore
{
    public class Customers
    {
        //Instance fields
        private string _name;
        private string _adress;
        private string _phone;
        private string _email;

        //Constructor
        public Customers(string name, string adress, string phone)
        {
            _name = name;
            _adress = adress;
            _phone = phone;
        }

        public override string ToString()
        {
            string costumersMessage = "Pizza is ordered by " + _name + " Adress: " + _adress + "contact info: " + _phone;
            return costumersMessage;

        }
        //Properties
        public string Name
        {
            get { return _name; }
        }

        public string Adress
        {
            get { return _adress; }
        }

        public string Phone
        {
            get { return _phone; }
        }

        //methods.

    }
}
