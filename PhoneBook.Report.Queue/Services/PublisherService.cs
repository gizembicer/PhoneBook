using MassTransit;
using PhoneBook.Contracts.BindingModels;
using PhoneBook.Report.Queue.AppSettings;
using PhoneBook.Report.Queue.Interfaces;
using PhoneBook.Report.Queue.Interfaces.Events;

namespace PhoneBook.Report.Queue
{
    public class CreateReportEvent : ICreateReportEvent
    {
        public ReportBindingModel _reportBindingModel { get; set; }
    }
    public class PublisherService : IPublisherService
    {
        private readonly RabbitMqSetting _rabbitMqSetting;
        private readonly IBus _bus;
        public PublisherService(RabbitMqSetting rabbitMqSetting, IBus bus)
        {
            _rabbitMqSetting = rabbitMqSetting;
            _bus = bus;
        }
        //Uri GetQueueUrl(string queueName) => new Uri($"{_rabbitMqSetting.Uri}/{queueName}");
        public async Task CreateLocationReport(ReportBindingModel reportBindingModel)
        {
            await _bus.Publish<ICreateReportEvent>(reportBindingModel);
        }
    }
}
