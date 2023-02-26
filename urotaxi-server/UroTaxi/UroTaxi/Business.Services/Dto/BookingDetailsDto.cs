using UroTaxi.Business.Dto;

namespace UroTaxi.Business.Services.Dto
{
    public class BookingDetailsDto : IBookingDetailsDto
    {
        public int carModelId { get; set; }
        public string carName { get; set; }
        public int carTypeId { get; set; }
        public string carType { get; set; }
        public string ac { get; set; }
        public int seats { get; set; }
        public long fare { get; set; }
        public string fuelType { get; set; }
        public int driverId { get; set; }
        public string driverName { get; set; }
        public string driverEmail { get; set; }
        public long driverPhone { get; set; }

    }
}
