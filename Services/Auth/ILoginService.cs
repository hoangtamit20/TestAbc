using OCLP.Base;
using OCLP.DTOs.Auth.Request;
using OCLP.DTOs.Auth.Response;

namespace OCLP.Services.Auth
{
    public interface ILoginService
    {
        Task<(int statusCode, BaseResponseWithData<LoginResponseDto>)> LoginServiceAsync(LoginRequestDto loginRequestDto);
    }
}