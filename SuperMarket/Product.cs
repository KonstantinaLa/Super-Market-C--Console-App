namespace SuperMarket
{
    class Product
    {
        private string name;
        private decimal price;
        private decimal weight;

        public Product(string aName, decimal aPrice)
        {
            name = aName;
            price = aPrice;
        }

        public Product(string aName, decimal aPricePerWeight, decimal aWeight)
        {
            name = aName;
            price = aPricePerWeight;
            weight = aWeight;
        }
        
        public decimal FinalPrice()
        {
            return weight > 0 ? price * weight : price;
        }

        public string ProductSpecs()
        {   
            return weight > 0 ? $"Name: {name}\nPrice/kg: {price}\nWeight: {weight}" : $"Name: {name}\nPrice: {price}";
        }
    }
}
