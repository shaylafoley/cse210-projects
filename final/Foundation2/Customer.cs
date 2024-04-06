public class Customer
{
    private string _name;
    private Address _address;
    public Customer(string name, Address address)
    {
        _name = name;
        _address = address;
    }

    public bool LiveInUSA()
    {
        return _address.FromUSA();
    }
    public string GetName()
    {
        return _name;
    }
    public string GetAddress()
    {
        return _address.ReturnAddress();
    }
}