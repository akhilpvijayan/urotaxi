using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using UroTaxi.Business.Services;
using UroTaxi.Entities;

namespace UroTaxi.Controllers
{
    public class Usercontroller : ControllerBase
    {
        #region Private Functions
        private readonly IUserservice _userService;
        private readonly ApplicationDBContext _applicationDbContext;
        #endregion

        #region Constructors
        public Usercontroller(
            IUserservice userService,
            ApplicationDBContext applicationDbContext)
        {
            _userService = userService;
            _applicationDbContext = applicationDbContext;
        }
        #endregion

        #region Public Functions
        [HttpGet]
        [Route("user")]
        [ProducesResponseType(typeof(User), 200)]
        [ProducesResponseType(404)]
        public Task<List<User>> GetAllUsers()
        {
            return _applicationDbContext.Users.Where(s => s.isActive == true).ToListAsync();
        }
        [HttpGet]
        [Route("user/drivers")]
        [ProducesResponseType(typeof(User), 200)]
        [ProducesResponseType(404)]
        public Task<List<User>> GetAllDrivers()
        {
            return _applicationDbContext.Users.Where(s => s.isActive == true && s.isDriver == true).ToListAsync();
        }
        [HttpGet]
        [Route("user/{userId}")]
        [ProducesResponseType(typeof(User), 200)]
        [ProducesResponseType(404)]
        public Task<List<User>> GetUser(int userId)
        {
            return _applicationDbContext.Users.Where(s => s.userId == userId).ToListAsync();
        }
        [HttpPost]
        [Route("user")]
        [ProducesResponseType(typeof(User), 200)]
        [ProducesResponseType(404)]
        public Task<int> AddUser([FromBody] User user)
        {
            return _userService.AddUser(user);
        }

        [HttpPut("user/restore/{id}")]
        [ProducesResponseType(typeof(User), 200)]
        [ProducesResponseType(404)]
        public async Task<IActionResult> RestoreUser(int id)
        {
            var uId = await _userService.RestoreUser(id);
            if (uId == 0)
            {
                return NotFound();
            }
            return Ok(uId);
        }

        [HttpDelete("user/{id}")]
        [ProducesResponseType(typeof(User), 200)]
        [ProducesResponseType(404)]
        public async Task<IActionResult> DeleteUser(int id)
        {
            var uId = await _userService.DeleteUser(id);
            if (uId == 0)
            {
                return NotFound();
            }
            return Ok(uId);
        }
        #endregion
    }
}
