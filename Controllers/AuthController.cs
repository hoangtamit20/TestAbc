using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query.SqlExpressions;
using OCLP.Data.DbContext;
using OCLP.Data.Entities;
using OCLP.DTOs.Auth.Request;
using OCLP.Repositories.Auth;

namespace OCLP.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AuthController : ControllerBase
    {

        private readonly OCLPDbContext _dbContext;
        private readonly IAuthRepository _authRepository;

        public AuthController(OCLPDbContext dbContext, IAuthRepository authRepository)
        {
            _dbContext = dbContext;
            _authRepository = authRepository;
        }


        [HttpPost("Login")]
        public async Task<IActionResult> Login(LoginRequestDto loginRequestDto)
        {
            if (ModelState.IsValid)
            {
                var result = await _authRepository.LoginRepositoryAync(loginRequestDto);
                return StatusCode(result.statusCode, result.Item2);
            }
            return BadRequest("Data is not valid");
        }
    }
}