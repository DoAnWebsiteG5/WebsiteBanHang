using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using WebsiteBanHang.Data;
using WebsiteBanHang.Infrastructure;
using WebsiteBanHang.Models;

namespace WebsiteBanHang.Components
{
    public class CartWidget : ViewComponent
    {
       
        public IViewComponentResult Invoke()
        {
            return View(HttpContext.Session.GetJson<Cart>("cart"));
        }
    }
}
