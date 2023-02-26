namespace UroTaxi.Business.Entities
{
    public interface IFuelType
    {
        int fuelTypeId { get; set; }
        string fuelType { get; set; }
        bool isActive { get; set; }
    }
}
