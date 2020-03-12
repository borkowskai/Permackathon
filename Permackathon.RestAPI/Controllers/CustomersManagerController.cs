using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Permackathon.Common.CustomersManager.Interfaces.UseCases;
using Permackathon.Common.CustomersManager.TransferObject;
using Permackathon.Customer.DAL;

namespace Permackathon.API.Controllers
{
	[Route("api/[controller]/[action]")]
	[ApiController]
	public class CustomersManagerController : Controller
	{
		private readonly ICMCommercial commercial;
		private readonly ICMUser user;
		private readonly CustomersManagerContext context;

		public CustomersManagerController(CustomersManagerContext context, ICMCommercial commercial, ICMUser user)
		{
			this.commercial = commercial ?? throw new ArgumentNullException(nameof(commercial));
			this.user = user ?? throw new ArgumentNullException(nameof(user));
			this.context = context ?? throw new ArgumentNullException(nameof(context));
		}

		[HttpGet]
		public IEnumerable<CustomerTO> ComGetAll()
		{
			return commercial.GetAllCustomers();
		}

		[HttpGet]
		public IEnumerable<CustomerTO> UserGetAll()
		{
			return user.GetAllCustomers();
		}

		[HttpGet("{Id}")]
		[Route("comGetById")]
		public CustomerTO ComGetById(int Id)
		{
			return commercial.GetCustomerById(Id);
		}

		[HttpGet("{Id}")]
		public CustomerTO UserGetById(int Id)
		{
			return user.GetCustomerById(Id);
		}
	}
}