using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainModel.Models
{
	public class Company
	{
		public int Id { get; set; }
		public string Name
		{
			get; set;
		}
		public string Type
		{
			get; set;
		}
		public string State
		{
			get; set;
		}
		public string Address
		{
			get; set;
		}
		public string Zip
		{
			get; set;
		}
		public float Discount
		{
			get; set;
		}

		public Company(){}
		public Company(string name, string type, int? id = -1)
		{
			if (id != -1)
				Id = (int) id; 
			Name = name; 
			Type = type;
		}
	}
}
