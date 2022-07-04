using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Persona5ApiCore.Context;
using Persona5ApiCore.Models;

namespace persona5apicore.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DamageEffectivenessController : ControllerBase
    {
        private readonly PersonaContext _context;

        public DamageEffectivenessController(PersonaContext context)
        {
            _context = context;
        }

        // GET: api/DamageEffectiveness
        [HttpGet]
        public async Task<ActionResult<IEnumerable<DamageEffectiveness>>> GetDamageEffectivenesses()
        {
          if (_context.DamageEffectivenesses == null)
          {
              return NotFound();
          }
            return await _context.DamageEffectivenesses.ToListAsync();
        }

        // GET: api/DamageEffectiveness/5
        [HttpGet("{id}")]
        public async Task<ActionResult<DamageEffectiveness>> GetDamageEffectiveness(int id)
        {
          if (_context.DamageEffectivenesses == null)
          {
              return NotFound();
          }
            var damageEffectiveness = await _context.DamageEffectivenesses.FindAsync(id);

            if (damageEffectiveness == null)
            {
                return NotFound();
            }

            return damageEffectiveness;
        }

        // PUT: api/DamageEffectiveness/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutDamageEffectiveness(int id, DamageEffectiveness damageEffectiveness)
        {
            if (id != damageEffectiveness.Id)
            {
                return BadRequest();
            }

            _context.Entry(damageEffectiveness).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!DamageEffectivenessExists(id))
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

        // POST: api/DamageEffectiveness
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<DamageEffectiveness>> PostDamageEffectiveness(DamageEffectiveness damageEffectiveness)
        {
          if (_context.DamageEffectivenesses == null)
          {
              return Problem("Entity set 'PersonaContext.DamageEffectivenesses'  is null.");
          }
            _context.DamageEffectivenesses.Add(damageEffectiveness);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetDamageEffectiveness", new { id = damageEffectiveness.Id }, damageEffectiveness);
        }

        // DELETE: api/DamageEffectiveness/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteDamageEffectiveness(int id)
        {
            if (_context.DamageEffectivenesses == null)
            {
                return NotFound();
            }
            var damageEffectiveness = await _context.DamageEffectivenesses.FindAsync(id);
            if (damageEffectiveness == null)
            {
                return NotFound();
            }

            _context.DamageEffectivenesses.Remove(damageEffectiveness);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool DamageEffectivenessExists(int id)
        {
            return (_context.DamageEffectivenesses?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
