using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainModel.Models
{
	internal class Order
	{
		int Id
		{
			get; set;
		}
		string Sidemark
		{
			get; set;
		}
		string OrderId
		{
			get; set;
		}
		bool InProduction
		{
			get; set;
		}
		bool IsShipped
		{
			get; set;
		}
		string CreationDate
		{
			get; set;
		}
		string DeliveryAddress
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
