using Permackathon.Common.FinancialManager.Interfaces.IRepositories;
using Permackathon.Common.FinancialManager.Interfaces.UseCases;
using Permackathon.Common.FinancialManager.TransferObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace Permackathon.Financial.BLL.UseCases
{
    public class FMUser : IFMUser
    {
        private readonly IFMUnitOfWork unitOfWork;

        public FMUser(IFMUnitOfWork iFSUnitOfWork)
        {
            this.unitOfWork = iFSUnitOfWork ?? throw new System.ArgumentNullException(nameof(iFSUnitOfWork));
        }
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
