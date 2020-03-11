using Permackathon.Common.Enums;
using Permackathon.Common.IssuesManager.Interfaces.IRepositories;
using Permackathon.Common.IssuesManager.TransferObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace Permackathon.Issues.DAL.Models
{
    public class IssueEF 
    {
        public int Id { get; set; }
        public UserEF Creator { get; set; }
        public UserEF Resolver { get; set; }
        public Priority Priority { get; set; }
        public string Name { get; set; }
        public DateTime DeadLine { get; set; }
        public bool IsCompleted { get; set; }
        public bool IsSoftDeleted { get; set; }
        public LocationEF Location { get; set; }
        public SectorEF Sector { get; set; }
        public string Description { get; set; }
    }
}
