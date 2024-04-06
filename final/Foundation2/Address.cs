public class Address
{
    private string _street;
    private string _city;
    private string _stateProvince;
    private string _country;

    public Address(string street, string city, string stateProvince, string country)
    {
        _street = street;
        _city = city;
        _stateProvince = stateProvince;
        _country = country;
    }

    public bool FromUSA()
    {
        return _country.Equals("USA", StringComparison.OrdinalIgnoreCase);
    }
    public string ReturnAddress()
    {
        return $"{_street} \n{_city}, {_stateProvince}, \n{_country}";
    }
}