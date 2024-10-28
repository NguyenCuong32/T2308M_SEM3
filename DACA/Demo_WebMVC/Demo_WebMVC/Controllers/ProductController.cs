using Microsoft.AspNetCore.Mvc;

namespace Demo_WebMVC.Controllers
{
    public class ProductController : Controller
    {
        // GET: ProductController
        public ActionResult Index()
        {
            return View();
        }

    }
}
