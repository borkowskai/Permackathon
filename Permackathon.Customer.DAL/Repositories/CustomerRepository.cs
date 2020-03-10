using Microsoft.EntityFrameworkCore;
using Permackathon.Common.CustomersManager.Interfaces.IRepositories;
using Permackathon.Common.CustomersManager.TransferObject;
using Permackathon.Customer.DAL.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Permackathon.Customer.DAL.Repositories
{
	public class CustomerRepository : ICustomerRepository
	{
		// TODO 05.	Create CustomerRepository implement by ICustomerepositrory
		// TODO 05.A	add the constructor with the context in parmater
		// TOFO 05.B	implement the repository methods

		private readonly CustomersManagerContext customersManagerContext;

		public CustomerRepository(CustomersManagerContext customerManagerContext)
		{
			this.customersManagerContext = customerManagerContext ?? throw new ArgumentNullException(nameof(customerManagerContext));
		}

		public CustomerTO Add(CustomerTO Entity)
		{
			if (Entity is null)
				throw new ArgumentNullException(nameof(Entity));

			return customersManagerContext.Customers.Add(Entity.ToEntity()).Entity.ToTransferObject();
		}

		public IEnumerable<CustomerTO> GetAll()
		{
			return customersManagerContext.Customers.AsNoTracking().Select(c => c.ToTransferObject()).ToList();
		}

		public CustomerTO GetById(int Id)
		{
			return customersManagerContext.Customers.AsNoTracking().FirstOrDefault(c => c.IdCustomer == Id).ToTransferObject();
		}

		public bool Remove(CustomerTO entity)
		{
			var formDeleted = customersManagerContext.Customers.Remove(entity.ToEntity());
			return formDeleted.State == EntityState.Deleted;
		}

		public bool Remove(int Id)
		{
			var formToDelete = customersManagerContext.Customers.FirstOrDefault(c => c.IdCustomer == Id);
			var formDeleted = customersManagerContext.Customers.Remove(formToDelete);
			return formDeleted.State == EntityState.Deleted;
		}

		public CustomerTO Update(CustomerTO Entity)
		{
			if (Entity is null)
			{
				throw new ArgumentNullException(nameof(Entity));
			}

			return customersManagerContext.Customers.Update(Entity.ToEntity()).Entity.ToTransferObject();
		}

		public void Save()
		{
			customersManagerContext.SaveChanges();
		}

		private bool disposed = false;
		protected virtual void Dispose(bool disposing)
		{
			if (!this.disposed)
			{
				if (disposing)
				{
					customersManagerContext.Dispose();
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
