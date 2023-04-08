using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using UroTaxi.Business.Services;
using UroTaxi.Business.Services.Services;
using UroTaxi.Entities;

namespace UroTaxi.Controllers
{
    [ApiController]
    public class CityController : ControllerBase
    {
        #region Private Functions
        private readonly ICityService _cityService;
        private readonly ApplicationDBContext _applicationDbContext;
        #endregion

        #region Constructors
        public CityController(
            ICityService cityService,
            ApplicationDBContext applicationDbContext)
        {
            _cityService = cityService;
            _applicationDbContext = applicationDbContext;
        }
        #endregion

        #region Public Functions
        [HttpGet]
        [Route("city")]
        [ProducesResponseType(typeof(City), 200)]
        [ProducesResponseType(404)]
        public Task<List<City>> GetAllCities()
        {
            return _applicationDbContext.City.Where(s => s.isActive == true).ToListAsync();
        }

        [HttpPost]
        [Route("city")]
        [ProducesResponseType(typeof(City), 200)]
        [ProducesResponseType(404)]
        public Task<int> AddCity([FromBody] City city)
        {
            return _cityService.AddCity(city);
        }

        [HttpPut("city/restore/{id}")]
        [ProducesResponseType(typeof(City), 200)]
        [ProducesResponseType(404)]
        public async Task<IActionResult> RestoreCity(int id)
        {
            var uId = await _cityService.RestoreCity(id);
            if (uId == 0)
            {
                return NotFound();
            }
            return Ok(uId);
        }

        [HttpDelete("city/{id}")]
        [ProducesResponseType(typeof(City), 200)]
        [ProducesResponseType(404)]
        public async Task<IActionResult> DeleteCity(int id)
        {
            var uId = await _cityService.DeleteCity(id);
            if (uId == 0)
            {
                return NotFound();
            }
            return Ok(uId);
        }
        #endregion
    }
}
