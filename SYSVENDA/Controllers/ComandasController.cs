using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SysVenda.Api.Data;
using SysVenda.Domain.Entidades;

namespace SysVenda.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ComandasController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public ComandasController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/Comandas
        [HttpGet]
        public IEnumerable<Comanda> GetComandas()
        {
            return _context.Comandas;
        }

        // GET: api/Comandas/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetComanda([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var comanda = await _context.Comandas.FindAsync(id);

            if (comanda == null)
            {
                return NotFound();
            }

            return Ok(comanda);
        }

        // PUT: api/Comandas/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutComanda([FromRoute] int id, [FromBody] Comanda comanda)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != comanda.Codigo)
            {
                return BadRequest();
            }

            _context.Entry(comanda).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ComandaExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/Comandas
        [HttpPost]
        public async Task<IActionResult> PostComanda([FromBody] Comanda comanda)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.Comandas.Add(comanda);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetComanda", new { id = comanda.Codigo }, comanda);
        }

        // DELETE: api/Comandas/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteComanda([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var comanda = await _context.Comandas.FindAsync(id);
            if (comanda == null)
            {
                return NotFound();
            }

            _context.Comandas.Remove(comanda);
            await _context.SaveChangesAsync();

            return Ok(comanda);
        }

        private bool ComandaExists(int id)
        {
            return _context.Comandas.Any(e => e.Codigo == id);
        }
    }
}