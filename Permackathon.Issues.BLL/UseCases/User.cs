using Microsoft.EntityFrameworkCore;
using Permackathon.Common.IssuesManager.Entities;
using Permackathon.Common.IssuesManager.Interfaces.IRepositories;
using Permackathon.Common.IssuesManager.Interfaces.UseCases;
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

        public IssueEF AddIssue(IssueEF Issue)
            => unitOfWork.IssuesRepository.Add(Issue);

        public IssueEF BecomeResolver(int IssueId, int UserId)
        {
            IssueEF issue = unitOfWork.IssuesRepository.GetById(IssueId);
            UserEF user = unitOfWork.UserRepository.GetById(UserId);
            issue.Resolver = user;
            var result =unitOfWork.IssuesRepository.Update(issue);
            return result;
        }

        public IEnumerable<IssueEF> GetIssues()
            => unitOfWork.IssuesRepository.GetAll();

        public IssueEF MarkAsArchived(int IssueId, int UserId)
        {
            IssueEF issue = unitOfWork.IssuesRepository.GetById(IssueId);
            UserEF user = unitOfWork.UserRepository.GetById(UserId);
            issue.IsSoftDeleted = true;
            var result =unitOfWork.IssuesRepository.Update(issue);
            return result;
        }

        public IssueEF MarkAsCompleted(int IssueId, int UserId)
        {
            IssueEF issue = unitOfWork.IssuesRepository.GetById(IssueId);
            UserEF user = unitOfWork.UserRepository.GetById(UserId);
            issue.IsCompleted = true;
            var result = unitOfWork.IssuesRepository.Update(issue);
            return result;
        }
    }
}
