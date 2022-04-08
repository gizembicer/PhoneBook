using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using PhoneBook.Data.Context;
using PhoneBook.Data.UnitOfWorks;

namespace PhoneBook.Data
{
    public static class IServiceCollectionExtensions
    {
        public static void AddDataServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<DataContext>(options => options.UseNpgsql(configuration.GetConnectionString("Default")));
            
            services.AddScoped<IUnitOfWork, UnitOfWork>();
        }
    }
}
