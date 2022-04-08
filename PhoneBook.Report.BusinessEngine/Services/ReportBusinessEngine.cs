using AutoMapper;
using PhoneBook.Contracts.Dtos;
using PhoneBook.Contracts.Dtos.Interfaces;
using PhoneBook.Contracts.ResponseModel;
using PhoneBook.Data.UnitOfWorks;
using PhoneBook.Report.BusinessEngine.Interfaces;

namespace PhoneBook.Report.BusinessEngine.Services
{
    public class ReportBusinessEngine : IReportBusinessEngine
    {
        private readonly IMapper _mapper;
        private readonly IUnitOfWork _unitOfWork;
        public ReportBusinessEngine(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }
        public Task<IDto> CreateLocationReport()
        {
            throw new NotImplementedException();
        }

        public IDto ReportDetails(Guid reportId)
        {
            try
            {
                var reportDetailEntityList = _unitOfWork.ReportDetails.GetAll(x => x.ReportId == reportId).ToList();
                var reportDetailList = _mapper.Map<List<ReportDetailsResponseModel>>(reportDetailEntityList);
                return new SuccessDto(reportDetailList);
            }
            catch (Exception ex)
            {
                return new ErrorDto(ex.Message);
            }
        }

        public IDto ReportList()
        {
            try
            {
                var reportEntityList = _unitOfWork.Reports.GetAll().ToList();
                var reportList = _mapper.Map<List<ReportResponseModel>>(reportEntityList);
                return new SuccessDto(reportList);
            }
            catch (Exception ex)
            {
                return new ErrorDto(ex.Message);
            }
        }
    }
}
