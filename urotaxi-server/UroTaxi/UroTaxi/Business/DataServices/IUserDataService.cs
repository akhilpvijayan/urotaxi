using UroTaxi.Entities;

namespace UroTaxi.Business.DataServices
{
    public interface IUserDataService
    {
        Task<int> AddUser(User user);
        Task<int> DeleteUser(int id);
        Task<int> RestoreUser(int id);
    }
}
