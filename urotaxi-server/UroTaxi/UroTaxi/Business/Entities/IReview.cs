namespace UroTaxi.Business.Entities
{
    public interface IReview
    {
        int reviewId { get; set; }
        int userId { get; set; }
        int rating { get; set; }
        int driverId { get; set; }
    }
}
