using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainModel.Models
{
	public class Customer
	{
		int Id {get; set;}
		string FirstName
		{
			get; set;
		}
		string LastName
		{
			get; set;
		}
		string CustomerType
		{
			get; set;
		}
		int CompanyId
		{
			get; set;
		}
		string PhoneNumber
		{
			get; set;
		}
		float Discount
		{
			get; set;
		}
		string CreationDate
		{
			get; set;
		}

		public Customer(){}
		public Customer(string first, string last, string type, int companyId, int? id = -1)
		{
			if (id != -1)
				Id = (int) id;
			FirstName = first; 
			LastName = last;
			CustomerType = type;
			CompanyId = companyId;
		}
	}
}
