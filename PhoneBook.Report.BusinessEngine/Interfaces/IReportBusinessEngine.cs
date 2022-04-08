using PhoneBook.Contracts.Dtos.Interfaces;
using PhoneBook.Contracts.ResponseModel;

namespace PhoneBook.Report.BusinessEngine.Interfaces
{
    public interface IReportBusinessEngine
    {
        Task<IDto> CreateLocationReport();
        IDto ReportList();
        IDto ReportDetails(Guid reportId);

    }
}
