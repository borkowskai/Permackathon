using Permackathon.Common.FinancialManager.Interfaces.IRepositories;
using Permackathon.Common.FinancialManager.Interfaces.UseCases;
using Permackathon.Common.FinancialManager.TransferObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace Permackathon.Financial.BLL.UseCases
{
    public class Accountant : IAccountant
    {
        private readonly IFMUnitOfWork unitOfWork;

        public Accountant(IFMUnitOfWork iFMUnitOfWork)
        {
            this.unitOfWork = iFMUnitOfWork ?? throw new System.ArgumentNullException(nameof(iFMUnitOfWork));
        }

        public EffectiveTO AddEffectiveData(EffectiveTO effectiveData)
        { 
            var result = unitOfWork.EffectiveRepository.Add(effectiveData);
            unitOfWork.Save();
            return result;
        }

        public IEnumerable<EffectiveTO> GetAllEffectives()
             => unitOfWork.EffectiveRepository.GetAll();

        public IEnumerable<PredictionTO> GetAllPredictions()
            => unitOfWork.PredictionRepository.GetAll();
    }
}

