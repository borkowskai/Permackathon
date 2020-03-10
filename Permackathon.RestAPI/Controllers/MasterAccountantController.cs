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
    [Route("api/[controller]")]
    [ApiController]
    public class MasterAccountantController : ControllerBase
    {
        public MasterAccountantController(FinancialContext ctx, IFMUnitOfWork uow, IMasterAccountant patrick)
        {
            this._Context = ctx;
            this._Service = patrick;
            this._Uow = uow;
        }
        private readonly FinancialContext _Context;
        private readonly IFMUnitOfWork _Uow;
        private readonly IMasterAccountant _Service;
        // POST: api/Accountant
        [HttpPost]
        public IActionResult AddPredictionData([FromBody] PredictionTO predictionData)
        {
            var done = _Service.AddEffectiveData(predictionData);
            return Ok(done);
        }


        //===================================== Methods from UserController
        // POST: api/Accountant
        [HttpPost]
        public RedirectToActionResult AddEffectiveData([FromBody] EffectiveTO effectiveData)
        {
            return RedirectToAction("AddEffectiveData", "AccountantController", effectiveData);
        }

        //===================================== Methods from UserController
        // GET: api/MasterAccountant
        [HttpGet]
        public IEnumerable<EffectiveTO> GetEffectives()
        {
            return _Service.GetAllEffectives();
        }

        // GET: api/MasterAccountant
        [HttpGet]
        public IEnumerable<PredictionTO> GetPredictions()
        {
            return _Service.GetAllPredictions();
        }
    }
}
