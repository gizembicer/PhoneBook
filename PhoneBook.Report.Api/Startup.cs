using PhoneBook.Api.BusinessEngine.Map;
using PhoneBook.Data;
using PhoneBook.Report.Queue;

namespace PhoneBook.Report.Api
{
    public class Startup
    {
        public IConfiguration Configuration { get; }

        public Startup(IConfiguration configuration)
        {
            var builder = new ConfigurationBuilder()
                    .AddJsonFile("appsettings.json");

            Configuration = builder.Build();
        }
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddAutoMapper(typeof(MapProfile));
            services.AddDataServices(Configuration);
            services.AddQueueServices();
            services.AddMemoryCache();
            services.AddControllers().AddJsonOptions(x => x.JsonSerializerOptions.IgnoreNullValues = true);
            services.AddSwaggerGen();
        }
    }
}
