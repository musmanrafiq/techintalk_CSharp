using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
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

        [HttpPut]
        public IActionResult Put([FromBody] UserModel model)
        {
            // executing update for user
            _schoolDbContext.Users.Where(x => x.Id == model.Id).ExecuteUpdate(x => x.SetProperty(u => u.Name, model.Name));

            return Ok();
        }
    }
}
