using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Yemeksepeti.Dtos.User;
using Yemeksepeti.Interfaces;
using Yemeksepeti.Models;

namespace Yemeksepeti.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AuthController : ControllerBase
    {
        private readonly IAuthRepository _authRepo;

        public AuthController(IAuthRepository authRepo)
        {
            _authRepo = authRepo;
        }

        [HttpPost("Register")]
        public async Task<IActionResult> Register(UserRegisterDto request){
            ServiceResponse<int> response = await _authRepo.Register(
                new User {Username =request.Username,Email=request.Email,Role=request.Role},request.Password
            );

            if(!response.Success){
                return BadRequest(response);
            }
            return Ok(response);
        }

        [HttpPost("Login")]
        public async Task<IActionResult> Login(UserLoginDto request){
            ServiceResponse<string> response=await _authRepo.Login(request.Username,request.Password);

            if(!response.Success){
                return BadRequest(response);
            }

            return Ok(response);
        }

    }
}