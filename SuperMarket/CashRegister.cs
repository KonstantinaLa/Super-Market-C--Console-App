using System;
using System.Collections.Generic;

namespace SuperMarket
{
    class CashRegister
    {
        private decimal totalprice;
        private List<Product> productsList = new List<Product>();

        public void Scan(Product product)
        {
            productsList.Add(product);
            totalprice += product.FinalPrice();
        }

        public void Receipt()
        {
            for (int i = 0; i < productsList.Count; i++)
            {
                Console.WriteLine(productsList[i].ProductSpecs());
            }
            Console.WriteLine($"Total price is: {totalprice}");
        }
    }
}
