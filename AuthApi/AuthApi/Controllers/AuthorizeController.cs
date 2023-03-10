using AuthApi.Models;
using Microsoft.AspNetCore.Mvc;

namespace AuthApi.Controllers
{
    [ApiController]
    [Route("Authorize")]
    public class AuthorizeController : ControllerBase
    {

        private readonly ILogger<AuthorizeController> _logger;

        public AuthorizeController(ILogger<AuthorizeController> logger)
        {
            _logger = logger;
        }

        [Route("Get")]
        [HttpPost]
        public ApiResult<string> Get()
        {
            return new Models.ApiResult<string> { Data = "deneme", Status = ApiStatus.Ok, Error = "" };
        }

        [Route("Login")]
        [HttpPost]
        public ApiResult<AuthToken> Login(ApiRequest arg)
        {
            if (arg != null && arg.Email == "sean@test.com" && arg.Password == "SeanPass")
            {
                return new ApiResult<AuthToken>
                {
                    Data = new AuthToken { UserGroup = 0, Token = "8a2cfe059e8642b7adc367c6415428a6" },
                    Error = string.Empty,
                    Status = ApiStatus.Ok
                };
            }
            return new ApiResult<AuthToken>
            {
                Error = "Username or password is incorrect",
                Status = ApiStatus.Error
            };
        }
    }
}