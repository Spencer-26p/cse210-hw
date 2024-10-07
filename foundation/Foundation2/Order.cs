using System.Numerics;

class Order
{
    private Customer _customer;
    private List<Product> _products = new List<Product>();

    public Order(string name, string address, string city, string province, string country, List<Product> products)
    {
        _customer = new Customer(name, address, city, province, country);
        for (int i = 0; i < products.Count; i++)
        {
            _products.Add(products[i]);
        }
    }
    public double GetTotalCost()
    {
        double total = 0.00;
        foreach (Product product in _products)
        {
            total += product.GetCost();
        }
        total += GetShipping();
        return Math.Round(total,2);
    }
    private double GetShipping()
    {
        if (_customer.GetInUsa())
        {
            return 5.00;
        }
        else
        {
            return 35.00;
        }
    }
    public string GetShippingLabel()
    {
         return _customer.GetName() + "\n" + _customer.GetAddress();
    }
    public string GetPackingLabel()
    {
        string productInfo = "";
        foreach (Product product in _products)
        {
            productInfo = String.Concat(productInfo,"Product: ", product.GetName(),";", " ID: ",product.GetId(),"\n");
        }
        return productInfo;
    }
}