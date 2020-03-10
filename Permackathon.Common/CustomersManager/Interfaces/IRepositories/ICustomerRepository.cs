using Permackathon.Common.AccessHelpers;
using Permackathon.Common.CustomersManager.TransferObject;
using System;
using System.Collections.Generic;
using System.Text;

namespace Permackathon.Common.CustomersManager.Interfaces.IRepositories
{
	// TODO 04.	Create ICustomerRepository, implement by IRepository
	public interface ICustomerRepository : IRepository<CustomerTO, int>, IDisposable
	{
		void Save();
	}
}
