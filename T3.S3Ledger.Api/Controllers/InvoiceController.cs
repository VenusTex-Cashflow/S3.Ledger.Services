using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Threading.Tasks;
using T3.S3Ledger.Api.Data.Repository.Interface;
using T3.S3Ledger.Api.Models;

namespace T3.S3Ledger.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InvoiceController : ControllerBase
    {
        private readonly IMediator _mediator;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public InvoiceController(IMediator mediator, IUnitOfWork unitOfWork, IMapper mapper)
        {
            _mediator = mediator;
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }


        [HttpGet]
        public async Task<IActionResult> GetInvoices()
        {
            var invoices = await _unitOfWork.Invoice.GetAllAsync();
            return Ok(invoices);
        }


        [HttpGet("{id}")]
        public async Task<ActionResult> GetInvoice(long id)
        {
            var invoice = await _unitOfWork.Invoice.GetFirstOrDefaultAsync(i => i.Id == id);

            if (invoice == null)
            {
                return NotFound();
            }

            return Ok(invoice);
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created, Type = typeof(long))]
        [ProducesResponseType(StatusCodes.Status401Unauthorized, Type = typeof(string))]
        [ProducesResponseType(StatusCodes.Status404NotFound, Type = typeof(string))]
        [ProducesResponseType(StatusCodes.Status400BadRequest, Type = typeof(string))]
        [ProducesResponseType(StatusCodes.Status500InternalServerError, Type = typeof(string))]
        public async Task<ActionResult<long>> CreateInvoice(InvoiceModel invoiceModel)
        {
            try
            {
                var invoice = _mapper.Map<Data.Entities.Invoice>(invoiceModel);
                await _unitOfWork.Invoice.AddAsync(invoice);
                await _unitOfWork.SaveAsync();
                return CreatedAtAction("CreateInvoice", invoice.Id);
            }
            catch (Exception ex)
            {
                int x = 0;
            }
            return null;
        }

        [HttpPut]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(bool))]
        [ProducesResponseType(StatusCodes.Status401Unauthorized, Type = typeof(string))]
        [ProducesResponseType(StatusCodes.Status404NotFound, Type = typeof(string))]
        [ProducesResponseType(StatusCodes.Status400BadRequest, Type = typeof(string))]
        [ProducesResponseType(StatusCodes.Status500InternalServerError, Type = typeof(string))]
        public async Task<ActionResult<bool>> PutInvoice(InvoiceModel invoiceModel)
        {
            try
            {
                var invoice = _mapper.Map<Data.Entities.Invoice>(invoiceModel);
                _unitOfWork.Invoice.Update(invoice);
                await _unitOfWork.SaveAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                var result = await InvoiceExists(invoiceModel.Id);

                if (!result)
                {
                    return NotFound("No record found");
                }

                throw;
            }

            return Ok(true);
        }

        [HttpDelete("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(bool))]
        [ProducesResponseType(StatusCodes.Status401Unauthorized, Type = typeof(string))]
        [ProducesResponseType(StatusCodes.Status404NotFound, Type = typeof(string))]
        [ProducesResponseType(StatusCodes.Status400BadRequest, Type = typeof(string))]
        [ProducesResponseType(StatusCodes.Status500InternalServerError, Type = typeof(string))]
        public async Task<ActionResult<bool>> DeleteInvoice(long id)
        {
            var invoice = await _unitOfWork.Invoice.GetAsync(id);
            if (invoice == null)
            {
                return NotFound();
            }

            _unitOfWork.Invoice.Remove(invoice);
            await _unitOfWork.SaveAsync();

            return Ok(true);
        }

        private async Task<bool> InvoiceExists(long id)
        {
            return await _unitOfWork.Invoice.GetAsync(id) != null;
        }
    }
}
