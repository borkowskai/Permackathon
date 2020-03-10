using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Permackathon.Customer.DAL.Entities
{
	// TODO 01.	Create Entity Data Model, EF Core Code First
	// TODO 01.A.	Install nuget Microsoft.EntityFrameworkCore
	// TODO 01.B.	Install nuget Microsoft.EntityFrameworkCore.SqlServer
	// TODO 01.C.	Install nuget Microsoft.EntityFrameWorkCore.Tools
	// TODO 01.D.	Create entities, CustomerEF
	public class CustomerEF
    {
		[Key]
		public int IdCustomer { get; set; }
		public string Name { get; set; }
		public string Delivery_Street { get; set; }
		public int Delivery_StreetNumber { get; set; }
		public int Delivery_ZipCode { get; set; }
		public int Delivery_Location { get; set; }
		public string Delivery_Information { get; set; }
		public string Contact_FirstName { get; set; }
		public string Contact_LastName { get; set; }
		public string Contact_Role { get; set; }
		public double Contact_Tel { get; set; }
		public string Contact_Mail { get; set; }
		public int Price_WhiteOyster { get; set; }
		public int Price_PoplarPholiote { get; set; }
		public int Price_OysterMushrooms { get; set; }
	}
}
