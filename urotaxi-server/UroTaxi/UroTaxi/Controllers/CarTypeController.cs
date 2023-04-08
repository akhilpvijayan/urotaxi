using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using UroTaxi.Business.Services;
using UroTaxi.Business.Services.Services;
using UroTaxi.Entities;

namespace UroTaxi.Controllers
{
    [ApiController]
    public class CarTypeController : ControllerBase
    {
        #region Private Functions
        private readonly ICarTypeService _carTypeService;
        private readonly ApplicationDBContext _applicationDbContext;
        #endregion

        #region Constructors
        public CarTypeController(
            ICarTypeService carTypeService,
            ApplicationDBContext applicationDbContext)
        {
            _carTypeService = carTypeService;
            _applicationDbContext = applicationDbContext;
        }
        #endregion

        #region Public Functions
        [HttpGet]
        [Route("cartype")]
        [ProducesResponseType(typeof(CarType), 200)]
        [ProducesResponseType(404)]
        public Task<List<CarType>> GetAllCarTypes()
        {
            return _applicationDbContext.CarTypes.ToListAsync();
        }
        [HttpGet]
        [Route("cartype/{carTypeId}")]
        [ProducesResponseType(typeof(CarType), 200)]
        [ProducesResponseType(404)]
        public Task<List<CarType>> GetCarType(int carTypeId)
        {
            return _applicationDbContext.CarTypes.Where(s=>s.carTypeId == carTypeId).ToListAsync();
        }
        [HttpPost]
        [Route("carType")]
        [ProducesResponseType(typeof(CarType), 200)]
        [ProducesResponseType(404)]
        public Task<int> AddCarType([FromBody] CarType carType)
        {
            return _carTypeService.AddCarType(carType);
        }

        [HttpPut("carType/restore/{id}")]
        [ProducesResponseType(typeof(CarType), 200)]
        [ProducesResponseType(404)]
        public async Task<IActionResult> RestoreCarType(int id)
        {
            var uId = await _carTypeService.RestoreCarType(id);
            if (uId == 0)
            {
                return NotFound();
            }
            return Ok(uId);
        }

        [HttpDelete("carType/{id}")]
        [ProducesResponseType(typeof(CarType), 200)]
        [ProducesResponseType(404)]
        public async Task<IActionResult> DeleteCarType(int id)
        {
            var uId = await _carTypeService.DeleteCarType(id);
            if (uId == 0)
            {
                return NotFound();
            }
            return Ok(uId);
        }
        #endregion
    }
}
