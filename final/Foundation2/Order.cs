using System;

public class Order
{
    List<Product> products = new List<Product>();

    Customer customer1 = new Customer();
    Product product1 = new Product();
    private int shipping;

    public int ShippingCost()
    {
        
        

        if  (customer1.CustomerCountry == "USA")
        {
            shipping = 5;
        }
        else{
            shipping = 35;
        }

        return shipping;
    }
    

    public void Total()
    {
        int totalPrice = (price+=) + shipping;
    }
    
    public void PackingLabel()
    {
        foreach(Product p in products)
        {
            Console.WriteLine($"{productName}: {productId}");
        }
    }
    
    public void ShippingLabel()
    {
        customer1.DisplayCustomer();
    }

}