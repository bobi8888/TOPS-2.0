using DataAccessLayer.Contracts;
using DomainModel.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;

namespace DataAccessLayer.Repositories
{
	public class CustomersRepository :ICustomersRepository
	{
		public async Task AddCustomer(Customer newCustomer)
		{
			string connectionString = ConfigurationManager.ConnectionStrings ["TOPS2.0ConnectionString"].ConnectionString;

			string query = "insert into Customers (FirstName, LastName, CustomerType) values (@FirstName, @LastName, @CustomerType)";

			using (IDbConnection connection = new SqlConnection(connectionString))
			{
				connection.Execute(query,newCustomer);
			}
		}

	}
}
