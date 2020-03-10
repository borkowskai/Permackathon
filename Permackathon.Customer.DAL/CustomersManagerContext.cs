using Microsoft.EntityFrameworkCore;
using Permackathon.Customer.DAL.Entities;
using System;

namespace Permackathon.Customer.DAL
{
	// TODO 01.E.	Create Context by deriving the DbContext, Constructor and DbSet properties
	// TODO 01.G.	Add a migration, pmc => add-migration
	// TODO 01.H	Create the Database, pmc => Update-DataBase
	public class CustomersManagerContext : DbContext
	{
		// Contructor
		public CustomersManagerContext() 
		{ }

		public CustomersManagerContext(DbContextOptions<CustomersManagerContext> options) : base(options)
		{ }

		// TODO 01.F.	Put the ConnectionString in the OnConfiguring method
		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			if (optionsBuilder is null)
				throw new ArgumentNullException(nameof(optionsBuilder));

			if (!optionsBuilder.IsConfigured)
				optionsBuilder.UseSqlServer(@"Data Source=HACKATHON-SRV1\HACKATHON;Initial Catalog=Wapiti;User ID=WapitiUser;Password=WapitiUser;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
		}

		// Entities
		public DbSet<CustomerEF> Customers { get; set; }

	}
}
