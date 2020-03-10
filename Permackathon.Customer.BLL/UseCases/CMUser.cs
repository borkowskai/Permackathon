using Permackathon.Common.CustomersManager.Interfaces.IRepositories;
using Permackathon.Common.CustomersManager.Interfaces.UseCases;
using Permackathon.Common.CustomersManager.TransferObject;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Permackaathon.Customer.BLL.UseCases
{
    // TODO 07. Create UseCase, CmUser
    // TODO 07.A.   add the constructor with the repository in parameter
    public class CMUser : ICMUser
    {
        private readonly ICustomerRepository customerRepository;

        public CMUser (ICustomerRepository customerRepository)
        {
            this.customerRepository = customerRepository ?? throw new ArgumentNullException(nameof(customerRepository));
        }

        public List<CustomerTO> GetAllCustomers()
        {
            return customerRepository.GetAll().ToList();
         }

        public CustomerTO GetCustomerById(int Id)
        {
            return customerRepository.GetById(Id);
        }
    }
}
