using MassTransit;
using Microsoft.Extensions.DependencyInjection;
using PhoneBook.Report.Queue.AppSettings;
using PhoneBook.Report.Queue.Interfaces;

namespace PhoneBook.Report.Queue
{
    public static class IServiceCollectionExtensions
    {
        public static void AddQueueServices(this IServiceCollection services)
        {
            var serviceProvider = services.BuildServiceProvider();
            var rabbitMqSettings = serviceProvider.GetService<RabbitMqSetting>();

            services.AddMassTransit(x =>
            {
                x.AddBus(provider => Bus.Factory.CreateUsingRabbitMq(config =>
                {
                    config.Host(new Uri(rabbitMqSettings.Uri));
                }));
            });

            services.AddMassTransitHostedService();
            services.AddScoped<IPublisherService, PublisherService>();
        }
    }
}