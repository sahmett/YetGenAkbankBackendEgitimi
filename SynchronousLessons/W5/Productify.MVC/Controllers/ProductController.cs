using Microsoft.AspNetCore.Mvc;

namespace Productify.MVC.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult AddProduct()
        {
            return View();
        }

        public IActionResult GetAll()
        {
            return View();
        }
    }
}
