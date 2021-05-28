using System;

namespace SuperMarket
{
    class Program
    {
        static void Main(string[] args)
        {
            CashRegister register1 = new CashRegister();
            string input = "";
            do
            {
                Console.WriteLine("Please enter product name: ");
                string name = Console.ReadLine();

                Console.WriteLine("Please enter product price (or price/kg if weighted): ");
                decimal price = decimal.Parse(Console.ReadLine());

                Console.WriteLine("If weighted please enter weight, else type 0: ");
                decimal weight = decimal.Parse(Console.ReadLine());

                Product product = weight > 0 ? new Product(name, price, weight) : new Product(name, price);

                register1.Scan(product);

                Console.WriteLine("If you'd like to add another product, type 'add'. Else, type 'checkout':");
                input = Console.ReadLine();
                while (input != "add" && input != "checkout")
                {
                    Console.WriteLine("Please enter valid input: ");
                    input = Console.ReadLine();
                }
            }
            while (input == "add");

            register1.Receipt();

            Console.ReadKey();
        }
    }
}
