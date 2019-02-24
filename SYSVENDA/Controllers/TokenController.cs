using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using SysVenda.Api.Identity;
using SysVenda.Domain.Entidades;

namespace SysVenda.Api.Controllers
{
    [Route("api/[controller]")]
    public class TokenController : Controller
    {
        private readonly IConfiguration _configuration;
        public TokenController(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        [AllowAnonymous]
        [HttpPost]
        public IActionResult RequestToken([FromBody] RegisterBindingModel request,
            [FromServices]UserManager<ApplicationUser> userManager,
            [FromServices]SignInManager<ApplicationUser> signInManager)
        {
            if (request != null && !String.IsNullOrWhiteSpace(request.Email))
            {
                var claims = new[]
                {
                     new Claim(ClaimTypes.Email, request.Email)
                };

                var userIdentity = userManager
                    .FindByNameAsync(request.Email).Result;

                if (userIdentity != null)
                {
                    // Efetua o login com base no Id do usuário e sua senha
                    var resultadoLogin = signInManager
                        .CheckPasswordSignInAsync(userIdentity, request.Password, false)
                        .Result;


                    if (resultadoLogin.Succeeded)
                    {
                        //recebe uma instancia da classe SymmetricSecurityKey 
                        //armazenando a chave de criptografia usada na criação do token
                        var key = new SymmetricSecurityKey(
                                Encoding.UTF8.GetBytes(_configuration["SecurityKey"]));

                        //recebe um objeto do tipo SigninCredentials contendo a chave de 
                        //criptografia e o algoritmo de segurança empregados na geração 
                        // de assinaturas digitais para tokens
                        var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

                        var token = new JwtSecurityToken(
                             issuer: "SysVendaApi",
                             audience: "SysVendaApi",
                             claims: claims,                             
                             expires: DateTime.Now.AddMinutes(30),
                             signingCredentials: creds);

                        return Ok(new
                        {
                            token = new JwtSecurityTokenHandler().WriteToken(token)
                        });
                    }
                    return BadRequest("Credenciais inválidas...");
                }
            }
            return BadRequest("Credenciais inválidas...");
        }
    }
}