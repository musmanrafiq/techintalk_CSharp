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

        public IActionResult CascadingDropdown(int countryId)
        {
            var allCities = new List<CityModel>
                {
                    new CityModel { CountryId = 1, Name = "Islamabad", Id=1},
                    new CityModel { CountryId = 1,Name = "Karachi", Id=2},
                    new CityModel { CountryId = 2, Name = "London", Id=1},
                    new CityModel { CountryId = 2,Name = "Liverpool", Id=2},
                };

            var customModel = new CustomModel
            {
                Countries = new List<CountryModel>
                {
                    new CountryModel { Name = "Pakistan", Id = 1 },
                    new CountryModel { Name = "United Kingdom", Id = 2 },
                },
                Cities = allCities.Where(x => x.CountryId == countryId).ToList(),
                SelectedCountry = countryId,
                

            };

            return View(customModel);
        }

        public IActionResult CascadingDropdownWithAjax()
        {
            var customModel = new CustomModel
            {
                Countries = new List<CountryModel>
                {
                    new CountryModel { Name = "Pakistan", Id = 1 },
                    new CountryModel { Name = "United Kingdom", Id = 2 },
                },
                SelectedCountry = 0,
            };
            return View(customModel);
        }

        public IActionResult Cities(int countryId)
        {
            var allCities = new List<CityModel>
                {
                    new CityModel { CountryId = 1, Name = "Islamabad", Id=1},
                    new CityModel { CountryId = 1,Name = "Karachi", Id=2},
                    new CityModel { CountryId = 2, Name = "London", Id=1},
                    new CityModel { CountryId = 2,Name = "Liverpool", Id=2},
                };
            var selectedCities = allCities.Where(x => x.CountryId == countryId).ToList();
            return Json(selectedCities);
        }
    }
}
