using AngularProjesiCommon.Dtos;
using AngularProjesiCommon.HelperModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace AngularProjesi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {

        private readonly ILogger<AuthController> _logger;
        private readonly IPasswordHasher<ApplicationUserDto> _hasher;
        private readonly IConfigurationRoot _config;
        private readonly UserManager<ApplicationUserDto> _manager;
        public AuthController(ILogger<AuthController> logger, IPasswordHasher<ApplicationUserDto> hasher, IConfigurationRoot config, UserManager<ApplicationUserDto> manager)
        {
            _logger = logger;
            _hasher = hasher;
            _config = config;
            _manager = manager;
        }
        [HttpPost("Token")]
        private async Task<ActionResult> CreateToken([FromBody] CredentialModelDto model )
        {
            try
            {
                var user = await _manager.FindByNameAsync(model.UserName);
                if(user != null)
                {
                    if (_hasher.VerifyHashedPassword(user, user.PasswordHash, model.Password) == PasswordVerificationResult.Success)
                    {
                        return Ok(CreateToken(user)); 
                    }
                }
            }
            catch (Exception ex)
            {
                _logger.LogError($"JWT yaratırken bir hata oluştu: { ex.Message.ToString()}");
                
            } return null;



        }




        private async Task<JwtTokenPacket> CreateToken(ApplicationUserDto _appUser)
        {
            var userClaims = await _manager.GetClaimsAsync(_appUser);

            var claims = new[]
            {
                new Claim(JwtRegisteredClaimNames.Sub,_appUser.UserName),
                new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString() )


            }.Union(userClaims);

            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_config["Token:Key"]));
            var cred = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);
            var token = new JwtSecurityToken
            (
                issuer: _config["Token:Issuer"],
                audience: _config["Token:Audience"],
                claims: claims,
                expires: DateTime.UtcNow.AddMinutes(20),
                signingCredentials: cred
            );

            return new JwtTokenPacket
            {
                Token = new JwtSecurityTokenHandler().WriteToken(token),
                Expiration = token.ValidTo.ToString(),
                UserName = _appUser.UserName

            };
        }
           
            }

}
