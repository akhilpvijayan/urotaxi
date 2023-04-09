using System.ComponentModel.DataAnnotations;
using UroTaxi.Business.Entities;

namespace UroTaxi.Entities
{
    public class Booking : IBooking
    {
        [Key]
        public int bookingId { get; set; }
        public string name { get; set; }
        public int bookedUser { get; set; }
        public int source { get; set; }
        public int destination { get; set; }
        public int carModel { get; set; }
        public DateTime pickUpDate { get; set; }
        public string pickUpAddress { get; set; }
        public long phone { get; set; }
        public string email { get; set; }
        public string dropAddress { get; set; }
    }
}