using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SysVenda.Api.Data;
using SysVenda.Api.Identity;
using SysVenda.Domain.Entidades;

namespace SysVenda.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContaUsuarioController : ControllerBase
    {
        private readonly ApplicationDbContext _context;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;

        public ContaUsuarioController(
            ApplicationDbContext context,
            UserManager<ApplicationUser> userManager,
            RoleManager<IdentityRole> roleManager)
        {
            _context = context;
            _userManager = userManager;
            _roleManager = roleManager;
        }
       

        private IActionResult GetErrorResult(IdentityResult result)
        {
            if (!result.Succeeded)
            {
                if (result.Errors != null)
                {
                    foreach (var error in result.Errors)
                    {
                        ModelState.AddModelError("", error.Description);
                    }
                }

                if (ModelState.IsValid)
                {
                    // No ModelState errors are available to send, so just return an empty BadRequest.
                    return BadRequest();
                }

                return BadRequest(ModelState);
            }

            return null;
        }


        // POST api/ContaUsuario/Registrar
        [AllowAnonymous]
        [HttpPost]
        [Route("Registrar")]
        public async Task<IActionResult> Registrar([FromBody] RegisterBindingModel model)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var user = new ApplicationUser() { UserName = model.Email, Email = model.Email };

            IdentityResult result = await _userManager.CreateAsync(user, model.Password);

            if (!result.Succeeded)
            {
                return GetErrorResult(result);
            }

            return Ok();
        }

        // POST api/ContaUsuario/AlterarSenha
        [HttpPost]
        [Route("AlterarSenha")]
        public async Task<IActionResult> AlterarSenha(ChangePasswordBindingModel model)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var usuarioLogado = await _userManager.GetUserAsync(HttpContext.User);

            IdentityResult result = await _userManager.ChangePasswordAsync(usuarioLogado, model.OldPassword,
                model.NewPassword);

            if (!result.Succeeded)
            {
                return GetErrorResult(result);
            }

            return Ok();
        }

    }
}
