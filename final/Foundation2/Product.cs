using System;

public class Product 
{
    private string _productName;
    private string _productId;
    private float _price;
    private int _quantity;
    private Product(){}

    public float Price{get{return _price;}}
    public string ProductName{get{return _productName;}}
    public string ProductId{get{return _productId;}}
    public int Quantity{get{return _quantity;}}

    public Product(string productName, string productId, float price, int quantity)
    {
        _productName = productName;
        _productId = productId;
        _price = price;
        _quantity = quantity;
    }

    public void AddProduct()
    {
        Console.WriteLine(_productName);
        Console.WriteLine(_productId);
        Console.WriteLine(_price);
        Console.WriteLine(_quantity);

    }

    public float ComputePrice()
    {
        return _price * _quantity;
    }
}