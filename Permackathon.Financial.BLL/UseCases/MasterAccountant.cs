using Permackathon.Common.FinancialManager.Interfaces.IRepositories;
using Permackathon.Common.FinancialManager.Interfaces.UseCases;
using Permackathon.Common.FinancialManager.TransferObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace Permackathon.Financial.BLL.UseCases
{
    public class MasterAccountant : IMasterAccountant
    {
        private readonly IFMUnitOfWork unitOfWork;

        public MasterAccountant(IFMUnitOfWork iFMUnitOfWork)
        {
            this.unitOfWork = iFMUnitOfWork ?? throw new System.ArgumentNullException(nameof(iFMUnitOfWork));
        }
        public PredictionTO AddEffectiveData(PredictionTO predictionData)
            => unitOfWork.PredictionRepository.Add(predictionData);

        public EffectiveTO AddEffectiveData(EffectiveTO effectiveData)
            => unitOfWork.EffectiveRepository.Add(effectiveData);

        public IEnumerable<EffectiveTO> GetAllEffectives()
            => unitOfWork.EffectiveRepository.GetAll();

        public IEnumerable<PredictionTO> GetAllPredictions()
            => unitOfWork.PredictionRepository.GetAll();
    }
}
