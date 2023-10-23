using System;
using System.Collections.Generic;

public class Product
{
    private string _name;
    private int _productId;
    private decimal _price;
    private int _quantity;

    public Product(string name, int productId, decimal price, int quantity)
    {
        _name = name;
        _productId = productId;
        _price = price;
        _quantity = quantity;
    }

    public decimal GetPrice() => _price * _quantity;
    public string GetName() => _name;
    public int GetProductId() => _productId;
}