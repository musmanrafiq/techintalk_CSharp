using Microsoft.AspNetCore.Mvc;

namespace MVC_Controls.Controllers
{
    public class DropdownsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult InlineInView()
        {
            return View();
        }
    }
}
