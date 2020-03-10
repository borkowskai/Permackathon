﻿using Permackathon.Common.FinancialManager.Interfaces.IRepositories;
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

        public MasterAccountant(IFMUnitOfWork iFSUnitOfWork)
        {
            this.unitOfWork = iFSUnitOfWork ?? throw new System.ArgumentNullException(nameof(iFSUnitOfWork));
        }
        public PredictionTO AddEffectiveData(PredictionTO predictionData)
        {
            throw new NotImplementedException();
        }

        public EffectiveTO AddEffectiveData(EffectiveTO effectiveData)
        {
            throw new NotImplementedException();
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
