using UroTaxi.Business.DataServices;
using UroTaxi.Entities;

namespace UroTaxi.Business.Services.Services
{
    public class UserService : IUserservice
    {
        #region Private Functions
        private readonly IUserDataService _userDataService;
        private readonly ApplicationDBContext _applicationDbContext;
        #endregion

        #region Constructors
        public UserService(
            IUserDataService userDataService,
            ApplicationDBContext applicationDbContext)
        {
            _userDataService = userDataService;
            _applicationDbContext = applicationDbContext;
        }

        #endregion
        #region public functions
        public Task<int> AddUser(User user)
        {
            return _userDataService.AddUser(user);
        }

        public Task<int> DeleteUser(int id)
        {
            return _userDataService.DeleteUser(id);
        }

        public Task<int> RestoreUser(int id)
        {
            return _userDataService.RestoreUser(id);
        }
        #endregion
    }
}
