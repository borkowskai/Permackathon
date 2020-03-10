using Permackathon.Common.CustomersManager.TransferObject;
using System;
using System.Collections.Generic;
using System.Text;

namespace Permackathon.Common.CustomersManager.Interfaces.UseCases
{
	// TODO 06.	Create Interface CMUser
	public interface ICMUser
	{
		// Read - All
		List<CustomerTO> GetAllCustomers();
		
		// Read - byId
		CustomerTO GetCustomerById(int Id);
	}
}
