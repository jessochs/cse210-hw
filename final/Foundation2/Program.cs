using System;

class Program
{
    static void Main(string[] args)
    {
        Product product1 = new Product("Cheetos", "ID4832", 3.49f, 3);
        
    
        //i need to have attributes as protected and private, but how can i set them if they are not public??

        Product product2 = new Product("Mountain Dew", "ID5112", 1.99f, 2);
       

        // Product product3 = new Product("");
        // product3._productName = "Revlon Blow Dryer";
        // product3._productId = "ID9988";
        // product3._price = 34.99f;
        // product3._quantity = 1;

        // Product product4 = new Product();
        // product4._productName = "Conair Hair Brush";
        // product4._productId = "ID9984";
        // product4._price = 5.99f;
        // product4._quantity = 1;

        Address address = new Address("4811 Gilbert Rd", "Gilbert", "AZ", "USA", "85269");
       

        Customer customer = new Customer("Haley Madsen", address);
        
        

        Order order1 = new Order(customer);
        order1.AddProduct(product1);
        order1.AddProduct(product2);

        order1.ShippingLabel();
        order1.PackingLabel();
        Console.WriteLine(order1.Total());
    }
}