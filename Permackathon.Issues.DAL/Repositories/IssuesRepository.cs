using Microsoft.EntityFrameworkCore;
using Permackathon.Common.IssuesManager.Entities;
using Permackathon.Common.IssuesManager.Interfaces.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Permackathon.Issues.DAL.Repositories
{
    public class IssuesRepository : IIssuesRepository
    {
        private readonly IssuesContext issuesContext;

        public IssuesRepository(IssuesContext issuesContext)
        {
            this.issuesContext = issuesContext ?? throw new ArgumentNullException($"{nameof(issuesContext)} in IssueRepository");
        }
        public IssueEF Add(IssueEF Entity)
        {
            if (Entity is null)
            {
                throw new ArgumentNullException(nameof(Entity));
            }

            var result = issuesContext.Issues.Add(Entity);
            issuesContext.SaveChanges();
            return result.Entity;
        }

        public IEnumerable<IssueEF> GetAll()
        {
            return issuesContext.Issues
                .Include(x => x.Creator)
                .Include(x => x.Resolver)
                .Include(x => x.Location)
                .Include(x=> x.Sector)
            .Select(r => r).ToList();
        }

        public IssueEF GetById(int Id)
        {
            var issue = issuesContext.Issues
               .AsNoTracking()
               .FirstOrDefault(c => c.Id == Id);

            if (issue is null)
            {
                throw new KeyNotFoundException($"No effective with ID={Id} was found.");
            }

            return issue;
        }

        public bool Remove(IssueEF entity)
        {
            if (entity is null)
            {
                throw new ArgumentNullException(nameof(entity));
            }

            return Remove(entity.Id);
        }

        public bool Remove(int Id)
        {
            var issue = issuesContext.Issues.FirstOrDefault(c => c.Id == Id);

            if (issue == null)
            {
                throw new KeyNotFoundException($"CommentRepository. Delete(commentId = {Id}) no record to delete.");
            }
            var removedIssue = issuesContext.Issues.Remove(issue);
            return removedIssue.State == EntityState.Deleted;
        }

        public IssueEF Update(IssueEF Entity)
        {
            if (Entity is null)
            {
                throw new ArgumentNullException(nameof(Entity));
            }

            return issuesContext
              .Issues
              .Update(Entity)
              .Entity;
        }
    }
}
