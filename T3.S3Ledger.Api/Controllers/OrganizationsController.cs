using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;
using T3.S3Ledger.Api.Commands.Organization;
using T3.S3Ledger.Api.Models;
using T3.S3Ledger.Api.Queries.Organization;

namespace T3.S3Ledger.Api.Controllers
{
    /// <summary>
    /// Manage Organization information
    /// </summary>
    //[ApiVersion("v1")]
    [Route("api/ledgerservice/[controller]")]
    [ApiController]
    public class OrganizationsController : ControllerBase
    {
        private readonly IMediator _mediator;

        public OrganizationsController(IMediator mediator)
        {
            _mediator = mediator;
        }

        /// <summary>
        /// Get an organization by given organization identifire
        /// </summary>
        /// <param name="organizationId">Organization identifire</param>
        /// <returns></returns>
        [HttpGet("{organizationId}")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(OrganizationModel))]
        [ProducesResponseType(StatusCodes.Status401Unauthorized, Type = typeof(string))]
        [ProducesResponseType(StatusCodes.Status404NotFound, Type = typeof(string))]
        [ProducesResponseType(StatusCodes.Status400BadRequest, Type = typeof(string))]
        [ProducesResponseType(StatusCodes.Status500InternalServerError, Type = typeof(string))]
        public async Task<IActionResult> Get(int organizationId)
        {
            if (organizationId <= 0)
            {
                return BadRequest("Organization Id is mandatory.");
            }

            var request = new GetOrganizationByIdQuery
            {
                Id = organizationId
            };
            var result = await _mediator.Send(request);

            if (result == null)
            {
                return NotFound("No Organization found");
            }

            return Ok(result);
        }

        /// <summary>
        /// Get all organizations
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(IEnumerable<OrganizationModel>))]
        [ProducesResponseType(StatusCodes.Status401Unauthorized, Type = typeof(string))]
        [ProducesResponseType(StatusCodes.Status404NotFound, Type = typeof(string))]
        [ProducesResponseType(StatusCodes.Status400BadRequest, Type = typeof(string))]
        [ProducesResponseType(StatusCodes.Status500InternalServerError, Type = typeof(string))]
        public async Task<IActionResult> Get()
        {
            //System User only
            var result = await _mediator.Send(new GetAllOrganizationQuery());

            if (result == null)
            {
                return NotFound("No Organization found");
            }

            return Ok(result);
        }

        //// PUT: api/Organization/5
        //// To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        //[HttpPut("{id}")]
        //public async Task<IActionResult> PutOrganizationModel(int id, OrganizationModel organizationModel)
        //{
        //    if (id != organizationModel.Id)
        //    {
        //        return BadRequest();
        //    }

        //    _context.Entry(organizationModel).State = EntityState.Modified;

        //    try
        //    {
        //        await _context.SaveChangesAsync();
        //    }
        //    catch (DbUpdateConcurrencyException)
        //    {
        //        if (!OrganizationModelExists(id))
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

        /// <summary>
        /// Create an Organization
        /// </summary>
        /// <param name="organizationId"></param>
        /// <param name="organizationModel"></param>
        /// <returns></returns>
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created, Type = typeof(int))]
        [ProducesResponseType(StatusCodes.Status401Unauthorized, Type = typeof(string))]
        [ProducesResponseType(StatusCodes.Status404NotFound, Type = typeof(string))]
        [ProducesResponseType(StatusCodes.Status400BadRequest, Type = typeof(string))]
        [ProducesResponseType(StatusCodes.Status500InternalServerError, Type = typeof(string))]
        public async Task<ActionResult<int>> CreateOrganization(
            [FromHeader] int organizationId,
            [FromBody] OrganizationModel organizationModel)
        {
            var request = new CreateOrganizationCommand
            {
                Organization = organizationModel
            };
            var result = await _mediator.Send(request);

            return CreatedAtAction("CreateOrganization", result.Id);
        }

        //// DELETE: api/Organization/5
        //[HttpDelete("{id}")]
        //public async Task<IActionResult> DeleteOrganizationModel(int id)
        //{
        //    var organizationModel = await _context.OrganizationModel.FindAsync(id);
        //    if (organizationModel == null)
        //    {
        //        return NotFound();
        //    }

        //    _context.OrganizationModel.Remove(organizationModel);
        //    await _context.SaveChangesAsync();

        //    return NoContent();
        //}

        //private bool OrganizationModelExists(int id)
        //{
        //    return _context.OrganizationModel.Any(e => e.Id == id);
        //}
    }
}
