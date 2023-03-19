using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using UroTaxi.Business.Entities;
using UroTaxi.Business.Services;
using UroTaxi.Entities;
using UroTaxi.XObjects.ViewModels;

namespace UroTaxi.Controllers
{
    [ApiController]
    public class CarModelController : ControllerBase
    {

        #region Private Functions
        private readonly ICarModelService _carModelService;
        private readonly ApplicationDBContext _applicationDbContext;
        #endregion

        #region Constructors
        public CarModelController(
            ICarModelService carModelService,
            ApplicationDBContext applicationDbContext)
        {
            _carModelService = carModelService;
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
            return _applicationDbContext.CarModels.Where(s=>s.isActive==true).ToListAsync();
        }

        [HttpGet]
        [Route("carmodel/{carTypeId}")]
        [ProducesResponseType(typeof(CarModel), 200)]
        [ProducesResponseType(404)]
        public Task<List<CarModel>> GetCarModels(int carTypeId)
        {
            return _applicationDbContext.CarModels.Where(s=>s.carType == carTypeId).ToListAsync();
        }

        [HttpGet("carmodels")]
        [ProducesResponseType(typeof(CarModel), 200)]
        [ProducesResponseType(404)]
        public async Task<ActionResult<IEnumerable<CarModelsViewModel>>> GetAllCarModelVM()
        {
            return await _carModelService.GetAllCarModelVM();
        }

        [HttpDelete("carmodel/{id}")]
        [ProducesResponseType(typeof(CarModel), 200)]
        [ProducesResponseType(404)]
        public async Task<IActionResult> DeleteCarModel(int id)
        {
            var uId = await _carModelService.DeleteCarModel(id);
            if (uId == 0)
            {
                return NotFound();
            }
            return Ok(uId);
        }

        [HttpPut("carmodel/restore/{id}")]
        [ProducesResponseType(typeof(CarModel), 200)]
        [ProducesResponseType(404)]
        public async Task<IActionResult> RestoreCarModel(int id)
        {
            var uId = await _carModelService.RestoreCarModel(id);
            if (uId == 0)
            {
                return NotFound();
            }
            return Ok(uId);
        }
        #endregion
    }
}
