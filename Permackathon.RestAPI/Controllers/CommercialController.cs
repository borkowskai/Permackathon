using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Permackathon.Common.CustomersManager.Interfaces.UseCases;
using Permackathon.Common.CustomersManager.TransferObject;
using Permackathon.Customer.DAL;

namespace Permackathon.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CommercialController : ControllerBase
    {
        private readonly ICMCommercial commercial;

        public CommercialController(ICMCommercial commercial)
        {
            this.commercial = commercial ?? throw new ArgumentNullException(nameof(commercial));
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<CustomerTO>> GetCustomerById(int id)
        {
            var result = commercial.GetCustomerById(id);

            if (result is null)
                return NotFound();

            return result;
        }
        
    }
}