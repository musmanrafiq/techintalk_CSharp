using Microsoft.AspNetCore.Mvc;
using WebApi.Data;

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
            _schoolDbContext.Add(new UserEntity { Name = "Usman" });
            _schoolDbContext.SaveChanges();

            return _schoolDbContext.Users.ToList();
        }
    }
}
