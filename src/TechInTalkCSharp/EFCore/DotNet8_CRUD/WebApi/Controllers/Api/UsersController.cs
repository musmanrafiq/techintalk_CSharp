using Microsoft.AspNetCore.Mvc;
using WebApi.Data;
using WebApi.Models;
using WebApi.Services;

namespace WebApi.Controllers.Api
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {

        private readonly ILogger<HomeController> _logger;
        private readonly IUserService _userService;

        public UsersController(ILogger<HomeController> logger, IUserService userService)
        {
            _logger = logger;
            _userService = userService;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var results = _userService.GetUsers();
            var response = new { data = results, success = true, total = results.Count() };
            return Ok(response);
        }

        [HttpPost]
        public IActionResult Post([FromBody] UserModel model)
        {

            var userEntity = new UserEntity
            {
                Name = model.Name,
            };
            if (model.UserAdressModel is not null)
            {
                userEntity.UserAdressEntity = new UserAdressEntity
                {
                    AdressLine1 = model.UserAdressModel.AdressLine1,
                    AddressLine2 = model.UserAdressModel.AddressLine2
                };
            }
            var hasCreated = _userService.CreateUser(userEntity);
            if (!hasCreated)
            {
                return Ok("Unable to create a user");
            }
            return StatusCode(StatusCodes.Status201Created);
        }

        [HttpPut]
        public IActionResult Put([FromBody] UserModel model)
        {
            var userEntity = new UserEntity { Name = model.Name, Id = model.Id };
            // executing update for user
            var hasUpdated = _userService.UpdateUser(userEntity);
            if (!hasUpdated)
            {
                return Ok("Unable to update the user");
            }
            return Ok();
        }

        [HttpDelete]
        public IActionResult Delete([FromBody] int userId)
        {
            // executing delete for that user
            var hasDeleted = _userService.DeleteUser(userId);
            if (!hasDeleted)
            {
                return Ok("Unable to delete the user");
            }
            return Ok();
        }
    }
}
