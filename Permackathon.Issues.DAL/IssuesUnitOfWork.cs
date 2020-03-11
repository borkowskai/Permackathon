using Permackathon.Common.IssuesManager.Interfaces.IRepositories;
using Permackathon.Issues.DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace Permackathon.Issues.DAL
{
    public class IssuesUnitOfWork : IIssuesUnitOfWork
    {
        private readonly IssuesContext issuesContext;

        public IssuesUnitOfWork(IssuesContext context)
        {
            this.issuesContext = context ?? throw new ArgumentNullException(nameof(context));
        }

        private IIssuesRepository issuesRepository;
        public IIssuesRepository IssuesRepository
            => issuesRepository ??= new IssuesRepository(issuesContext);

        private ILocationRepository locationRepository;
        public ILocationRepository LocationRepository
            => locationRepository ??= new LocationRepository(issuesContext);

        private ISectorRepository sectorRepository;
        public ISectorRepository SectorRepository
            => sectorRepository ??= new SectorRepository(issuesContext);

        private IUserRepository userRepository;
        public IUserRepository UserRepository
            => userRepository ??= new UserRepository(issuesContext);


        public void Save()
        {
            issuesContext.SaveChanges();
        }
        private bool disposed = false;
        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    issuesContext.Dispose();
                }
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
