using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using UroTaxi.Business.Services;
using UroTaxi.Entities;

namespace UroTaxi.Controllers
{
    [ApiController]
    public class CarModelController : ControllerBase
    {

        #region Private Functions
        private readonly ICityService _cityService;
        private readonly ApplicationDBContext _applicationDbContext;
        #endregion

        #region Constructors
        public CarModelController(
            ICityService cityService,
            ApplicationDBContext applicationDbContext)
        {
            _cityService = cityService;
            _applicationDbContext = applicationDbContext;
        }
        #endregion

        #region Public Functions
        [HttpGet]
        [Route("carmodel")]
        [ProducesResponseType(typeof(CarModel), 200)]
        [ProducesResponseType(404)]
        public Task<List<CarModel>> GetAllCarModels()
        {
            return _applicationDbContext.CarModels.ToListAsync();
        }

        [HttpGet]
        [Route("carmodel/{carTypeId}")]
        [ProducesResponseType(typeof(CarModel), 200)]
        [ProducesResponseType(404)]
        public Task<List<CarModel>> GetCarModels(int carTypeId)
        {
            return _applicationDbContext.CarModels.Where(s=>s.carType == carTypeId).ToListAsync();
        }
        #endregion
    }
}
