using Permackaathon.Customer.BLL.UseCases;
using Permackathon.Common.CustomersManager.Interfaces.IRepositories;
using Permackathon.Common.CustomersManager.Interfaces.UseCases;
using Permackathon.Common.CustomersManager.TransferObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Permackathon.Customer.BLL.UseCases
{
	public class CMCommercial : CMUser, ICMCommercial
	{
		private readonly ICustomerRepository customerRepository;

		public CMCommercial(ICustomerRepository customerRepository) : base(customerRepository)
		{
			this.customerRepository = customerRepository ?? throw new ArgumentNullException(nameof(customerRepository));
		}

		public CustomerTO AddCustomer(CustomerTO Customer)
		{
			return customerRepository.Add(Customer);
		}

		public void DeleteCustomer(int Id)
		{
			var deleted = customerRepository.Remove(Id);
		}

		public CustomerTO UpdateCustomer(CustomerTO Customer)
		{
			return customerRepository.Update(Customer);
		}

		public IEnumerable<CustomerTO> GetAllCustomers()
		{
			return customerRepository.GetAll().ToList();
		}

		public CustomerTO GetCustomerById(int Id)
		{
			return customerRepository.GetById(Id);
		}
	}
}
