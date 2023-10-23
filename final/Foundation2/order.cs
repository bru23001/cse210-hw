public class Order
{
    private List<Product> _products;
    private Customer _customer;
    private const decimal SHIPPING_COST_USA = 5;
    private const decimal SHIPPING_COST_INTERNATIONAL = 35;

    public Order(Customer customer)
    {
        _customer = customer;
        _products = new List<Product>();
    }

    public void AddProduct(Product product)
    {
        _products.Add(product);
    }

    public decimal GetTotalPrice()
    {
        decimal total = 0;
        foreach (Product product in _products)
        {
            total += product.GetPrice();
        }
        total += _customer.LivesInUSA() ? SHIPPING_COST_USA : SHIPPING_COST_INTERNATIONAL;
        return total;
    }
    public string GetPackingLabel()
    {
        string label = "Packing Label:\n";
        foreach (Product product in _products)
        {
            label += $"{product.GetName()} (ID: {product.GetProductId()})\n";
        }
        return label;
    }

    public string GetShippingLabel()
    {
        return $"Shipping Label:\n{_customer.GetName()}\n{_customer.GetAddress()}";
    }
}