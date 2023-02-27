namespace UroTaxi.Business.Dto
{
    public interface IBookingDetailDto
    {
        int carModelId { get; set; }
        string carName { get; set; }
        int carTypeId { get; set; }
        string carType { get; set; }
        string carImage { get; set; }
        string ac { get; set; }
        int seats { get; set; }
        long fare { get; set; }
        string fuelType { get; set; }
        int driverId { get; set; }
        string driverName { get; set; }
        string driverEmail { get; set; }
        long driverPhone { get; set; }
    }
}
