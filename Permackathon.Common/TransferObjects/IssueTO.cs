using System;
using System.Collections.Generic;
using System.Text;

namespace Permackathon.Common.TransferObjects
{
    public class IssueTO
    {
        public int IssueId { get; set; }
        public UserTO Creator { get; set; }
        public UserTO Resolver { get; set; }
        public Priority Priority { get; set; }
        public string Name { get; set; }
        public DateTime DeadLine { get; set; }
        public bool IsCompleted { get; set; }
        public bool IsSoftDeleted { get; set; }
        public LocationTO Location { get; set; }
        public SectorTO Sector { get; set; }
        