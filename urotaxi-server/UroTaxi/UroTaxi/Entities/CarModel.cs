using System.ComponentModel.DataAnnotations;
using UroTaxi.Business.Entities;

namespace UroTaxi.Entities
{
    public class CarModel : ICarModel
    {
        [Key]
        public int carModelId { get; set; }
        public string carModel { get; set; }
        public int carType { get; set; }
        public string carImage { get; set; }
        public bool isActive { get; set; }
    }
}
