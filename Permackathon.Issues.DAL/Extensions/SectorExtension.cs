using Permackathon.Common.IssuesManager.TransferObjects;
using Permackathon.Issues.DAL.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Permackathon.Issues.DAL.Extensions
{
    public static class SectorExtension
    {
        public static SectorTO ToTransferObject(this SectorEF issue)
        {
            if (issue is null)
                throw new ArgumentNullException(nameof(issue));

            return new SectorTO
            {
                Id = issue.Id,
                Name =issue.Name

            };
        }

        public static SectorEF ToEF(this SectorTO issue)
        {
            if (issue is null)
                throw new ArgumentNullException(nameof(issue));

            return new SectorEF
            {
                //Id = issue.Id,
                Name = issue.Name
            };
        }
    }
}
