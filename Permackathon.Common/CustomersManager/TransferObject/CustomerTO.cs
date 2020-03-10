using System;
using System.Collections.Generic;
using System.Text;

namespace Permackathon.Common.CustomersManager.TransferObject
{
	// TODO 02.	Create TransferObject
	public class CustomerTO
	{
		public int IdCustomer { get; set; }
		public string Name { get; set; }
		public string Delivery_Street { get; set; }
		public int Delivery_StreetNumber { get; set; }
		public int Delivery_ZipCode { get; set; }
		public string Delivery_Location { get; set; }
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
