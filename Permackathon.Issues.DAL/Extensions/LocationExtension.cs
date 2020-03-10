using Permackathon.Common.IssuesManager.TransferObjects;
using Permackathon.Issues.DAL.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Permackathon.Issues.DAL.Extensions
{
    public static class LocationExtension
    {
        public static LocationTO ToTransferObject(this LocationEF issue)
        {
            if (issue is null)
                throw new ArgumentNullException(nameof(issue));

            return new LocationTO
            {
                LocationId = issue.LocationId,
                Name = issue.Name

            };
        }

        public static LocationEF ToEF(this LocationTO issue)
        {
            if (issue is null)
                throw new ArgumentNullException(nameof(issue));

            return new LocationEF
            {
                LocationId = issue.LocationId,
                Name = issue.Name
            };
        }

    }
}
