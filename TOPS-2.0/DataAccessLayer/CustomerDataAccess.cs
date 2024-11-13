using Dapper;
using DataAccessLayer.Contracts;
using DomainModel.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
	public class CustomerDataAccess : ICustomersRepository
	{
		public void AddCustomer (Customer customer)
		{
			//uses a stored procedure in sql
			string connectionString = ConfigurationManager.ConnectionStrings ["TOPS2.0ConnectionString"].ConnectionString;

			string query = "insert into Customers (FirstName, LastName, CustomerType) values (@FirstName, @LastName, @CustomerType)";

			using (IDbConnection connection = new SqlConnection(connectionString))
			{
				connection.Execute(query, customer);
			}
		}
	}
}
