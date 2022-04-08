using AutoMapper;
using PhoneBook.Contracts.ResponseModel;
using PhoneBook.Entity;

namespace PhoneBook.Report.BusinessEngine.Map
{
    public class MapProfile : Profile
    {
        public MapProfile()
        {
            CreateMap<ReportResponseModel, Reports>().ReverseMap();
            CreateMap<ReportDetailsResponseModel, ReportDetails>().ReverseMap();
        }
    }
}
