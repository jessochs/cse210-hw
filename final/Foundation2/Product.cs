using System;

public class Product 
{
    protected string _productName;
    protected string _productId;
    private float _price;
    private int _quantity;
    public Product(){}

    public Product(string productName, string productId, float price, int quantity)
    {
        _productName = productName;
        _productId = productId;
        _price = price;
        _quantity = quantity;
    }

    public float ComputePrice()
    {
        return _price * _quantity;
    }
}