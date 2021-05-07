using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;
using T3.S3Ledger.Api.Data.Repository.Interface;
using T3.S3Ledger.Api.Models;

namespace T3.S3Ledger.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ChequeController : ControllerBase
    {
        private readonly IMediator _mediator;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public ChequeController(IMediator mediator, IUnitOfWork unitOfWork, IMapper mapper)
        {
            _mediator = mediator;
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        // GET: api/Cheque
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ChequeModel>>> GetCheques()
        {
            var cheques = await _unitOfWork.Cheque.GetAllAsync();
            return Ok(cheques);
        }

        // GET: api/Cheque/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ChequeModel>> GetCheque(long id)
        {
            var cheque = await _unitOfWork.Cheque.GetAsync(id);

            if (cheque == null)
            {
                return NotFound();
            }

            return Ok(cheque);
        }

        // PUT: api/Cheque/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        //[HttpPut("{id}")]
        //public async Task<IActionResult> PutChequeModel(long id, ChequeModel chequeModel)
        //{
        //    if (id != chequeModel.Id)
        //    {
        //        return BadRequest();
        //    }

        //    _context.Entry(chequeModel).State = EntityState.Modified;

        //    try
        //    {
        //        await _context.SaveChangesAsync();
        //    }
        //    catch (DbUpdateConcurrencyException)
        //    {
        //        if (!ChequeModelExists(id))
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

        // POST: api/Cheque
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<ChequeModel>> CreateCheque(ChequeModel chequeModel)
        {
            var cheque = _mapper.Map<Data.Entities.Cheque>(chequeModel);
            await _unitOfWork.Cheque.AddAsync(cheque);
            await _unitOfWork.SaveAsync();

            return CreatedAtAction("CreateCheque", cheque.Id);
        }

        // DELETE: api/Cheque/5
        //[HttpDelete("{id}")]
        //public async Task<IActionResult> DeleteChequeModel(long id)
        //{
        //    var chequeModel = await _context.ChequeModel.FindAsync(id);
        //    if (chequeModel == null)
        //    {
        //        return NotFound();
        //    }

        //    _context.ChequeModel.Remove(chequeModel);
        //    await _context.SaveChangesAsync();

        //    return NoContent();
        //}

        //private bool ChequeModelExists(long id)
        //{
        //    return _context.ChequeModel.Any(e => e.Id == id);
        //}
    }
}
