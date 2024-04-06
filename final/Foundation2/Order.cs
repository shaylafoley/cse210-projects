using System.Reflection.Metadata.Ecma335;
using Microsoft.VisualBasic;

public class Order
{
    private Customer customer;
    List<Product> _products;

    public Order(Customer customer)
    {
        this.customer = customer;
        _products = new List<Product>();
    }
    public void AddProduct(Product product)
    {
        _products.Add(product);
    }
    public decimal TotalPrice()
    {
        decimal total = _products.Sum(product => product.TotalCost());
        decimal shipping = customer.LiveInUSA() ? 5 : 35;
        return total + shipping;
    }
    public string GetPackingLabel()
    {
        string packingLabel = "";
        foreach (var product in _products)
        {
            packingLabel += $"Name: {product.GetProduct()} Product ID {product.GetID()}\n";
            
        }
        return packingLabel;
    }
    public string GetShippingLabel()
    {
        return $"Name: {customer.GetName()} \n{customer.GetAddress()}";
    }
    
}
