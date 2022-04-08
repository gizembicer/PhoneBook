using MassTransit;
using PhoneBook.Report.BusinessEngine.Interfaces;
using PhoneBook.Report.Queue.Interfaces.Events;

namespace PhoneBook.Report.Queue.Consumer.Consumer
{
    internal class ReportEventConsumer : IConsumer<ICreateReportEvent>
    {
        private readonly IQueueService _queueService;
        public ReportEventConsumer(IQueueService queueService)
        {
            _queueService = queueService;
        }

        public Task Consume(ConsumeContext<ICreateReportEvent> context)
        {

            throw new NotImplementedException();
        }
    }
}
