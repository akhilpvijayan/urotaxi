namespace UroTaxi.Business.Entities
{
    public interface ICartype
    {
        int carTypeId { get; set; }
        string carType { get; set; }
        bool isActive { get; set; }
    }
}

