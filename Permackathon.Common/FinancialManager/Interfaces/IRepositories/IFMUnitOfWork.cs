using System;
using System.Collections.Generic;
using System.Text;

namespace Permackathon.Common.FinancialManager.Interfaces.IRepositories
{
    public interface IFMUnitOfWork : IDisposable
    {
        IPredictionRepository PredictionRepository { get; }
        IEffectiveRepository EffectiveRepository { get; }

        void Save();
    }
}
