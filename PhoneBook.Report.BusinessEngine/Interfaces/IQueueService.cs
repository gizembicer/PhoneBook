using PhoneBook.Contracts.BindingModels;
using PhoneBook.Contracts.Dtos.Interfaces;

namespace PhoneBook.Report.BusinessEngine.Interfaces
{
    public interface IQueueService
    {
        Task<IDto> CreateReport(ReportBindingModel reportBindingModel);
        Task CreateReportDetails(Guid reportId);
        Task GetContactsWithInformations();
    }
}
