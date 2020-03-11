using Microsoft.EntityFrameworkCore;
using Permackathon.Common.IssuesManager.Entities;
using Permackathon.Common.IssuesManager.Interfaces.IRepositories;
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
        public SectorEF Add(SectorEF Entity)
        {
            if (Entity is null)
            {
                throw new ArgumentNullException(nameof(Entity));
            }

            var sector = Entity;
            var result = issuesContext.Sectors.Add(sector);
            issuesContext.SaveChanges();
            return result.Entity;
        }

        public IEnumerable<SectorEF> GetAll()
        {
            return issuesContext.Sectors
            .AsNoTracking()
            .Select(r => r).ToList();
        }

        public SectorEF GetById(int Id)
        {
            var sector = issuesContext.Sectors
           .AsNoTracking()
           .FirstOrDefault(c => c.Id == Id);

            if (sector is null)
            {
                throw new KeyNotFoundException($"No effective with ID={Id} was found.");
            }

            return sector;
        }

        public bool Remove(SectorEF entity)
        {
            if (entity is null)
            {
                throw new ArgumentNullException(nameof(entity));
            }

            return Remove(entity.Id);
        }

        public bool Remove(int Id)
        {
            var sector = issuesContext.Sectors.FirstOrDefault(c => c.Id == Id);

            if (sector == null)
            {
                throw new KeyNotFoundException($"CommentRepository. Delete(commentId = {Id}) no record to delete.");
            }
            var removedSector = issuesContext.Sectors.Remove(sector);
            return removedSector.State == EntityState.Deleted;
        }

        public SectorEF Update(SectorEF Entity)
        {
            if (Entity is null)
            {
                throw new ArgumentNullException(nameof(Entity));
            }

            return issuesContext
                .Sectors
                .Update(Entity)
                .Entity
                ;
        }
    }
}
