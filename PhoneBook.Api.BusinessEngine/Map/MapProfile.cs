using AutoMapper;
using PhoneBook.Contracts.BindingModels;
using PhoneBook.Contracts.ResponseModel;
using PhoneBook.Entity;

namespace PhoneBook.Api.BusinessEngine.Map
{
    public class MapProfile : Profile
    {
        public MapProfile()
        {
            CreateMap<ContactBindingModel, Contacts>().ReverseMap();
            CreateMap<ContactInformationBindingModel, ContactInformations>().ReverseMap();
            CreateMap<ContactInformations, ContactInformationResponseModel>().ReverseMap();
            CreateMap<Contacts, ContactResponseModel>().ReverseMap();

            CreateMap<ReportBindingModel, Reports>().ReverseMap();
            CreateMap<ReportDetailsBindingModel, ReportDetails>().ReverseMap();
            CreateMap<ReportDetails, ReportDetailsResponseModel>().ReverseMap();
            CreateMap<Reports, ReportResponseModel>().ReverseMap();
        }
    }
}
