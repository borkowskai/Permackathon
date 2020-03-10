using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Permackathon.Common.FinancialManager.Interfaces.IRepositories;
using Permackathon.Common.FinancialManager.Interfaces.UseCases;
using Permackathon.Common.FinancialManager.TransferObjects;
using Permackathon.Financial.DAL;

namespace Permackathon.API.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        public UserController(FinancialContext ctx, IFMUnitOfWork uow, IFMUser patrick)
        {
            this._Context = ctx;
            this._Service = patrick;
            this._Uow = uow;
        }
        private readonly FinancialContext _Context;
        private readonly IFMUnitOfWork _Uow;
        private readonly IFMUser _Service;

        // GET: api/User
        [HttpGet]
        public IEnumerable<EffectiveTO> GetEffectives()
        {
            return _Service.GetAllEffectives();
        }

        // GET: api/User
        [HttpGet]
        public IEnumerable<PredictionTO> GetPredictions()
        {
            return _Service.GetAllPredictions();
        }
    }
}
