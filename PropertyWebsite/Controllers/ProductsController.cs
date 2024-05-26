using Microsoft.AspNetCore.Mvc;
using PropertyWebsite.Models;
using PropertyWebsite.Services;

namespace PropertyWebsite.Controllers
{
    public class ProductsController : Controller
    {
        private readonly ApplicationDbContext context;
        public ProductsController(ApplicationDbContext context)
        {
            this.context = context;
        }
        public IActionResult Index()
        {
            var products = context.Products.ToList();
            return View(products);
        }

        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(ProductDto productDto)
        {
            if (productDto.ImageFile == null)
            {
                ModelState.AddModelError("ImageFile", "the image file is required");
            }

            if (!ModelState.IsValid)
            {
                return View(productDto);
            }
            return View();
        }
    }
}
