﻿using Permackathon.Common.IssuesManager.TransferObjects;
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
                if (issue is null)
                    throw new ArgumentNullException(nameof(issue));

                return new IssueTO
                {
                   IssueId = issue.IssueId,
                   Creator = issue.Creator,
                   Resolver = issue.Resolver,
                   Priority =issue.Priority,
                   Name = issue.Name,
                   DeadLine = issue.DeadLine,
                   IsCompleted = issue.IsCompleted,
                   IsSoftDeleted =issue.IsSoftDeleted,
                   Location = issue.Location,
                   Sector =issue.Sector,
                   Description =issue.Description

                };
            }

            public static IssueEF ToEF(this IssueTO issue)
            {
                if (issue is null)
                    throw new ArgumentNullException(nameof(issue));

                return new IssueEF
                {
                    IssueId = issue.IssueId,
                    Creator = issue.Creator,
                    Resolver = issue.Resolver,
                    Priority = issue.Priority,
                    Name = issue.Name,
                    DeadLine = issue.DeadLine,
                    IsCompleted = issue.IsCompleted,
                    IsSoftDeleted = issue.IsSoftDeleted,
                    Location = issue.Location,
                    Sector = issue.Sector,
                    Description = issue.Description
                };
            }
        

    }
}
