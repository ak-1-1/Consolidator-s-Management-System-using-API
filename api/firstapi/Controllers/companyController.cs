using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using firstapi.Models;

namespace firstapi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class companyController : ControllerBase
    {
        private readonly Ace42023Context _context;

        public companyController(Ace42023Context context)
        {
            _context = context;
        }

        // GET: api/company
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Companyawa>>> GetCompanyawas()
        {
          if (_context.Companyawas == null)
          {
              return NotFound();
          }
            return await _context.Companyawas.ToListAsync();
        }

        // GET: api/company/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Companyawa>> GetCompanyawa(string id)
        {
          if (_context.Companyawas == null)
          {
              return NotFound();
          }
          System.Console.WriteLine("cominggggggggggggggggggggggggggggggggg");
            var companyawa = _context.Companyawas.Where(x=>x.Cname==id).SingleOrDefault();

            if (companyawa == null)
            {
                return NotFound();
            }

            return companyawa;
        }

        // PUT: api/company/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCompanyawa(string id, Companyawa companyawa)
        {
            if (id != companyawa.Cid)
            {
                return BadRequest();
            }

            _context.Entry(companyawa).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CompanyawaExists(id))
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

        // POST: api/company
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Companyawa>> PostCompanyawa(Companyawa companyawa)
        {
          if (_context.Companyawas == null)
          {
              return Problem("Entity set 'Ace42023Context.Companyawas'  is null.");
          }
            _context.Companyawas.Add(companyawa);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (CompanyawaExists(companyawa.Cid))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetCompanyawa", new { id = companyawa.Cid }, companyawa);
        }

        // DELETE: api/company/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCompanyawa(string id)
        {
            if (_context.Companyawas == null)
            {
                return NotFound();
            }
            var companyawa = await _context.Companyawas.FindAsync(id);
            if (companyawa == null)
            {
                return NotFound();
            }

            _context.Companyawas.Remove(companyawa);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool CompanyawaExists(string id)
        {
            return (_context.Companyawas?.Any(e => e.Cid == id)).GetValueOrDefault();
        }
    }
}
