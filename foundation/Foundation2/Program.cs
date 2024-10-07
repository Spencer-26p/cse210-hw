using System;

class Program
{
    static void Main(string[] args)
    {
        Random random = new Random();
        Order order1;
        Order order2;
        List<string> productsNames = new List<string>()
        {
            "tomato","CPU","milk","backscratcher","vitamin suplement", "poster"
        };
        List<Product> products = new List<Product>();
        for (int i = 0; i < 6; i++)
        {
            int nameNumber = random.Next(productsNames.Count);
            int id = random.Next(10000,99999);
            double price = Math.Round(5.00 + random.NextDouble() * (1000.00 - 5.00),2);
            int quantity = random.Next(1,20);
            Product product = new Product(productsNames[nameNumber],id,price,quantity);
            productsNames.Remove(productsNames[nameNumber]);
            products.Add(product);
        }
        List<Product> products1 = new List<Product>();
        for (int i = 0; i < 3; i++)
        {
            products1.Add(products[i]);
        }
        List<Product> products2 = new List<Product>();
        for (int i = 3; i < 6; i++)
        {
            products2.Add(products[i]);
        }
        order1 = new Order("Luke Skywalker","1529 Elkhill Drive","New York City","New York","USA",products1);
        order2 = new Order("Clark Kent","89436 Songbird Road","Dusseldorf","North Rhine-Westphalia","Germany",products2);
        Console.WriteLine($"Order 1:\n{order1.GetShippingLabel()}\n\n{order1.GetPackingLabel()}Price Total: ${order1.GetTotalCost()}\n");
        Console.WriteLine($"Order 2:\n{order2.GetShippingLabel()}\n\n{order2.GetPackingLabel()}Price Total: ${order2.GetTotalCost()}\n");
    }
}