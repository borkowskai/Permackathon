﻿using Permackathon.Common.FinancialManager.TransferObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace Permackathon.Common.FinancialManager.Interfaces.UseCases
{
    public interface IMasterAccountant : IAccountant
    {
        PredictionTO AddEffectiveData(PredictionTO predictionData);
    }
}
