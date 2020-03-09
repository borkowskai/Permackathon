using Permackathon.Common.FinancialManager.Interfaces.IRepositories;
using Permackathon.Financial.DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace Permackathon.Financial.DAL
{
    public class FinancialUnitOfWork : IFMUnitOfWork
    {
        private readonly FinancialContext financialContext;

        public FinancialUnitOfWork(FinancialContext context)
        {
            this.financialContext = context ?? throw new ArgumentNullException(nameof(context));
        }

        private IEffectiveRepository effectiveRepository;
        public IEffectiveRepository EffectiveRepository
            => effectiveRepository ??= new EffectiveRepository(financialContext);

        private IPredictionRepository predictionRepository;
        public IPredictionRepository PredictionRepository
            => predictionRepository ??= new PredictionRepository(financialContext);

        public void Save()
        {
            financialContext.SaveChanges();
        }

        private bool disposed = false;
        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    financialContext.Dispose();
                }
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
