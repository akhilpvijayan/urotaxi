using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using UroTaxi.Business.Services;
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
            return _applicationDbContext.City.ToListAsync();
        }
        #endregion
    }
}
