using OCLP.Base;
using OCLP.DTOs.Auth.Request;
using OCLP.DTOs.Auth.Response;
using OCLP.Services.Auth;

namespace OCLP.Repositories.Auth
{
    public class AuthRepository : IAuthRepository
    {
        private readonly ILoginService _loginService;

        public AuthRepository(ILoginService loginService)
        {
            _loginService = loginService;
        }
        public async Task<(int statusCode, BaseResponseWithData<LoginResponseDto>)> LoginRepositoryAync(LoginRequestDto loginRequestDto)
        => await _loginService.LoginServiceAsync(loginRequestDto);
    }
}