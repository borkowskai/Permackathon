using Permackathon.Common.CustomersManager.TransferObject;
using Permackathon.Customer.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Permackathon.Customer.DAL.Extensions
{
	// TODO 03.	Create Extensions methods
	public static class CustomerExtension
	{
		// TODO 03.A.	Entity -> TransferObject
		public static CustomerTO ToTransferObject(this CustomerEF Entity)
		{
			if (Entity is null) throw new ArgumentException(nameof(Entity));

			return new CustomerTO
			{
				IdCustomer = Entity.IdCustomer,
				Name = Entity.Name,

				Contact_FirstName = Entity.Contact_FirstName,
				Contact_LastName = Entity.Contact_LastName,
				Contact_Role = Entity.Contact_Role,
				Contact_Mail = Entity.Contact_Mail,
				Contact_Tel = Entity.Contact_Tel,

				Delivery_Street = Entity.Delivery_Street,
				Delivery_StreetNumber = Entity.Delivery_StreetNumber,
				Delivery_ZipCode = Entity.Delivery_ZipCode,
				Delivery_Location = Entity.Delivery_Location,
				Delivery_Information = Entity.Delivery_Information,

				Price_WhiteOyster = Entity.Price_WhiteOyster,
				Price_OysterMushrooms = Entity.Price_OysterMushrooms,
				Price_PoplarPholiote = Entity.Price_PoplarPholiote
			};

		}

		// TODO 03.B	TransferObject -> Entity
		public static CustomerEF ToEntity(this CustomerTO TransferObject)
		{
			if (TransferObject is null) throw new ArgumentNullException(nameof(TransferObject));

			return new CustomerEF
			{
				IdCustomer = TransferObject.IdCustomer,
				Name = TransferObject.Name,

				Contact_FirstName = TransferObject.Contact_FirstName,
				Contact_LastName = TransferObject.Contact_LastName,
				Contact_Role = TransferObject.Contact_Role,
				Contact_Mail = TransferObject.Contact_Mail,
				Contact_Tel = TransferObject.Contact_Tel,

				Delivery_Street = TransferObject.Delivery_Street,
				Delivery_StreetNumber = TransferObject.Delivery_StreetNumber,
				Delivery_ZipCode = TransferObject.Delivery_ZipCode,
				Delivery_Location = TransferObject.Delivery_Location,
				Delivery_Information = TransferObject.Delivery_Information,

				Price_WhiteOyster = TransferObject.Price_WhiteOyster,
				Price_OysterMushrooms = TransferObject.Price_OysterMushrooms,
				Price_PoplarPholiote = TransferObject.Price_PoplarPholiote
			};
		}
	}
}
