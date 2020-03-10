using System;
using System.Collections.Generic;
using System.Text;

namespace Permackathon.Common.IssuesManager.Interfaces.IRepositories
{
    public interface IIssuesUnitOfWork : IDisposable
    {
        IIssuesRepository IssuesRepository { get; }
        ILocationRepository LocationRepository { get; }
        ISectorRepository SectorRepository{ get; }
        IUserRepository UserRepository { get; }
        void Save();
    }
}
