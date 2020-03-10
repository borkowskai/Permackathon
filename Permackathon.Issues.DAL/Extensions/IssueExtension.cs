using Permackathon.Common.IssuesManager.TransferObjects;
using Permackathon.Issues.DAL.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Permackathon.Issues.DAL.Extensions
{
    public static class IssueExtension
    {
            public static IssueTO ToTransfertObject(this IssueEF issue)
            {
                if (issue is null)
                    throw new ArgumentNullException(nameof(issue));

                return new IssueTO
                {
                   //Map
                };
            }

            public static IssueEF ToEF(this IssueTO issue)
            {
                if (issue is null)
                    throw new ArgumentNullException(nameof(issue));

                return new IssueEF
                {
                    //Map
                };
            }
        

    }
}
