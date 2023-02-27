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
    public class flhtController : ControllerBase
    {
        private readonly Ace42023Context _context;

        public flhtController(Ace42023Context context)
        {
            _context = context;
        }

        // GET: api/flht
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Flightawa>>> GetFlightawas()
        {
            if (_context.Flightawas == null)
            {
                //System.Console.WriteLine("12333333333333333333333333333333");
                return NotFound();
            }
            var fl = await _context.Flightawas.ToListAsync();
            if (fl == null || !fl.Any())
            {
                return BadRequest("No Data Found");
            }

            return await _context.Flightawas.ToListAsync();
        }

        [HttpGet]
        [Route("api/flight/Getmaxi/")]
        public ActionResult Getmax()
        {
            try
            {
                int cnt = (from f in _context.Flightawas select f.Uid).Max();

                cnt += 1;

                return Ok(cnt);
            }
            catch(Exception e)
            {
                return Ok(0);
            }
        }

        [HttpGet]
        [Route("Getflightbyid")]
        public ActionResult Getflightvyid(int id)
        {
            Flightawa f = _context.Flightawas.Where(x => x.Uid == id).SingleOrDefault();

            if (f != null)
            {
                return Ok(f);
            }
            else
            {
                return NotFound();
            }
        }

        [HttpGet]
        [Route("api/flht/GetFlightawa/{str}")]
        public async Task<ActionResult<IEnumerable<Flightawa>>> GetFlightawa(string str)
        {
            if (_context.Flightawas == null)
            {
                return NotFound();
            }
            var flightawa = _context.Flightawas.Where(x => (x.Uname == str)).Select(x => x).ToList();

            if (flightawa == null || !flightawa.Any())
            {
                return NotFound("No Data Found");
            }

            return flightawa;
        }

        [HttpGet]
        [Route("api/flht/searchflight/{keyword}")]
        public async Task<ActionResult<IEnumerable<Flightawa>>> searchflight(string keyword)
        {
            if (_context.Flightawas == null)
            {
                return NotFound();
            }
            var result = _context.Flightawas.Where(x => x.Uname.Contains(keyword)).Select(x => x).ToList();

            if (result == null)
            {
                return NotFound("No Data Found");
            }
            return result;
        }

        // GET: api/flht/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Flightawa>> GetFlightawa(int id)
        {
            if (_context.Flightawas == null)
            {
                return NotFound();
            }
            var flightawa = await _context.Flightawas.FindAsync(id);

            if (flightawa == null)
            {
                return NotFound();
            }

            return flightawa;
        }

        // PUT: api/flht/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutFlightawa(int id, Flightawa flightawa)
        {
            if (id != flightawa.Uid)
            {
                return BadRequest();
            }
            //System.Console.WriteLine(flightawa.Nticket);;
            _context.Entry(flightawa).State = EntityState.Modified;
            if (flightawa.Cid == null || flightawa.Doj == null || flightawa.Jfrom == null || flightawa.Jto == null || flightawa.Nticket == null || flightawa.Uid == null || flightawa.Uname == null)
            {
                return BadRequest();
            }
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!FlightawaExists(id))
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

        // POST: api/flht
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Flightawa>> PostFlightawa(Flightawa flightawa)
        {
            //System.Console.WriteLine(1);
            if (_context.Flightawas == null)
            {
                //System.Console.WriteLine(2);
                //return Problem("Entity set 'Ace42023Context.Flightawas'  is null.");
                return BadRequest();
            }
            System.Console.WriteLine(flightawa.Cid + "----------------------------->");
            if (flightawa.Cid == null || flightawa.Doj == null || flightawa.Jfrom == null || flightawa.Jto == null || flightawa.Nticket == 0 || flightawa.Uid == null || flightawa.Uname == null)
            {
                return BadRequest();
            }
            //System.Console.WriteLine(3);
            _context.Flightawas.Add(flightawa);
            try
            {
                //System.Console.WriteLine(4);
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                //System.Console.WriteLine(5);
                if (FlightawaExists(flightawa.Uid))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetFlightawa", new { id = flightawa.Uid }, flightawa);
        }

        // DELETE: api/flht/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteFlightawa(int id)
        {
            if (_context.Flightawas == null)
            {
                return NotFound();
            }
            var flightawa = await _context.Flightawas.FindAsync(id);
            if (flightawa == null)
            {
                return NotFound();
            }

            _context.Flightawas.Remove(flightawa);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool FlightawaExists(int id)
        {
            return (_context.Flightawas?.Any(e => e.Uid == id)).GetValueOrDefault();
        }
    }
}
