using Permackathon.Common.IssuesManager.Interfaces.IRepositories;
using Permackathon.Common.IssuesManager.TransferObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace Permackathon.Issues.DAL.Repositories
{
    public class IssuesRepository : IIssuesRepository
    {
        private readonly IssuesContext issuesContext;

        public IssuesRepository(IssuesContext issuesContext)
        {
            this.issuesContext = issuesContext ?? throw new ArgumentNullException($"{nameof(issuesContext)} in EffectiveRepository");
        }
        public IssueTO Add(IssueTO Entity)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<IssueTO> GetAll()
        {
            throw new NotImplementedException();
        }

        public IssueTO GetById(int Id)
        {
            throw new NotImplementedException();
        }

        public bool Remove(IssueTO entity)
        {
            throw new NotImplementedException();
        }

        public bool Remove(int Id)
        {
            throw new NotImplementedException();
        }

        public IssueTO Update(IssueTO Entity)
        {
            throw new NotImplementedException();
        }
    }
}
