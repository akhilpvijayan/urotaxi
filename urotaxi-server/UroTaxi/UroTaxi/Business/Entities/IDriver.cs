namespace UroTaxi.Business.Entities
{
    public interface IDriver
    {
        int driverId { get; set; }
        string driverName { get; set; }
        long driverPhone { get; set; }
        string driverEMail { get; set; }
        int carModel { get; set; }
        bool isActive { get; set; }
    }
}
