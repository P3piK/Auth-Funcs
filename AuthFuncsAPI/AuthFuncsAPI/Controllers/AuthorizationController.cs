using AuthFuncsAPI.Dto.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AuthFuncsAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthorizationController : ControllerBase
    {
        [HttpPost("login")]
        public LoginResponseDto Login(LoginRequestDto loginRequest)
        {
            return new LoginResponseDto();
        }

        [HttpPost("register")]
        public RegisterResponseDto Register([FromBody]RegisterRequestDto registerRequest)
        {
            return new RegisterResponseDto();
        }

    }
}
