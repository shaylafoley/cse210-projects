public class Product
{
    private string _name;
    private int _productID;
    private int _price;
    private int _quantity;

    public Product(string name, int productID, int price, int quantity)
    {
        _name = name;
        _productID = productID;
        _price = price;
        _quantity = quantity;
    }

    public int TotalCost()
    {
        return _quantity * _price;
    }
    public string GetProduct()
    {
        return _name;
    }
    public int GetID()
    {
        return _productID;
    }
}