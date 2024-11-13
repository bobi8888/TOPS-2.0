using Accessibility;
using DataAccessLayer.Contracts;
using Microsoft.Extensions.DependencyInjection;
using TOPS_2._0.UI;
using DataAccessLayer.Repositories;


namespace TOPS_2._0
{
	internal static class Program
	{
		/// <summary>
		///  The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main()
		{
			ApplicationConfiguration.Initialize();
			ServiceCollection services = ConfigureServices();
			ServiceProvider serviceProvider = services.BuildServiceProvider();
			//Application.Run(new LogInForm());
			var startForm = serviceProvider.GetRequiredService<CustomerForm>;
			Application.Run(startForm);
		}

		static ServiceCollection ConfigureServices()
		{
			ServiceCollection services = new ServiceCollection();
			services.AddTransient<CustomersRepository>();

			return services;
		}
	}
}