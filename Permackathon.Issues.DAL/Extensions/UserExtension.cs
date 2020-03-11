using Permackathon.Common.IssuesManager.TransferObjects;
using Permackathon.Issues.DAL.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Permackathon.Issues.DAL.Extensions
{
    public static class UserExtension
    {
        public static UserTO ToTransferObject(this UserEF issue)
        {
            if (issue is null)
                throw new ArgumentNullException(nameof(issue));

            return new UserTO
            {
                UserId = issue.UserId,
                Name = issue.Name

            };
        }

        public static UserEF ToEF(this UserTO issue)
        {
            if (issue is null)
                throw new ArgumentNullException(nameof(issue));

            return new UserEF
            {
                UserId = issue.UserId,
                Name = issue.Name
            };
        }
    }
}
