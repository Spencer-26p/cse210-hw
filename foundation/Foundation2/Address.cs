class Address 
{
    private string _address;
    private string _city;
    private string _province;
    private string _country;

    public Address(string address, string city, string province, string country)
    {
        _address = address;
        _city = city;
        _province = province;
        _country = country;
    }
    public Boolean GetUsa()
    {
        if (_country == "USA")
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    public string GetAddress()
    {
        return _address + "\n" + _city + "," + _province + "\n" + _country; 
    }
}