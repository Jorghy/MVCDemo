using Microsoft.AspNetCore.Mvc;

namespace MVCDemo.Controllers
{
    public class MovieListController : Controller
    {
        //GET: /HelloWorld/
        public IActionResult Index()
        {
            return View();
        }

        //GET: /HelloWorld/Welcome/
        public IActionResult Welcome()
        {
            return View();
        }
    }
}
