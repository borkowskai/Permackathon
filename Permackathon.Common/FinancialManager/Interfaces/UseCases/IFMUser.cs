using Permackathon.Common.FinancialManager.TransferObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace Permackathon.Common.FinancialManager.Interfaces.UseCases
{
    public interface IFMUser
    {
        List<PredictionTO> GetAllPredictions();
        List<EffectiveTO> GetAllEffectives();
    }
}
