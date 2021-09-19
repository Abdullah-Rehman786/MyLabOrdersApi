using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MyLabOrdersApi.Models;

namespace MyLabOrdersApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WebPatreqsController : ControllerBase
    {
        private readonly LabContext _context;

        public WebPatreqsController(LabContext context)
        {
            _context = context;
        }

        // GET: api/WebPatreqs
        [HttpGet]
        public async Task<ActionResult<IEnumerable<WebPatreq>>> GetWebPatreqs()
        {
            return await _context.WebPatreqs.ToListAsync();
        }

        // GET: api/WebPatreqs/5
        [HttpGet("{id}")]
        public async Task<ActionResult<WebPatreq>> GetWebPatreq(int id)
        {
            var webPatreq = await _context.WebPatreqs.FindAsync(id);

            if (webPatreq == null)
            {
                return NotFound();
            }

            return webPatreq;
        }

        // PUT: api/WebPatreqs/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutWebPatreq(int id, WebPatreq webPatreq)
        {
            if (id != webPatreq.Accno)
            {
                return BadRequest();
            }

            _context.Entry(webPatreq).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!WebPatreqExists(id))
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

        // POST: api/WebPatreqs
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<WebPatreq>> PostWebPatreq(WebPatreq webPatreq)
        {
            _context.WebPatreqs.Add(webPatreq);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetWebPatreq),
                new { id = webPatreq.Accno },
                webPatreq);
        }

        // DELETE: api/WebPatreqs/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteWebPatreq(int id)
        {
            var webPatreq = await _context.WebPatreqs.FindAsync(id);
            if (webPatreq == null)
            {
                return NotFound();
            }

            _context.WebPatreqs.Remove(webPatreq);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool WebPatreqExists(int id)
        {
            return _context.WebPatreqs.Any(e => e.Accno == id);
        }
    }
}
