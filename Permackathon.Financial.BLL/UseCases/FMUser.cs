using Permackathon.Common.FinancialManager.Interfaces.IRepositories;
using Permackathon.Common.FinancialManager.Interfaces.UseCases;
using Permackathon.Common.FinancialManager.TransferObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Permackathon.Financial.BLL.UseCases
{
    public class FMUser : IFMUser
    {
        private readonly IFMUnitOfWork unitOfWork;

        public FMUser(IFMUnitOfWork iFMUnitOfWork)
        {
            this.unitOfWork = iFMUnitOfWork ?? throw new System.ArgumentNullException(nameof(iFMUnitOfWork));
        }
        public IEnumerable<EffectiveTO> GetAllEffectives()
            => unitOfWork.EffectiveRepository.GetAll();
        
        public IEnumerable<PredictionTO> GetAllPredictions()
            => unitOfWork.PredictionRepository.GetAll();
    }
}
