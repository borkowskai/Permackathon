using Permackathon.Common.IssuesManager.TransferObjects;
using Permackathon.Issues.DAL.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Permackathon.Issues.DAL.Extensions
{
    public static class IssueExtension
    {
            public static IssueTO ToTransferObject(this IssueEF issue)
            {
                return new IssueTO
                {
                   Id = issue.Id,
                   Creator = issue.Creator.ToTransferObject(),
                   Resolver = issue.Resolver.ToTransferObject(),
                   Priority =issue.Priority,
                   Name = issue.Name,
                   DeadLine = issue.DeadLine,
                   IsCompleted = issue.IsCompleted,
                   IsSoftDeleted =issue.IsSoftDeleted,
                   Location = issue.Location.ToTransferObject(),
                   Sector =issue.Sector.ToTransferObject(),
                   Description =issue.Description

                };
            }

            public static IssueEF ToEF(this IssueTO issue)
            {
                if (issue is null)
                    throw new ArgumentNullException(nameof(issue));

                return new IssueEF
                {
                    //Id = issue.Id,
                    Creator = issue.Creator.ToEF(),
                    Resolver = issue.Resolver.ToEF(),
                    Priority = issue.Priority,
                    Name = issue.Name,
                    DeadLine = issue.DeadLine,
                    IsCompleted = issue.IsCompleted,
                    IsSoftDeleted = issue.IsSoftDeleted,
                    Location = issue.Location.ToEF(),
                    Sector = issue.Sector.ToEF(),
                    Description = issue.Description
                };
            }
        

    }
}
