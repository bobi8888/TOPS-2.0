using DataAccessLayer;
using DataAccessLayer.Contracts;
using DomainModel.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TOPS_2._0.UI
{
	public partial class CustomerForm:Form
	{
		public List<string> Types = new List<string>();
		private readonly ICustomersRepository _customersRepository;


		public CustomerForm(ICustomersRepository customersRepository)
		{
			InitializeComponent();
			Types.Add("Commercial");
			Types.Add("Residential");
			TypeCbx.DataSource = Types;
			_customersRepository = customersRepository;
		}

		private void CustomerForm_Load(object sender,EventArgs e)
		{

		}

		private void AddCustomerBtn_Click(object sender,EventArgs e)
		{
			if (FirstNameTxt.Text != "" && LastNameTxt.Text != "")
			{
				//CustomerDataAccess db = new CustomerDataAccess();
				Customer newCustomer = new Customer(FirstNameTxt.Text, LastNameTxt.Text, TypeCbx.Text);
				_customersRepository.AddCustomer(newCustomer);

/*				newCustomer.FirstName = FirstNameTxt.Text;
				newCustomer.LastName = LastNameTxt.Text;
				newCustomer.CustomerType = TypeCbx.Text;
				db.AddCustomer(newCustomer);*/
			}

		}
	}
}
