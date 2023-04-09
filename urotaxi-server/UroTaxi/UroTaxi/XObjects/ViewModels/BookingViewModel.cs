namespace UroTaxi.XObjects.ViewModels
{
    public class BookingViewModel
    {
        public int bookingId { get; set; }
        public string name { get; set; }
        public string source { get; set; }
        public string destination { get; set; }
        public DateTime pickUpDate { get; set; }
        public string pickUpAddress { get; set; }
        public long phone { get; set;}
        public string email { get; set; }
        public string dropAddress { get; set; }
        public string bookedUser { get; set; }
    }
}
