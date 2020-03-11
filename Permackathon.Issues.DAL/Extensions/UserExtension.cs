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
            return new UserTO
            {
                Id = issue.Id,
                Name = issue.Name
            };
        }

        public static UserEF ToEF(this UserTO user)
        {
            if (user is null)
                throw new ArgumentNullException(nameof(user));

            return new UserEF
            {
                //Id = issue.Id,
                Name = user.Name
            };
        }
    }
}
