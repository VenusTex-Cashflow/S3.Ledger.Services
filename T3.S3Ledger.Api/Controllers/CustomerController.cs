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
    public class CustomerController : ControllerBase
    {
        private readonly IMediator _mediator;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public CustomerController(IMediator mediator, IUnitOfWork unitOfWork, IMapper mapper)
        {
            _mediator = mediator;
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        [HttpGet]
        //[Produces("application/json")]
        public async Task<IActionResult> GetCustomers()
        {
            //CustomerQuery query = new CustomerQuery();
            //var taskQuery = await _mediator.Send(query);
            var customers = await _unitOfWork.Customer.GetAllAsync();
            return Ok(customers);
        }

        [HttpGet("include")]
        public async Task<IActionResult> GetCustomersWithBillsPayments()
        {
            //CustomerQuery query = new CustomerQuery();
            //var taskQuery = await _mediator.Send(query);
            var customers = await _unitOfWork.Customer.GetAllAsync(includeProperties: "Invoices,PaymentReceipts", noTracking: true);
            return Ok(customers);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult> GetCustomer(long id)
        {
            var customer = await _unitOfWork.Customer.GetFirstOrDefaultAsync(c => c.Id == id, includeProperties: "Invoices,PaymentReceipts");

            if (customer == null)
            {
                return NotFound();
            }

            return Ok(customer);
        }

        //[HttpGet("{customerId}/Invoice")]
        //[ProducesResponseType(StatusCodes.Status200OK, Type = typeof(IActionResult))]
        //[ProducesResponseType(StatusCodes.Status401Unauthorized, Type = typeof(string))]
        //[ProducesResponseType(StatusCodes.Status404NotFound, Type = typeof(string))]
        //[ProducesResponseType(StatusCodes.Status400BadRequest, Type = typeof(string))]
        //[ProducesResponseType(StatusCodes.Status500InternalServerError, Type = typeof(string))]
        //public async Task<ActionResult> GetCustomerInvoice(long customerId)
        //{
        //    var invoices = await _unitOfWork.Invoice.GetInvoiceByCustomer(customerId, Enums.InvoiceStatus.Outstanding);

        //    if (invoices == null)
        //    {
        //        return NotFound();
        //    }

        //    return Ok(invoices);
        //}

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created, Type = typeof(long))]
        [ProducesResponseType(StatusCodes.Status401Unauthorized, Type = typeof(string))]
        [ProducesResponseType(StatusCodes.Status404NotFound, Type = typeof(string))]
        [ProducesResponseType(StatusCodes.Status400BadRequest, Type = typeof(string))]
        [ProducesResponseType(StatusCodes.Status500InternalServerError, Type = typeof(string))]
        public async Task<ActionResult<long>> CreateCustomer(CustomerModel customerModel)
        {
            var customer = _mapper.Map<Data.Entities.Customer>(customerModel);
            await _unitOfWork.Customer.AddAsync(customer);
            await _unitOfWork.SaveAsync();

            return CreatedAtAction("CreateCustomer", customer.Id);
        }

        [HttpPut]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(bool))]
        [ProducesResponseType(StatusCodes.Status401Unauthorized, Type = typeof(string))]
        [ProducesResponseType(StatusCodes.Status404NotFound, Type = typeof(string))]
        [ProducesResponseType(StatusCodes.Status400BadRequest, Type = typeof(string))]
        [ProducesResponseType(StatusCodes.Status500InternalServerError, Type = typeof(string))]
        public async Task<ActionResult<bool>> PutCustomer(CustomerModel customerModel)
        {
            try
            {
                var customer = _mapper.Map<Data.Entities.Customer>(customerModel);
                _unitOfWork.Customer.Update(customer);
                await _unitOfWork.SaveAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                var result = await CustomerExists(customerModel.Id);

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
        public async Task<ActionResult<bool>> DeleteCustomer(long id)
        {
            try
            {
                var customer = await _unitOfWork.Customer.GetAsync(id);
                if (customer == null)
                {
                    return NotFound();
                }

                _unitOfWork.Customer.Remove(customer);
                await _unitOfWork.SaveAsync();

            }
            catch (DbUpdateConcurrencyException)
            {
                var result = await CustomerExists(id);

                if (!result)
                {
                    return NotFound("No record found");
                }

                throw;
            }
            catch (Exception ex)
            {

            }



            return Ok(true);
        }

        private async Task<bool> CustomerExists(long id)
        {
            return await _unitOfWork.Customer.GetAsync(id) != null;
        }
    }
}
