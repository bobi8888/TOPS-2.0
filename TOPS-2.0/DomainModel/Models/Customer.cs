using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainModel.Models
{
	public class Customer
	{
		public int Id {get; set;}
		public string FirstName
		{
			get; set;
		}
		public string LastName
		{
			get; set;
		}
		public string CustomerType
		{
			get; set;
		}
		public int CompanyId
		{
			get; set;
		}
		public string PhoneNumber
		{
			get; set;
		}
		public float Discount
		{
			get; set;
		}
		public string CreationDate
		{
			get; set;
		}

		public Customer(){}
		public Customer(string first,string last,string type, int? id = -1)
		{
			if (id != -1)
				Id = (int) id;
			FirstName = first;
			LastName = last;
			CustomerType = type;
		}
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
