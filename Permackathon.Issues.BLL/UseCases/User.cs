using Permackathon.Common.IssuesManager.Interfaces.IRepositories;
using Permackathon.Common.IssuesManager.Interfaces.UseCases;
using Permackathon.Common.IssuesManager.TransferObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace Permackathon.Issues.BLL.UseCases
{
    public class User : IUser
    {

        //CTOR
        private readonly IIssuesUnitOfWork unitOfWork;

        public User(IIssuesUnitOfWork iIssuesUnitOfWork)
        {
            this.unitOfWork = iIssuesUnitOfWork ?? throw new System.ArgumentNullException(nameof(iIssuesUnitOfWork));
        }

        //Implementing Methods
        public IssueTO AddIssue(IssueTO Issue)
            => unitOfWork.IssuesRepository.Add(Issue);

        public bool BecomeResolver(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<IssueTO> GetIssues()
            => unitOfWork.IssuesRepository.GetAll();

        public bool MarkAsArchived(int id)
        {
            throw new NotImplementedException();
        }

        public bool MarkAsCompleted(int id)
        {
            throw new NotImplementedException();
        }
    }
}
