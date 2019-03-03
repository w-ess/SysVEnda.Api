using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.Authentication;
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
                        DateTime dataCriacao = DateTime.Now;
                        DateTime dataExpiracao = dataCriacao + TimeSpan.FromHours(20);

                        var claims = new List<Claim>{
                            new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
                            //new Claim("NameId", userIdentity.Id),
                            new Claim(JwtRegisteredClaimNames.NameId, userIdentity.Id),
                            new Claim(JwtRegisteredClaimNames.Email, userIdentity.Email)
                        };

                        //recebe uma instancia da classe SymmetricSecurityKey 
                        //armazenando a chave de criptografia usada na criação do token
                        var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["SecurityKey"]));

                        //recebe um objeto do tipo SigninCredentials contendo a chave de 
                        //criptografia e o algoritmo de segurança empregados na geração 
                        // de assinaturas digitais para tokens
                        var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);
                        var handler = new JwtSecurityTokenHandler();                        
                        var securityToken = new JwtSecurityToken(
                                issuer: "SysVendaApi",
                                audience: "SysVendaApi",
                                claims: claims,
                                expires: dataExpiracao,
                                signingCredentials: creds);

                        var token = handler.WriteToken(securityToken);
                        return Ok(new
                        {
                            authenticated = true,
                            created = dataCriacao.ToString("yyyy-MM-dd HH:mm:ss"),
                            expiration = dataExpiracao.ToString("yyyy-MM-dd HH:mm:ss"),
                            accessToken = token,
                            message = "OK"
                        });
                    }
                    return BadRequest("Credenciais inválidas...");
                }
            }
            return BadRequest("Credenciais inválidas...");
        }
    }
}