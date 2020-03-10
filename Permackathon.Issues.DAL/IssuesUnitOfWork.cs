using Permackathon.Common.IssuesManager.Interfaces.IRepositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace Permackathon.Issues.DAL
{
    public class IssuesUnitOfWork : IIssuesUnitOfWork
    {
        public IIssuesRepository IssuesRepository
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public IIssuesRepository LocationRepository
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public IIssuesRepository SectorRepository
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public IIssuesRepository UserRepository
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public void Save()
        {
            throw new NotImplementedException();
        }
    }
}
