using UroTaxi.Entities;

namespace UroTaxi.Business.Services
{
    public interface ILoginService
    {
        Task<int> AddUser(User user);
        User AuthenticateUser(string username, string password);
        string GenerateJSONWebToken(User user);
    }
}
