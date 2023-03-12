using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Text;
using UroTaxi.Business.DataServices;
using UroTaxi.Entities;

namespace UroTaxi.Business.Services.DataServices
{
    public class LoginDataService : ILoginDataService
    {
        #region Private Functions
        private readonly ApplicationDBContext _applicationDbContext;
        private readonly IConfiguration _config;
        #endregion

        #region Constructors
        public LoginDataService(
            ApplicationDBContext applicationDbContext, IConfiguration config)
        {
            _applicationDbContext = applicationDbContext;
            _config = config;
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

        public User ValidateUser(string username, string password)
        {
            if (_applicationDbContext != null)
            {
                User user = _applicationDbContext.Users.FirstOrDefault(u => u.userName == username && u.password == password);
                if (user != null)
                {
                    return user;
                }
                return null;
            }
            return null;
        }

        //GenerateJSON Web Token
        public string GenerateJSONWebToken(User user)
        {
            //security key
            var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_config["Jwt:Key"]));

            //signing credential
            var credentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);

            //Generate token
            var token = new JwtSecurityToken(
                issuer: _config["Jwt:Issuer"],
                audience: _config["Jwt:Audience"],
                null,
                expires: DateTime.Now.AddMinutes(120),
                signingCredentials: credentials
                );
            return new JwtSecurityTokenHandler().WriteToken(token);
        }
        #endregion
    }
}
