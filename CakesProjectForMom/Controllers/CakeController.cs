using Microsoft.AspNetCore.Mvc;

namespace CakesProjectForMom.Controllers
{
    public class CakeController : Controller
    {
        public IActionResult ListCakes()
        {



            return View();
        }

        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }
    }
}
