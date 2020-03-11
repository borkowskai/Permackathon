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
    public class FinancialController : ControllerBase
    {
        public FinancialController(FinancialContext ctx, IFMUnitOfWork uow, IFMUser user, IAccountant accountant, IMasterAccountant masterAccountant)
        {
            this._Context = ctx;
            this._UserRole = user;
            this._Uow = uow;
            this._AccountantRole = accountant;
            this._MasterAccountantRole = masterAccountant;
        }
        private readonly FinancialContext _Context;
        private readonly IFMUnitOfWork _Uow;
        private readonly IFMUser _UserRole;
        private readonly IAccountant _AccountantRole;
        private readonly IMasterAccountant _MasterAccountantRole;

        [HttpGet]
        public IEnumerable<EffectiveTO> GetEffectives()
        {
            return _UserRole.GetAllEffectives();
        }

        [HttpGet]
        public IEnumerable<PredictionTO> GetPredictions()
        {
            return _UserRole.GetAllPredictions();
        }
        [HttpPost]
        public EffectiveTO AddEffectiveData([FromBody] EffectiveTO effectiveData)
        {
            return _AccountantRole.AddEffectiveData(effectiveData);
        }
        [HttpPost]
        public PredictionTO AddPredictionData([FromBody] PredictionTO predictionData)
        {
            return _MasterAccountantRole.AddEffectiveData(predictionData); 
        }
    }
}