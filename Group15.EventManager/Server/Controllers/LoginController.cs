using System;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using Group15.EventManager.Application.ViewModels.Auth;
using Group15.EventManager.ApplicationLayer.Interfaces;
using Group15.EventManager.Domain.Models.Auth;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;

namespace Group15.EventManager.Server.Controllers
{
    [ApiController]
    [Route("api/login")]
    public class LoginController : ControllerBase
    {
        private readonly IConfiguration _configuration;
        private readonly IAccountApplicationService _accountApplicationService;

        public LoginController(IConfiguration configuration, IAccountApplicationService accountApplicationService)
        {
            _configuration = configuration;
            _accountApplicationService = accountApplicationService;
        }

        [HttpPost]
        public async Task<IActionResult> Login([FromBody] LoginModel loginModel)
        {
            var result = await _accountApplicationService.PasswordSignIn(loginModel);

            if (!result.Succeeded)
            {
                return BadRequest(new LoginResult { Successful = false, Error = "Username or password are invalid" });
            }

            var claims = new[]
            {
                new Claim(ClaimTypes.Name, loginModel.Email)
            };

            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["JwtSecurityKey"]));
            var credentials = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);
            var expiry = DateTime.Now.AddDays(Convert.ToInt32(_configuration["JwtExpiryInDays"]));

            var token = new JwtSecurityToken(
                _configuration["JwtIssuer"],
                _configuration["JwtAudience"],
                claims,
                expires: expiry,
                signingCredentials: credentials
            );

            return Ok(new LoginResult {Successful = true, Name = loginModel.Email, Token = new JwtSecurityTokenHandler().WriteToken(token) });
        }
    }
}