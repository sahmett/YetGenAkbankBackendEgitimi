// See https://aka.ms/new-console-template for more information
using DatabaseShopify.Contexts;
using DatabaseShopify.Entities;

Console.WriteLine("Hello, World!");

ShopifyDbContext _context = new();

#region add single
//Product product1 = new Product("Zippo Gold Lighter", 0.02m, 2000m);
//_context.Products.Add(product1);
#endregion

#region add multi
//List<Product> newProducts = new List<Product>
//            {
//                new Product("Zippo Gold Lighter", 0.02m, 2000m),
//                new Product("Smartphone", 0.2m, 1000m),
//                new Product("Wireless Headphones", 0.1m, 500m),
//                new Product("Laptop", 2m, 1500m),
//                new Product("Fitness Tracker", 0.05m, 100m),
//                new Product("Leather Wallet", 0.1m, 50m),
//                new Product("Coffee Mug", 0.5m, 20m),
//                new Product("Hiking Backpack", 1m, 80m),
//                new Product("Sunglasses", 0.1m, 150m),
//                new Product("Smart Watch", 0.08m, 300m)
//            };
//_context.Products.AddRange(newProducts);
#endregion
_context.SaveChanges();

#region read

List<Product> products = _context.Products.ToList();
List<Product> productsLinq = _context.Products.Where(x => x.Price <120).OrderBy(x => x.Price).ToList();

foreach (var product in productsLinq)
{
   // Console.WriteLine($"{product.Title}--{product.Price}");
}
#endregion

#region read single
Product product1 = _context.Products.Where(x => x.Title == "Wireless Headphones").FirstOrDefault();
Console.WriteLine($"{product1.Title}--{product1.Price}");

Product product2 = _context.Products.Where(x => x.Title.Contains("Zippo")).FirstOrDefault();
Console.WriteLine($"{product2.Title}--{product2.Price}");
#endregion