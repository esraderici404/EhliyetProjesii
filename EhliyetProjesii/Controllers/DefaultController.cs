using Microsoft.AspNetCore.Mvc;

namespace EhliyetProjesii.Controllers
{
    public class DefaultController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
