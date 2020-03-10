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

        //Implementing Methods
        public IssueTO AddIssue(IssueTO Issue)
            => unitOfWork.IssuesRepository.Add(Issue);

        public bool BecomeResolver(int IssueId, int UserId)
        {
            IssueTO issue = unitOfWork.IssuesRepository.GetById(IssueId);
            UserTO user = unitOfWork.UserRepository.GetById(UserId);
           //seulent un utilisateur peut etre attache, nous n'avons pas de table intermediaire
            issue.Resolver = user;
            unitOfWork.IssuesRepository.Update(issue);
            return true;
            //TODO exception if needed
        }

        public IEnumerable<IssueTO> GetIssues()
            => unitOfWork.IssuesRepository.GetAll();


        public bool MarkAsArchived(int IssueId, int UserId)
        {
            //je comprends que cela correspond a is SoftDeleted
            IssueTO issue = unitOfWork.IssuesRepository.GetById(IssueId);

            //tu es sure que User Id est necessaire?          
            //UserTO user = unitOfWork.UserRepository.GetById(UserId);
            issue.IsSoftDeleted = true;
            unitOfWork.IssuesRepository.Update(issue);
            //TODO verifier si necessaire retourner qqch => void
            return true;
        }

        public bool MarkAsCompleted(int IssueId, int UserId)
        {
            IssueTO issue = unitOfWork.IssuesRepository.GetById(IssueId);
            UserTO user = unitOfWork.UserRepository.GetById(UserId);
            issue.IsCompleted = true;
            unitOfWork.IssuesRepository.Update(issue);
            return true;
        }
    }
}
