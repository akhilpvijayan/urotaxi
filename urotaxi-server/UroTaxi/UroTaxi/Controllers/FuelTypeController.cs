using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UroTaxi.Entities;

namespace UroTaxi.Controllers
{
    public class FuelTypeController : ControllerBase
    {
        #region Private Functions
        private readonly ApplicationDBContext _applicationDbContext;
        #endregion

        #region Constructors
        public FuelTypeController(
            ApplicationDBContext applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;
        }
        #endregion

        #region Public Functions
        [HttpGet]
        [Route("fueltype")]
        [ProducesResponseType(typeof(Fueltype), 200)]
        [ProducesResponseType(404)]
        public Task<List<Fueltype>> GetFuelTypes()
        {
            return _applicationDbContext.fueltypes.ToListAsync();
        }
        #endregion
    }
}
