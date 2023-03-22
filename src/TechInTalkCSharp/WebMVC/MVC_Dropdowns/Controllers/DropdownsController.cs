using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

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

        public IActionResult ControlerToView()
        {
            var list = new List<SelectListItem>
            {
                new SelectListItem { Text = "Pakistan", Value="1"},
                new SelectListItem { Text = "United Kingdom", Value="2"},
                new SelectListItem { Text = "USA", Value="3"}
            };

            ViewBag.Countries = list;
            ViewData["ListOfCountries"] = list;
            return View();
        }
    }
}
