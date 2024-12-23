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
        [HttpGet()]
        [Route("list")]
        public IActionResult Get()
        {
            try
            {
                var rsp = _userService.GetAll();

                return Ok(rsp);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut()]
        public IActionResult Update(User user)
        {
            try
            {
              _userService.update(user);

                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpDelete("{id:Guid}")]
        public IActionResult Remove(Guid id)
        {
            try
            {
                _userService.Delete(id);

                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }


        //[HttpGet]
        //public IActionResult Get(string email) {
        //    try
        //    {
        //        //_userService.Get(email);

        //        return Ok();
        //    }
        //    catch (Exception ex)
        //    {
        //        return BadRequest(ex.Message);
        //    }
        //}
    }
}
