using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Caching.Distributed;
using System.Text.Json;
using System.Text;
using UroTaxi.Business.Services;
using UroTaxi.Business.Services.Dto;
using UroTaxi.Business.Services.Services;
using UroTaxi.Entities;
using UroTaxi.Business.Entities;

namespace UroTaxi.Controllers
{
    public class Usercontroller : ControllerBase
    {
        #region Private Functions
        private readonly IUserservice _userService;
        private readonly ApplicationDBContext _applicationDbContext;
        private readonly IDistributedCache _cache;
        #endregion

        #region Constructors
        public Usercontroller(
            IUserservice userService,
            ApplicationDBContext applicationDbContext, IDistributedCache cache)
        {
            _userService = userService;
            _applicationDbContext = applicationDbContext;
            _cache = cache;
        }
        #endregion

        #region Public Functions
        [HttpGet]
        [Route("user")]
        [ProducesResponseType(typeof(User), 200)]
        [ProducesResponseType(404)]
        public async Task<List<User>> GetAllUsers()
        {
            // Trying to get data from the Redis cache
            byte[] cachedData = await _cache.GetAsync("user");
            List<User> user = new();
            if (cachedData != null)
            {
                // If the data is found in the cache, encode and deserialize cached data.
                var cachedDataString = Encoding.UTF8.GetString(cachedData);
                user = JsonSerializer.Deserialize<List<User>>(cachedDataString);
            }
            else
            {
                // If the data is not found in the cache, then fetch data from database
                user = await _applicationDbContext.Users.Where(s => s.isActive == true).ToListAsync();

                // Serializing the data
                string cachedDataString = JsonSerializer.Serialize(user);
                var dataToCache = Encoding.UTF8.GetBytes(cachedDataString);

                // Setting up the cache options
                DistributedCacheEntryOptions options = new DistributedCacheEntryOptions()
                    .SetAbsoluteExpiration(DateTime.Now.AddMinutes(10))
                    .SetSlidingExpiration(TimeSpan.FromMinutes(10));

                // Add the data into the cache
                await _cache.SetAsync("user", dataToCache, options);
            }
            return user;
        }
        [HttpGet]
        [Route("user/drivers")]
        [ProducesResponseType(typeof(User), 200)]
        [ProducesResponseType(404)]
        public async Task<List<User>> GetAllDrivers()
        {
            // Trying to get data from the Redis cache
            byte[] cachedData = await _cache.GetAsync("driver");
            List<User> user = new();
            if (cachedData != null)
            {
                // If the data is found in the cache, encode and deserialize cached data.
                var cachedDataString = Encoding.UTF8.GetString(cachedData);
                user = JsonSerializer.Deserialize<List<User>>(cachedDataString);
            }
            else
            {
                // If the data is not found in the cache, then fetch data from database
                user = await _applicationDbContext.Users.Where(s => s.isActive == true && s.isDriver == true).ToListAsync();

                // Serializing the data
                string cachedDataString = JsonSerializer.Serialize(user);
                var dataToCache = Encoding.UTF8.GetBytes(cachedDataString);

                // Setting up the cache options
                DistributedCacheEntryOptions options = new DistributedCacheEntryOptions()
                    .SetAbsoluteExpiration(DateTime.Now.AddMinutes(10))
                    .SetSlidingExpiration(TimeSpan.FromMinutes(10));

                // Add the data into the cache
                await _cache.SetAsync("driver", dataToCache, options);
            }
            return user;
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
            if (user.isDriver)
            {
                _cache.RemoveAsync("driver");
            }
            _cache.RemoveAsync("user");
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
