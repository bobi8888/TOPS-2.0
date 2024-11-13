using Accessibility;
using DataAccessLayer.Contracts;
using Microsoft.Extensions.DependencyInjection;
using TOPS_2._0.UI;
using DataAccessLayer.Repositories;


namespace TOPS_2._0
{
	internal static class Program
	{
		[STAThread]
		static void Main()
		{
			ApplicationConfiguration.Initialize();

			ServiceCollection services = ConfigureServices();
			ServiceProvider serviceProvider = services.BuildServiceProvider();

			var startForm = serviceProvider.GetRequiredService<CustomerForm>();
			Application.Run(startForm);
		}

		static ServiceCollection ConfigureServices()
		{
			ServiceCollection services = new ServiceCollection();

			services.AddTransient<ICustomersRepository>(_ => new CustomersRepository());

			services.AddTransient<CustomerForm>();

			return services;
		}
	}
}