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
    public class loginController : ControllerBase
    {
        
        static int get_hash(string s)
        {
            int total = 0;
            char[] c;
            c = s.ToCharArray();

            // Summing up all the ASCII values
            // of each alphabet in the string
            for (int k = 0; k <= c.GetUpperBound(0); k++)
                total += (int)c[k];

            return total % (10007);
        }
        private readonly Ace42023Context _context;

        public loginController(Ace42023Context context)
        {
            _context = context;
        }

        // GET: api/login
        [HttpGet]
        public async Task<ActionResult<IEnumerable<LoginAwa>>> GetLoginAwas()
        {
          if (_context.LoginAwas == null)
          {
              return NotFound();
          }
          System.Console.WriteLine("aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaabbbbbbbbbbbbbbbbbbbbbbbbbb");
            return await _context.LoginAwas.ToListAsync();
        }

        // GET: api/login/5
        [HttpGet("{id}")]
        public async Task<ActionResult<LoginAwa>> GetLoginAwa(string id)
        {
          if (_context.LoginAwas == null)
          {
              return NotFound();
          }
            var loginAwa = await _context.LoginAwas.FindAsync(id);

            if (loginAwa == null)
            {
                return NotFound();
            }

            return loginAwa;
        }

        // PUT: api/login/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutLoginAwa(string id, LoginAwa loginAwa)
        {
            if (id != loginAwa.Userid)
            {
                return BadRequest();
            }

            _context.Entry(loginAwa).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!LoginAwaExists(id))
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

        // POST: api/login
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        /*
        [HttpPost]
        public async Task<ActionResult<LoginAwa>> PostLoginAwa(LoginAwa loginAwa)
        {
          if (_context.LoginAwas == null)
          {
              return Problem("Entity set 'Ace42023Context.LoginAwas'  is null.");
          }
            _context.LoginAwas.Add(loginAwa);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (LoginAwaExists(loginAwa.Userid))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetLoginAwa", new { id = loginAwa.Userid }, loginAwa);
        }
        */
        // DELETE: api/login/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteLoginAwa(string id)
        {
            if (_context.LoginAwas == null)
            {
                return NotFound();
            }
            var loginAwa = await _context.LoginAwas.FindAsync(id);
            if (loginAwa == null)
            {
                return NotFound();
            }

            _context.LoginAwas.Remove(loginAwa);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool LoginAwaExists(string id)
        {
            return (_context.LoginAwas?.Any(e => e.Userid == id)).GetValueOrDefault();
        }

        [HttpPost]
        public async Task<ActionResult<LoginAwa>> postauthenticate(string username,string password)
        {
          if (_context.LoginAwas == null)
          {
              return Problem("Entity set 'Ace42023Context.LoginAwas'  is null.");
          }
            //_context.LoginAwas.Add(loginAwa);
            try
            {
                //await _context.SaveChangesAsync();
                System.Console.WriteLine("Done");
                if(isvaliduser(username,password)==true)
                {
                    
                    return Ok("Login successful");
                }
                else
                {
                    return BadRequest("Invalid username and password");
                }
            }
            catch (Exception)
            {
                if (LoginAwaExists(username))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return BadRequest();
        }
        [HttpPost]
        [Route("register")]
        public async Task<ActionResult<LoginAwa>> postauthenticate(LoginAwa loginAwa)
        {
          if (_context.LoginAwas == null)
          {
              return Problem("Entity set 'Ace42023Context.LoginAwas'  is null.");
          }
            
            try
            {
                
                if(loginAwa.Userid!="" && loginAwa.Username!="" && loginAwa.Pword!="" && loginAwa.Phonenumber!="")
                {
                    System.Console.WriteLine("asdasdasdddddddddddddddddddddddddddddgggggggggggggggg");
                    loginAwa.Pword=get_hash(loginAwa.Pword).ToString();
                    _context.LoginAwas.Add(loginAwa);
                    await _context.SaveChangesAsync();
                    return Ok("Your id has been created");
                }
                else
                {
                    return BadRequest("Please fill all the fields correctly");
                }
            }
            catch (Exception)
            {
                if (LoginAwaExists(loginAwa.Userid))
                {
                    return BadRequest("Try with a different user-id");
                }
                else
                {
                    throw;
                }
            }

            return BadRequest();
        }
        private bool isvaliduser(string userid,string password)
        {
            try
            {
                foreach(var i in _context.LoginAwas)
                {
                //System.Console.WriteLine(i.Userid+"    "+i.Pword);
                
                    if(i.Userid==userid && get_hash(password)==Convert.ToInt32(i.Pword))
                    {
                    
                        return true;
                    }
                }
                return false;
            }
            catch(Exception e)
            {
                //System.Console.WriteLine(e.ToString());
                return false;
            }

            return false;
        }
    }
}
