using Microsoft.AspNetCore.Mvc;
using Productfy.Percistence.Context;
using Productify.Domain.Entitities;

namespace Productift.MVC.Train.Controllers
{
    public class ProductController : Controller
    {
        //     List<Product> _products = new() {
        //	new Product("Laptop"),
        //	new Product("Smartphone"),
        //	new Product("Headphones"),
        //	new Product("Monitor"),
        //	new Product("Keyboard")
        //};

        ProductifyDbContext _context;

        public ProductController() //const içinde newliyoruz
        {
            _context = new();
        }

		public IActionResult GetAll()
        {
            return View(_context.Products.ToList());
        }

		[HttpGet]
		public IActionResult AddProduct()
        {
            return View();
        }

		[HttpPost]
		public IActionResult AddProduct(string productName)
		{
            _context.Products.Add(new(productName));
            _context.SaveChanges();
			return View();
		}
	}
}
