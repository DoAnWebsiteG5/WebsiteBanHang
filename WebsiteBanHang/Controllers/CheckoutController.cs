using Microsoft.AspNetCore.Mvc;
using WebsiteBanHang.Data;
using WebsiteBanHang.Infrastructure;
using WebsiteBanHang.Models;

namespace WebsiteBanHang.Controllers
{
    public class CheckoutController : Controller
    {
        public Checkout? checkout { get; set; }
        private readonly ApplicationDbContext _context;

        public CheckoutController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View("Cart", HttpContext.Session.GetJson<Cart>("cart"));
        }

        public IActionResult Checkout(int productId)
        {
            Product? product = _context.Products.FirstOrDefault(p => p.ProductId == productId);
            if (product != null)
            {
                checkout = HttpContext.Session.GetJson<Checkout>("checkout") ?? new Checkout();
                checkout.AddItem(product, 1);
                HttpContext.Session.SetJson("checkout", checkout);
            }
            return View("Checkout", checkout);
        }

    }
}
