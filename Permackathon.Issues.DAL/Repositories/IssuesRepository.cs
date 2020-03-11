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
    public class IssuesRepository : IIssuesRepository
    {
        private readonly IssuesContext issuesContext;

        public IssuesRepository(IssuesContext issuesContext)
        {
            this.issuesContext = issuesContext ?? throw new ArgumentNullException($"{nameof(issuesContext)} in IssueRepository");
        }
        public IssueTO Add(IssueTO Entity)
        {
            if (Entity is null)
            {
                throw new ArgumentNullException(nameof(Entity));
            }

            var issue = Entity.ToEF();
            var result = issuesContext.Issues.Add(issue);
            issuesContext.SaveChanges();
            return result.Entity.ToTransferObject();
        }

        public IEnumerable<IssueTO> GetAll()
        {
            return issuesContext.Issues
            .AsNoTracking()
            .Select(r => r.ToTransferObject()).ToList();
        }

        public IssueTO GetById(int Id)
        {
            var issue = issuesContext.Issues
               .AsNoTracking()
               .FirstOrDefault(c => c.IssueId == Id);

            if (issue is null)
            {
                throw new KeyNotFoundException($"No effective with ID={Id} was found.");
            }

            return issue.ToTransferObject();
        }

        public bool Remove(IssueTO entity)
        {
            if (entity is null)
            {
                throw new ArgumentNullException(nameof(entity));
            }

            return Remove(entity.IssueId);
        }

        public bool Remove(int Id)
        {
            var issue = issuesContext.Issues.FirstOrDefault(c => c.IssueId == Id);

            if (issue == null)
            {
                throw new KeyNotFoundException($"CommentRepository. Delete(commentId = {Id}) no record to delete.");
            }
            var removedIssue = issuesContext.Issues.Remove(issue);
            return removedIssue.State == EntityState.Deleted;
        }

        public IssueTO Update(IssueTO Entity)
        {
            if (Entity is null)
            {
                throw new ArgumentNullException(nameof(Entity));
            }
            var result = issuesContext
                .Issues
                .Update(Entity.ToEF())
                .Entity;
            issuesContext.SaveChanges();
            return result.ToTransferObject();
        }
    }
}
