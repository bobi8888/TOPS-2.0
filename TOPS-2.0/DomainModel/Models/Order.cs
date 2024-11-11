using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainModel.Models
{
	public class Order
	{
		public int Id
		{
			get; set;
		}
		public string Sidemark
		{
			get; set;
		}
		public string OrderId
		{
			get; set;
		}
		public bool InProduction
		{
			get; set;
		}
		public bool IsShipped
		{
			get; set;
		}
		public string CreationDate
		{
			get; set;
		}
		public string DeliveryAddress
		{
			get; set;
		}

		public Order(){}
		public Order(string sm, string orderId, int? id = -1){
			if (id != -1)
				Id = (int) id;
			Sidemark = sm;
			OrderId = orderId;
			//create the logic to assign a creation date
		}
	}
}
