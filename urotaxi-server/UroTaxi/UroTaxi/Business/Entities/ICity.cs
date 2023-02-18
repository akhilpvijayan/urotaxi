namespace UroTaxi.Business.Entities
{
    public interface ICity
    {
        int cityId { get; set; }
        string city { get; set; }
        bool isActive { get; set; }
    }
}
