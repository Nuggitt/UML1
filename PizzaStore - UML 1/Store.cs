

namespace PizzaStore
{
    public class Store
    {
        public static void Start()
        {
            BigMammaPizza BigMammaPizza1 = new BigMammaPizza("Big Mamma Pizza ", "40 21 40 03",
    "Frederiksværkgade 4, 3400 Hillerrød");

            Console.WriteLine(BigMammaPizza1.ToString());

            MenuCard pizza1 = new MenuCard("Hawai ", "1 ", 85);
            MenuCard pizza2 = new MenuCard("Tropic Thunder ", "2 ", 80);
            MenuCard pizza3 = new MenuCard("Deadly Sea ", "2 ", 82);

            Customers customer1 = new Customers("Iben Hjele ", "Hillerødvej 2 ", "44 22 11 33");
            Customers customer2 = new Customers("Frank Hvam ", "Hillerødvej 3 ", "55 44 33 22");
            Customers customer3 = new Customers("Casper Christensen", "Hillerødvej 4 ", "66 33 22 44");

            Orders order1 = new Orders(0, customer1, pizza1);
            Orders order2 = new Orders(0, customer2, pizza2);
            Orders order3 = new Orders(0, customer3, pizza3);

            Console.WriteLine(order1.ToString());

            Console.WriteLine(order2.ToString());

            Console.WriteLine(order3.ToString());
        }
    }
}
