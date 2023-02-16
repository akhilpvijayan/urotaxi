using System.ComponentModel.DataAnnotations;

namespace UroTaxi.Entities
{
    public class CarType : ICartype
    {

        [Key]
        public int carTypeId { get; set; }
        public string carType { get; set; }
        public bool isActive { get; set; }
    }
}
