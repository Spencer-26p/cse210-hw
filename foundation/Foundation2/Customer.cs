class Customer
{
    private string _name;
    private Address _address;

    public Customer(string name, string address, string city, string province, string country)
    {
        _name = name;
        _address = new Address(address,city,province,country);
    }
    public Boolean GetInUsa()
    {
        return _address.GetUsa();
    }
    public string GetName()
    {
        return _name;
    }
    public string GetAddress()
    {
        return _address.GetAddress();
    }
}