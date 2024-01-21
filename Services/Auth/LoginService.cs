using Microsoft.AspNetCore.Identity;
using OCLP.Base;
using OCLP.Data.Entities;
using OCLP.DTOs.Auth.Request;
using OCLP.DTOs.Auth.Response;

namespace OCLP.Services.Auth
{
    public class LoginService : ILoginService
    {
        private readonly UserManager<AppUser> _userManager;

        public LoginService(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }
        public async Task<(int statusCode, BaseResponseWithData<LoginResponseDto>)> LoginServiceAsync(LoginRequestDto loginRequestDto)
        {
            // valid data
            var listUser = await _userManager.FindByEmailAsync(loginRequestDto.Email);


            if (listUser is null)
                return (StatusCodes.Status401Unauthorized, new BaseResponseWithData<LoginResponseDto>()
                {
                    Data = null,
                    Message = "Login falied",
                    Errors = new List<string>(){"kdgakdugadu", "dhilahdoiadh"}
                });
            
            // If email is exists

            // If password correct

            // If confirm email
            // Process Login

            return (StatusCodes.Status200OK, new BaseResponseWithData<LoginResponseDto>(){
                Data = new LoginResponseDto(){
                    AccessToken = "dkjagdkagdka",
                    RefreshToken = "ldahdlahdla"
                },
                Message = "Login Success"
            });
        }
    }
}