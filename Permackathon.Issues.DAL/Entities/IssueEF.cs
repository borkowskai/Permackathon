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
        public UserTO Creator { get; set; }
        public UserTO Resolver { get; set; }
        public Priority Priority { get; set; }
        public string Name { get; set; }
        public DateTime DeadLine { get; set; }
        public bool IsCompleted { get; set; }
        public bool IsSoftDeleted { get; set; }
        public LocationTO Location { get; set; }
        public SectorTO Sector { get; set; }
        public string Description { get; set; }
    }
}
