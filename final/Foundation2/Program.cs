using System;

class Program
{
    static void Main(string[] args)
    {
        Product product1 = new Product("Cheetos", "ID4832", 3.49f, 3);
        
    
        //i need to have attributes as protected and private, but how can i set them if they are not public??

        Product product2 = new Product("Mountain Dew", "ID5112", 1.99f, 2);
       

        Product product3 = new Product("Revlon Blow Dryer", "ID9988", 34.99f, 1);
        // product3._productName = "Revlon Blow Dryer";
        // product3._productId = "ID9988";
        // product3._price = 34.99f;
        // product3._quantity = 1;

        Product product4 = new Product("Conair Hair Brush", "ID9984", 5.99f, 1);
        // product4._productName = "Conair Hair Brush";
        // product4._productId = "ID9984";
        // product4._price = 5.99f;
        // product4._quantity = 1;

        Address address = new Address("4811 Gilbert Rd", "Gilbert", "AZ", "USA", "85269");
        Address address2 = new Address("5471 E Dobson Rd", "Mesa", "AZ", "Canada", "85050");
       

        Customer customer = new Customer("Haley Madsen", address);
        Customer customer2 = new Customer("Thomas Madsen", address2);
        
        

        Order order1 = new Order(customer);
        order1.AddProduct(product1);
        order1.AddProduct(product2);

        order1.ShippingLabel();
        order1.PackingLabel();
        Console.WriteLine(order1.Total());

        Order order2 = new Order(customer2);
        order2.AddProduct(product3);
        order2.AddProduct(product4);

        order2.ShippingLabel();
        order2.PackingLabel();
        Console.WriteLine(order2.Total());
    }
}