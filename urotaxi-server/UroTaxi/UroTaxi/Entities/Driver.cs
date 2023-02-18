using System.ComponentModel.DataAnnotations;
using UroTaxi.Business.Entities;

namespace UroTaxi.Entities
{
    public class Driver : IDriver
    {
        [Key]
        public int driverId { get; set; }
        public string driverName { get; set; }
        public long driverPhone { get; set; }
        public string driverEMail { get; set; }
        public int carModel { get; set; }
        public bool isActive { get; set; }
    }
}

