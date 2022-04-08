using AutoMapper;
using PhoneBook.Contracts.BindingModels;
using PhoneBook.Contracts.Dtos;
using PhoneBook.Contracts.Dtos.Interfaces;
using PhoneBook.Data.UnitOfWorks;
using PhoneBook.Entity;
using PhoneBook.Report.BusinessEngine.Interfaces;
using PhoneBook.Report.Queue.Interfaces;

namespace PhoneBook.Report.BusinessEngine.Services
{
    internal class QueueService : IQueueService
    {
        private readonly IMapper _mapper;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IPublisherService _publisherService;
        public QueueService(IUnitOfWork unitOfWork, IMapper mapper, IPublisherService publisherService)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            _publisherService = publisherService;
        }

        public async Task<IDto> CreateReport(ReportBindingModel reportBindingModel)
        {
            try
            {
                await _publisherService.CreateLocationReport(reportBindingModel);
                return new SuccessDto(true);
            }
            catch (Exception ex)
            {
                return new ErrorDto(ex.Message);
            }
        }

        public Task CreateReportDetails(Guid reportId)
        {
            throw new NotImplementedException();
        }

        public Task GetContactsWithInformations()
        {
            throw new NotImplementedException();
        }
    }
}
