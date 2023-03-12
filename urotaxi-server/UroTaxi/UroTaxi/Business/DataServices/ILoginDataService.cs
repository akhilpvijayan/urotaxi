using UroTaxi.Entities;

namespace UroTaxi.Business.DataServices
{
    public interface ILoginDataService
    {
        Task<int> AddUser(User user);
        User ValidateUser(string username, string password);
        string GenerateJSONWebToken(User user);
    }
}
