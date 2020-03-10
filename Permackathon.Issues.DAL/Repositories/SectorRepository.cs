using Microsoft.EntityFrameworkCore;
using Permackathon.Common.IssuesManager.Interfaces.IRepositories;
using Permackathon.Common.IssuesManager.TransferObjects;
using Permackathon.Issues.DAL.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Permackathon.Issues.DAL.Repositories
{
    public class SectorRepository : ISectorRepository
    {

        private readonly IssuesContext issuesContext;

        public SectorRepository(IssuesContext issuesContext)
        {
            this.issuesContext = issuesContext ?? throw new ArgumentNullException($"{nameof(issuesContext)} in SectorRepository");
        }
        public SectorTO Add(SectorTO Entity)
        {
            if (Entity is null)
            {
                throw new ArgumentNullException(nameof(Entity));
            }

            var sector = Entity.ToEF();
            var result = issuesContext.Sectors.Add(sector);
            issuesContext.SaveChanges();
            return result.Entity.ToTransferObject();
        }

        public IEnumerable<SectorTO> GetAll()
        {
            return issuesContext.Sectors
            .AsNoTracking()
            .Select(r => r.ToTransferObject()).ToList();
        }

        public SectorTO GetById(int Id)
        {
            var sector = issuesContext.Sectors
           .AsNoTracking()
           .FirstOrDefault(c => c.SectorId == Id);

            if (sector is null)
            {
                throw new KeyNotFoundException($"No effective with ID={Id} was found.");
            }

            return sector.ToTransferObject();
        }

        public bool Remove(SectorTO entity)
        {
            if (entity is null)
            {
                throw new ArgumentNullException(nameof(entity));
            }

            return Remove(entity.SectorId);
        }

        public bool Remove(int Id)
        {
            var sector = issuesContext.Sectors.FirstOrDefault(c => c.SectorId == Id);

            if (sector == null)
            {
                throw new KeyNotFoundException($"CommentRepository. Delete(commentId = {Id}) no record to delete.");
            }
            var removedSector = issuesContext.Sectors.Remove(sector);
            return removedSector.State == EntityState.Deleted;
        }

        public SectorTO Update(SectorTO Entity)
        {
            if (Entity is null)
            {
                throw new ArgumentNullException(nameof(Entity));
            }

            return issuesContext
                .Sectors
                .Update(Entity.ToEF())
                .Entity
                .ToTransferObject();
        }
    }
}
