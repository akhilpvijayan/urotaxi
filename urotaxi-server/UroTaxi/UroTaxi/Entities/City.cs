using System.ComponentModel.DataAnnotations;
using UroTaxi.Business.Entities;

namespace UroTaxi.Entities
{
    public class City : ICity
    {
        [Key]
        public int cityId { get; set; }
        public string city { get; set; }
        public bool isActive { get; set; }
    }
}

