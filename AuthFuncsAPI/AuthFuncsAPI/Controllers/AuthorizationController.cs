using AuthFuncsService.Dto.Authorization;
using AuthFuncsService.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AuthFuncsService.Controllers
{
    [Route("api/auth")]
    [ApiController]
    public class AuthorizationController : ControllerBase
    {
        public AuthorizationController(IAuthorizationService authorizationService)
        {
            AuthorizationService = authorizationService;
        }

        public IAuthorizationService AuthorizationService { get; }

        [HttpPost("login")]
        public ActionResult Login(LoginRequestDto loginRequest)
        {
            return Ok(new LoginResponseDto());
        }

        [HttpPost("register")]
        public ActionResult Register([FromBody]RegisterRequestDto registerRequest)
        {
            var ret = AuthorizationService.RegisterUser(registerRequest);

            return Created("user", ret);
        }

    }
}
