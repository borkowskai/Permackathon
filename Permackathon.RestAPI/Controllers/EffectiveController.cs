using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Permackathon.Common.FinancialManager.Interfaces.IRepositories;
using Permackathon.Common.FinancialManager.Interfaces.UseCases;
using Permackathon.Common.FinancialManager.TransferObjects;
using Permackathon.Financial.BLL.UseCases;
using Permackathon.Financial.DAL;
using Permackathon.Financial.DAL.Repositories;

namespace Permackathon.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EffectiveController : ControllerBase
    {
        public EffectiveController(FinancialContext ctx, IFMUnitOfWork uow, IFMUser patrick)
        {
            this._Context = ctx;
            this._Service = patrick;
            this._Uow = uow;
        }
        private readonly FinancialContext _Context;
        private readonly IFMUnitOfWork _Uow;
        private readonly IFMUser _Service;

        // GET: api/Effective
        [HttpGet]
        public IEnumerable<EffectiveTO> Get()
        {
            return _Service.GetAllEffectives();
        }

        // GET: api/Effective/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Effective
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }
    }
}
