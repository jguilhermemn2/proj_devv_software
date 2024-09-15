using api.Model;
using api.Service.UserService;
using Microsoft.AspNetCore.Mvc;

namespace api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]

    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;
        private readonly ILogger<UserController> logger;

        public UserController(IUserService userService, ILogger<UserController> logger)
        {
            _userService = userService;
            this.logger = logger;
        }

        [HttpPost]
        public IActionResult Save(User user)
        {
            try
            {

                logger.LogInformation("save");
                _userService.Save(user);

                logger.LogInformation("########################################## save complete ########################################## ");
                return Ok();
            }
            catch (Exception ex)
            {
                logger.LogError(ex.Message);
                return BadRequest(ex.Message);
            }
        }

        [HttpGet]
        public IActionResult Get(string email) {
            try
            {
                //_userService.Get(email);

                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
