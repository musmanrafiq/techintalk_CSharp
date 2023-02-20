using Microsoft.AspNetCore.Mvc;
using System.Text.Json.Serialization;

namespace PostFiles.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        [HttpPost]
        //[Consumes("multipart/form-data")]
        public IActionResult UploadLogo([FromForm]PostRequest model)
        {

            return Ok();
        }
    }

    public class PostRequest


    {



        public string Description { get; set; }


        public IFormFile Image { get; set; }



    }
}