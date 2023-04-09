namespace UroTaxi.Business.Services.Dto
{
    public class BookingListDto
    {
        public int bookingId { get; set; }
        public string name { get; set; }
        public string source { get; set; }
        public string destination { get; set; }
        public DateTime pickUpDate { get; set; }
        public string pickUpAddress { get; set; }
        public long phone { get; set; }
        public string email { get; set; }
        public string dropAddress { get; set; }
        public string bookedUser { get; set; }
        public string carName { get; set; }
        public int carModelId { get; set; }
        public int carTypeId { get; set; }
        public string carImage { get; set; }
        public string carType { get; set; }
        public bool ac { get; set; }
        public int seats { get; set; }
        public long minFare { get; set; }
        public string fuelType { get; set; }
        public int driverId { get; set; }
        public string driverName { get; set; }
        public string driverEmail { get; set; }
        public long driverPhone { get; set; }
    }
}
