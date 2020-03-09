using Permackathon.Common.FinancialManager.Interfaces.UseCases;
using Permackathon.Common.FinancialManager.TransferObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace Permackathon.Financial.BLL.UseCases
{
    public class FMUser : IFMUser
    {
        public List<EffectiveTO> GetAllEffectives()
        {
            throw new NotImplementedException();
        }

        public List<PredictionTO> GetAllPredictions()
        {
            throw new NotImplementedException();
        }
    }
}
