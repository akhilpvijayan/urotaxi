using System.ComponentModel.DataAnnotations;
using UroTaxi.Business.Entities;

namespace UroTaxi.Entities
{
    public class Review : IReview
    {
        [Key]
        public int reviewId { get; set; }
        public int userId { get; set; }
        public int rating { get; set; }
        public int driverId { get; set; }
    }
}
