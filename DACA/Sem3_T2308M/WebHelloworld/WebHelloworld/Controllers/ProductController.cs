using Microsoft.AspNetCore.Mvc;

namespace WebHelloworld.Controllers
{
    [Route("/ourproduct")]
    public class ProductController : Controller
    {
        [Route("")]
        public IActionResult Index()
        {
            return View();
        }
        [Route("detailproduct")]
        public IActionResult Detail()
        {
            return View();
        }
    }
}
