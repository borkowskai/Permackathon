using Microsoft.EntityFrameworkCore;
using Permackathon.Common.FinancialManager.Interfaces.IRepositories;
using Permackathon.Common.FinancialManager.TransferObjects;
using Permackathon.Financial.DAL.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Permackathon.Financial.DAL.Repositories
{
    public class PredictionRepository : IPredictionRepository
    {
        private readonly FinancialContext financialContext;

        public PredictionRepository(FinancialContext financialContext)
        {
            this.financialContext = financialContext ?? throw new ArgumentNullException($"{nameof(financialContext)} in PredictionRepository");
        }

        public PredictionTO Add(PredictionTO Entity)
        {
            if (Entity is null)
            {
                throw new ArgumentNullException(nameof(Entity));
            }

            var prediction = Entity.ToEF();
            var result = financialContext.Predictions.Add(prediction);
            financialContext.SaveChanges();
            return result.Entity.ToTransferObject();
        }

        public IEnumerable<PredictionTO> GetAll()
        {
            return financialContext.Predictions
                .AsNoTracking()
                .Select(r => r.ToTransferObject()).ToList();
        }

        public PredictionTO GetById(int Id)
        {
            var prediction = financialContext.Predictions
               .AsNoTracking()
               .FirstOrDefault(c => c.Id == Id);

            if (prediction is null)
            {
                throw new KeyNotFoundException($"No prediction with ID={Id} was found.");
            }

            return prediction.ToTransferObject();
        }

        public bool Remove(PredictionTO entity)
        {
            if (entity is null)
            {
                throw new ArgumentNullException(nameof(entity));
            }

            return Remove(entity.Id);
        }

        public bool Remove(int Id)
        {
            var prediction = financialContext.Predictions.FirstOrDefault(c => c.Id == Id);

            if (prediction == null)
            {
                throw new KeyNotFoundException($"CommentRepository. Delete(commentId = {Id}) no record to delete.");
            }
            var removedPredictions = financialContext.Predictions.Remove(prediction);
            return removedPredictions.State == EntityState.Deleted;
        }

        public PredictionTO Update(PredictionTO Entity)
        {
            if (Entity is null)
            {
                throw new ArgumentNullException(nameof(Entity));
            }

            return financialContext
                .Predictions
                .Update(Entity.ToEF())
                .Entity
                .ToTransferObject();
        }
    }
}
