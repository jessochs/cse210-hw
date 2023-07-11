using System;

public class Order
{
    private List<Product> _products = new List<Product>();

    private Customer customer1 = new Customer();

    public void AddProduct(Product product)
    {
        _products.Add(product);
    }

    public Order(Customer customer)
    {
        customer1 = customer;
    }

    private float ShippingCost()
    {
        if  (customer1.Address.ComputeCountry())
        {
            return 5.0f;
        }
        else{
            return 35.0f;
        }
    }
    

    public float Total()
    {
        float totalPrice = 0;

        foreach(Product p in _products)
        {
            totalPrice+= p.Price * p.Quantity;
        }
        totalPrice += ShippingCost();
        return totalPrice;
    }
    
    public void PackingLabel()
    {
        foreach(Product p in _products)
        {
            Console.WriteLine($"{p.ProductName}: {p.ProductId}");
        }
    }
    
    public void ShippingLabel()
    {
        customer1.DisplayCustomer();
    }

}