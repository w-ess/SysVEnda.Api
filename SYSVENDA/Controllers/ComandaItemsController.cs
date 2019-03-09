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
    public class ComandaItemsController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public ComandaItemsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/ComandaItems
        [HttpGet]
        public IEnumerable<ComandaItem> GetComandaItens()
        {
            return _context.ComandaItens;
        }

        // GET: api/ComandaItems/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetComandaItem([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var comandaItem = await _context.ComandaItens.FindAsync(id);

            if (comandaItem == null)
            {
                return NotFound();
            }

            return Ok(comandaItem);
        }

        // PUT: api/ComandaItems/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutComandaItem([FromRoute] int id, [FromBody] ComandaItem comandaItem)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != comandaItem.Codigo)
            {
                return BadRequest();
            }

            _context.Entry(comandaItem).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ComandaItemExists(id))
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

        // POST: api/ComandaItems
        [HttpPost]
        public async Task<IActionResult> PostComandaItem([FromBody] ComandaItem comandaItem)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.ComandaItens.Add(comandaItem);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetComandaItem", new { id = comandaItem.Codigo }, comandaItem);
        }

        // DELETE: api/ComandaItems/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteComandaItem([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var comandaItem = await _context.ComandaItens.FindAsync(id);
            if (comandaItem == null)
            {
                return NotFound();
            }

            _context.ComandaItens.Remove(comandaItem);
            await _context.SaveChangesAsync();

            return Ok(comandaItem);
        }

        private bool ComandaItemExists(int id)
        {
            return _context.ComandaItens.Any(e => e.Codigo == id);
        }
    }
}