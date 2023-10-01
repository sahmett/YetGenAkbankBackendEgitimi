using ProductTransportApp.Entities;
using ProductTransportApp.Services;

Product product1 = new Product("Product 1", 0.5m, 10.99m);
Product product2 = new Product("Product 2", 0.75m, 19.99m);
Product product3 = new Product("Product 3", 1.2m, 29.99m);
Product product4 = new Product("Product 4", 0.3m, 5.49m);

ShippingService sp = new ShippingService();

Console.WriteLine(sp.CalculateTax(product4, "Turkey"));