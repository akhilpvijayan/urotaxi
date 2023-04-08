using Microsoft.AspNetCore.Identity;
using UroTaxi.Business.DataServices;
using UroTaxi.Entities;

namespace UroTaxi.Business.Services.DataServices
{
    public class UserDataService : IUserDataService
    {
        #region Private Functions
        private readonly ApplicationDBContext _applicationDbContext;
        #endregion

        #region Constructors
        public UserDataService(
            ApplicationDBContext applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;
        }
        #endregion
        #region public functions
        public async Task<int> AddUser(User user)
        {
            if (_applicationDbContext != null)
            {
                await _applicationDbContext.Users.AddAsync(user);
                await _applicationDbContext.SaveChangesAsync();
                return user.userId;
            }
            return 0;
        }

        public async Task<int> DeleteUser(int id)
        {
            if (_applicationDbContext != null)
            {
                var itemToRemove = _applicationDbContext.Users.SingleOrDefault(x => x.userId == id);

                if (itemToRemove != null)
                {
                    itemToRemove.isActive = false;
                    await _applicationDbContext.SaveChangesAsync();
                    return id;
                }
                return 0;
            }
            return 0;
        }

        public async Task<int> RestoreUser(int id)
        {
            if (_applicationDbContext != null)
            {
                var itemToRemove = _applicationDbContext.Users.SingleOrDefault(x => x.userId == id);

                if (itemToRemove != null)
                {
                    itemToRemove.isActive = true;
                    await _applicationDbContext.SaveChangesAsync();
                    return id;
                }
                return 0;
            }
            return 0;
        }
        #endregion
    }
}
