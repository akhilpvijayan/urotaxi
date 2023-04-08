using UroTaxi.Entities;

namespace UroTaxi.Business.Services
{
    public interface IUserservice
    {
        Task<int> AddUser(User user);
        Task<int> DeleteUser(int id);
        Task<int> RestoreUser(int id);
    }
}
