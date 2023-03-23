using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using MVC_Controls.Models;

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

        public IActionResult ControlerToViewWithModel()
        {
            var customModel = new CustomModel
            {
                Countries = new List<CountryModel>
                {
                    new CountryModel { Name = "Pakistan", Id=1},
                    new CountryModel { Name = "United Kingdom", Id=2},
                    new CountryModel { Name= "USA", Id =3}
                },
                SelectedCountry = 2
                ,
            };

            return View(customModel);
        }

    }
}
