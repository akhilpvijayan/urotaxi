using System.ComponentModel.DataAnnotations;
using UroTaxi.Business.Entities;

namespace UroTaxi.Entities
{
    public class Fueltype : IFuelType
    {
        [Key]
        public int fuelTypeId { get; set; }
        public string fuelType { get; set; }
        public bool isActive { get; set; }
    }
}
