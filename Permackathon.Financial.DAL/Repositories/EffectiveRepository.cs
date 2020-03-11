using Microsoft.EntityFrameworkCore;
using Permackathon.Common.FinancialManager.Interfaces.IRepositories;
using Permackathon.Common.FinancialManager.TransferObjects;
using Permackathon.Financial.DAL.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Permackathon.Financial.DAL.Repositories
{
    public class EffectiveRepository : IEffectiveRepository
    {
        private readonly FinancialContext financialContext;

        public EffectiveRepository(FinancialContext financialContext)
        {
            this.financialContext = financialContext ?? throw new ArgumentNullException($"{nameof(financialContext)} in EffectiveRepository");
        }

        public EffectiveTO Add(EffectiveTO Entity)
        {
            if (Entity is null)
            {
                throw new ArgumentNullException(nameof(Entity));
            }

            var effective = Entity.ToEF();
            var result = financialContext.Effectives.Add(effective);
            financialContext.SaveChanges();
            return result.Entity.ToTransferObject();
        }

        public IEnumerable<EffectiveTO> GetAll()
        {
            return financialContext.Effectives
                .AsNoTracking()
                .Select(r => r.ToTransferObject()).ToList();
        }

        public EffectiveTO GetById(int Id)
        {
            var effective = financialContext.Effectives
               .AsNoTracking()
               .FirstOrDefault(c => c.Id == Id);

            if (effective is null)
            {
                throw new KeyNotFoundException($"No effective with ID={Id} was found.");
            }

            return effective.ToTransferObject();
        }

        public bool Remove(EffectiveTO entity)
        {
            if (entity is null)
            {
                throw new ArgumentNullException(nameof(entity));
            }

            return Remove(entity.Id);
        }

        public bool Remove(int Id)
        {
            var effective = financialContext.Effectives.FirstOrDefault(c => c.Id == Id);

            if (effective == null)
            {
                throw new KeyNotFoundException($"CommentRepository. Delete(commentId = {Id}) no record to delete.");
            }
            var removedEffectives = financialContext.Effectives.Remove(effective);
            return removedEffectives.State == EntityState.Deleted;
        }

        public EffectiveTO Update(EffectiveTO Entity)
        {
            if (Entity is null)
            {
                throw new ArgumentNullException(nameof(Entity));
            }

            return financialContext
                .Effectives
                .Update(Entity.ToEF())
                .Entity
                .ToTransferObject();
        }
    }
}
