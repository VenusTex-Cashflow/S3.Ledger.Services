using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using T3.S3Ledger.Api.Data;
using T3.S3Ledger.Api.Models;

namespace T3.S3Ledger.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SalesmanController : ControllerBase
    {
        private readonly AppDbContext _context;

        public SalesmanController(AppDbContext context)
        {
            _context = context;
        }

        // GET: api/Salesman
        //[HttpGet]
        //public async Task<ActionResult<IEnumerable<SalesmanModel>>> GetSalesmanModel()
        //{
        //    return await _context.Salesman.ToListAsync();
        //}

        //// GET: api/Salesman/5
        //[HttpGet("{id}")]
        //public async Task<ActionResult<SalesmanModel>> GetSalesmanModel(long id)
        //{
        //    var salesmanModel = await _context.SalesmanModel.FindAsync(id);

        //    if (salesmanModel == null)
        //    {
        //        return NotFound();
        //    }

        //    return salesmanModel;
        //}

        //// PUT: api/Salesman/5
        //// To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        //[HttpPut("{id}")]
        //public async Task<IActionResult> PutSalesmanModel(long id, SalesmanModel salesmanModel)
        //{
        //    if (id != salesmanModel.Id)
        //    {
        //        return BadRequest();
        //    }

        //    _context.Entry(salesmanModel).State = EntityState.Modified;

        //    try
        //    {
        //        await _context.SaveChangesAsync();
        //    }
        //    catch (DbUpdateConcurrencyException)
        //    {
        //        if (!SalesmanModelExists(id))
        //        {
        //            return NotFound();
        //        }
        //        else
        //        {
        //            throw;
        //        }
        //    }

        //    return NoContent();
        //}

        //// POST: api/Salesman
        //// To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        //[HttpPost]
        //public async Task<ActionResult<SalesmanModel>> PostSalesmanModel(SalesmanModel salesmanModel)
        //{
        //    _context.SalesmanModel.Add(salesmanModel);
        //    await _context.SaveChangesAsync();

        //    return CreatedAtAction("GetSalesmanModel", new { id = salesmanModel.Id }, salesmanModel);
        //}

        //// DELETE: api/Salesman/5
        //[HttpDelete("{id}")]
        //public async Task<IActionResult> DeleteSalesmanModel(long id)
        //{
        //    var salesmanModel = await _context.SalesmanModel.FindAsync(id);
        //    if (salesmanModel == null)
        //    {
        //        return NotFound();
        //    }

        //    _context.SalesmanModel.Remove(salesmanModel);
        //    await _context.SaveChangesAsync();

        //    return NoContent();
        //}

        //private bool SalesmanModelExists(long id)
        //{
        //    return _context.SalesmanModel.Any(e => e.Id == id);
        //}
    }
}
