using AuthFuncsRepository;
using AuthFuncsRepository.Entity;
using AuthFuncsService.Dto.Authorization;
using AuthFuncsService.Interface;
using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuthFuncsService.Service
{
    public class AuthorizationService : IAuthorizationService
    {
        public AuthorizationService(AFContext context, IPasswordHasher passwordHasher)
        {
            Context = context;
            PasswordHasher = passwordHasher;
        }

        public AFContext Context { get; }
        public IPasswordHasher PasswordHasher { get; }

        public LoginResponseDto Login(LoginRequestDto loginRequest)
        {
            var response = new LoginResponseDto();
            var user = Context.Users.SingleOrDefault(u => u.Login == loginRequest.Login);

            if (user == null)
            {
                return response;
            }

            if (PasswordHasher.VerifyHashedPassword(loginRequest.Password, user.Password) == PasswordVerificationResult.Success)
            {

            }

            return response;
        }

        public RegisterResponseDto RegisterUser(RegisterRequestDto registerRequest)
        {
            var ret = new RegisterResponseDto();

            var user = new User(Context)
            {
                Login = registerRequest.Login,
                Password = PasswordHasher.HashPassword(registerRequest.Password),
            };
            user.Persist();

            return ret;
        }
    }
}
