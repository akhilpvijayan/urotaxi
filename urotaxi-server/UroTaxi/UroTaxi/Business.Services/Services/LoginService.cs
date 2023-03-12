using UroTaxi.Business.DataServices;
using UroTaxi.Business.Services.DataServices;
using UroTaxi.Entities;

namespace UroTaxi.Business.Services.Services
{
    public class LoginService : ILoginService
    {
        #region Private Functions
        private readonly ILoginDataService _loginDataService;
        private readonly ApplicationDBContext _applicationDbContext;
        #endregion

        #region Constructors
        public LoginService(
            ILoginDataService loginDataService,
            ApplicationDBContext applicationDbContext)
        {
            _loginDataService = loginDataService;
            _applicationDbContext = applicationDbContext;
        }
        #endregion
        #region public functions
        public Task<int> AddUser(User user)
        {
            return _loginDataService.AddUser(user);
        }

        public User AuthenticateUser(string username, string password)
        {
            return _loginDataService.ValidateUser(username, password);
        }

        public string GenerateJSONWebToken(User user)
        {
            return _loginDataService.GenerateJSONWebToken(user);
        }
        #endregion
    }
}
