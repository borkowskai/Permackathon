using Permackathon.Common.TransferObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace Permackathon.Common.Interfaces.IRepositories
{
    public interface IIssueRepository : IRepository<IssueTO, int>
    {
    }
}
