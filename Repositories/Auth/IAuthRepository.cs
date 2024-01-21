
using OCLP.Base;
using OCLP.DTOs.Auth.Request;
using OCLP.DTOs.Auth.Response;

namespace OCLP.Repositories.Auth
{
    public interface IAuthRepository
    {
        Task<(int statusCode, BaseResponseWithData<LoginResponseDto>)> LoginRepositoryAync(LoginRequestDto loginRequestDto);
    }
}