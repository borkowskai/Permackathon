using Microsoft.EntityFrameworkCore;
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

        public IssueTO AddIssue(IssueTO Issue)
            => unitOfWork.IssuesRepository.Add(Issue);

        public IssueTO BecomeResolver(int IssueId, int UserId)
        {
            IssueTO issue = unitOfWork.IssuesRepository.GetById(IssueId);
            UserTO user = unitOfWork.UserRepository.GetById(UserId);
            issue.Resolver = user;
            var result =unitOfWork.IssuesRepository.Update(issue);
            return result;
        }

        public IEnumerable<IssueTO> GetIssues()
            => unitOfWork.IssuesRepository.GetAll();

        public IssueTO MarkAsArchived(int IssueId, int UserId)
        {
            IssueTO issue = unitOfWork.IssuesRepository.GetById(IssueId);
            UserTO user = unitOfWork.UserRepository.GetById(UserId);
            issue.IsSoftDeleted = true;
            var result =unitOfWork.IssuesRepository.Update(issue);
            return result;
        }

        public IssueTO MarkAsCompleted(int IssueId, int UserId)
        {
            IssueTO issue = unitOfWork.IssuesRepository.GetById(IssueId);
            UserTO user = unitOfWork.UserRepository.GetById(UserId);
            issue.IsCompleted = true;
            var result = unitOfWork.IssuesRepository.Update(issue);
            return result;
        }
    }
}
