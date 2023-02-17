using Microsoft.AspNetCore.Mvc;

namespace Routing.Controllers
{
    public class ProductsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [Route("List")]
        public IActionResult List()
        {
            return View();
        }

        [Route("Details/{id}")]
        public IActionResult Details(int id)
        {
            return View();
        }
    }
}
