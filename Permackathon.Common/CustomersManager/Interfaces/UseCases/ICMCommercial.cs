using Permackathon.Common.CustomersManager.TransferObject;
using System;
using System.Collections.Generic;
using System.Text;

namespace Permackathon.Common.CustomersManager.Interfaces.UseCases
{
	public interface ICMCommercial : ICMUser
	{
		// Create
		CustomerTO AddCustomer(CustomerTO Customer);
		// Update
		CustomerTO UpdateCustomer(CustomerTO Customer);
		// Delete - byId
		void DeleteCustomer(int Id);
	}
}
