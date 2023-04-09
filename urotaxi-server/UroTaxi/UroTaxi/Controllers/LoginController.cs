using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Text;
using UroTaxi.Business.Services;
using UroTaxi.Business.Services.Services;
using UroTaxi.Entities;

namespace UroTaxi.Controllers
{
    [ApiController]
    public class LoginController : ControllerBase
    {
        #region Private Functions
        private readonly ILoginService _loginService;
        private readonly ApplicationDBContext _applicationDbContext;
        private readonly IConfiguration _config;
        #endregion

        #region Constructors
        public LoginController(
            ILoginService loginService,
            ApplicationDBContext applicationDbContext, IConfiguration config)
        {
            _loginService = loginService;
            _applicationDbContext = applicationDbContext;
            _config = config;
        }
        #endregion

        #region Public Functions
        [HttpPost]
        [Route("register/")]
        [ProducesResponseType(typeof(User), 200)]
        [ProducesResponseType(404)]
        public Task<int> AddUser([FromBody] User user)
        {
            return _loginService.AddUser(user);
        }

        //Getting token ,username and RoleId
        [AllowAnonymous]
        [HttpGet("login/{userName}/{password}")]

        public IActionResult Login(string userName, string password)
        {
            IActionResult response = Unauthorized();
            //Authenticate the user
            var user = _loginService.AuthenticateUser(userName, password);

            //validate
            if (user != null)
            {
                var tokenString = _loginService.GenerateJSONWebToken(user);
                response = Ok(new
                {
                    uId = user.userId,
                    uName = user.userName,
                    isAdmin = user.isAdmin,
                    isDriver = user.isDriver,
                    token = tokenString,
                    message = "Logged in successfully",
                    statusCode = 200
                });
            }
            return response;
        }
        #endregion
    }
}
