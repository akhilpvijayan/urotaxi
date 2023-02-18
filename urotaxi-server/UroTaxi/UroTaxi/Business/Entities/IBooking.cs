namespace UroTaxi.Business.Entities
{
    public interface IBooking
    {
        int bookingId { get; set; }
        string name { get; set; }
        int source { get; set; }
        int destination { get; set; }
        DateTime pickUpDate { get; set; }
        string pickUpAddress { get; set; }
        long phone { get; set; }
        string email { get; set; }
        string dropAddress { get; set; }
    }
}
