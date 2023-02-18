namespace UroTaxi.Business.Entities
{
    public interface IUser
    {
        int userId { get; set; }
        string userName { get; set; }
        string password { get; set; }
        string userEmail { get; set; }
        long userPhone { get; set; }
        bool isActive { get; set; }
        bool isDriver { get; set; }
        bool isAdmin { get; set; }
    }
}
