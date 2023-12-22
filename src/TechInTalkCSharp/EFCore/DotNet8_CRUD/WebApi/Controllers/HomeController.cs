using Microsoft.AspNetCore.Mvc;
using WebApi.Data;
using WebApi.Models;

namespace WebApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class HomeController : ControllerBase
    {

        private readonly ILogger<HomeController> _logger;

        private readonly SchoolDbContext _schoolDbContext;

        public HomeController(ILogger<HomeController> logger, SchoolDbContext schoolDbContext)
        {
            _logger = logger;
            _schoolDbContext = schoolDbContext;
        }

        [HttpGet]
        public IEnumerable<object> Get()
        {
            return _schoolDbContext.Users.ToList();
        }

        [HttpPost]
        public IActionResult Post([FromBody] UserModel model)
        {
            var userEntity = new UserEntity { Name = model.Name };
            _schoolDbContext.Add(userEntity);
            _schoolDbContext.SaveChanges();
            return Created();
        }
    }
}
