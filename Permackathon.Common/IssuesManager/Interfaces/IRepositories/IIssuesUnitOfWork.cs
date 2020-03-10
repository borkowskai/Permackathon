using System;
using System.Collections.Generic;
using System.Text;

namespace Permackathon.Common.IssuesManager.Interfaces.IRepositories
{
    public interface IIssuesUnitOfWork : IDisposable
    {
        IIssuesRepository IssuesRepository { get; }
        IIssuesRepository LocationRepository { get; }
        IIssuesRepository SectorRepository{ get; }
        IIssuesRepository UserRepository { get; }
        void Save();
    }
}
