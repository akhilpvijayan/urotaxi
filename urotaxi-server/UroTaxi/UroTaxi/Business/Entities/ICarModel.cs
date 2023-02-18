namespace UroTaxi.Business.Entities
{
    public interface ICarModel
    {
        int carModelId { get; set; }
        string carModel { get; set; }
        int carType { get; set; }
        string carImage { get; set; }
        bool isActive { get; set; }
    }
}