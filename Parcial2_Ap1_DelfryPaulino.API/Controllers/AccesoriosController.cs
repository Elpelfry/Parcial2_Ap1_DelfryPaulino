using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Parcial2_Ap1_DelfryPaulino.API.DAL;
using Parcial2_Ap1_DelfryPaulino.API.ViewModels;
using Shared.Models;

namespace Parcial2_Ap1_DelfryPaulino.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccesoriosController : ControllerBase
    {
        private readonly Contexto _context;

        public AccesoriosController(Contexto context)
        {
            _context = context;
        }

        // GET: api/Accesorios
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Accesorios>>> GetAccesorios()
        {
            return await _context.Accesorios.ToListAsync();
        }

        // GET: api/Accesorios/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Accesorios>> GetAccesorios(int id)
        {
            var accesorios = await _context.Accesorios.FindAsync(id);

            if (accesorios == null)
            {
                return NotFound();
            }

            return accesorios;
        }

        // POST: api/Accesorios
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Accesorios>> PostAccesorios(Accesorios accesorios)
        {
            _context.Accesorios.Add(accesorios);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetAccesorios", new { id = accesorios.AccesorioId }, accesorios);
        }

        // PUT: api/Accesorios/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutAccesorios(int id, Accesorios accesorios)
        {
            if (id != accesorios.AccesorioId)
            {
                return BadRequest();
            }

            _context.Entry(accesorios).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!AccesoriosExists(id))
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

        // DELETE: api/Accesorios/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAccesorios(int id)
        {
            var accesorios = await _context.Accesorios.FindAsync(id);
            if (accesorios == null)
            {
                return NotFound();
            }

            _context.Accesorios.Remove(accesorios);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool AccesoriosExists(int id)
        {
            return _context.Accesorios.Any(e => e.AccesorioId == id);
        }
    }
}
