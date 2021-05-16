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
    public class PaymentReceiptController : ControllerBase
    {
        private readonly IMediator _mediator;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public PaymentReceiptController(IMediator mediator, IUnitOfWork unitOfWork, IMapper mapper)
        {
            _mediator = mediator;
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> GetPaymentReceipts()
        {
            var payments = await _unitOfWork.PaymentReceipt.GetAllAsync();
            return Ok(payments);
        }


        [HttpGet("{id}")]
        public async Task<ActionResult> GetPaymentReceipt(long id)
        {
            var payment = await _unitOfWork.PaymentReceipt.GetFirstOrDefaultAsync(p => p.Id == id);

            if (payment == null)
            {
                return NotFound();
            }

            return Ok(payment);
        }


        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created, Type = typeof(long))]
        [ProducesResponseType(StatusCodes.Status401Unauthorized, Type = typeof(string))]
        [ProducesResponseType(StatusCodes.Status404NotFound, Type = typeof(string))]
        [ProducesResponseType(StatusCodes.Status400BadRequest, Type = typeof(string))]
        [ProducesResponseType(StatusCodes.Status500InternalServerError, Type = typeof(string))]
        public async Task<ActionResult<long>> CreatePaymentReceipt(PaymentReceiptModel paymentReceiptModel)
        {
            try
            {
                var payment = _mapper.Map<Data.Entities.PaymentReceipt>(paymentReceiptModel);
                await _unitOfWork.PaymentReceipt.AddAsync(payment);
                await _unitOfWork.SaveAsync();
                return CreatedAtAction("CreatePaymentReceipt", payment.Id);
            }
            catch (DbUpdateException ex)
            {


            }
            catch (Exception ex)
            {

            }

            return null;

        }


        [HttpPut]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(bool))]
        [ProducesResponseType(StatusCodes.Status401Unauthorized, Type = typeof(string))]
        [ProducesResponseType(StatusCodes.Status404NotFound, Type = typeof(string))]
        [ProducesResponseType(StatusCodes.Status400BadRequest, Type = typeof(string))]
        [ProducesResponseType(StatusCodes.Status500InternalServerError, Type = typeof(string))]
        public async Task<ActionResult<bool>> PutPaymentReceipt(PaymentReceiptModel paymentReceiptModel)
        {
            try
            {
                var payment = _mapper.Map<Data.Entities.PaymentReceipt>(paymentReceiptModel);
                _unitOfWork.PaymentReceipt.Update(payment);
                await _unitOfWork.SaveAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                var result = await PaymentReceiptExists(paymentReceiptModel.Id);

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
        public async Task<ActionResult<bool>> DeletePaymentReceipt(long id)
        {
            var payment = await _unitOfWork.PaymentReceipt.GetAsync(id);
            if (payment == null)
            {
                return NotFound();
            }

            _unitOfWork.PaymentReceipt.Remove(payment);
            await _unitOfWork.SaveAsync();

            return Ok(true);
        }

        private async Task<bool> PaymentReceiptExists(long id)
        {
            return await _unitOfWork.PaymentReceipt.GetAsync(id) != null;
        }
    }
}
