using AutoMapper;
using PhoneBook.Api.BusinessEngine.Interfaces;
using PhoneBook.Contracts.BindingModels;
using PhoneBook.Contracts.Dtos;
using PhoneBook.Contracts.Dtos.Interfaces;
using PhoneBook.Contracts.ResponseModel;
using PhoneBook.Data.UnitOfWorks;
using PhoneBook.Entity;

namespace PhoneBook.Api.BusinessEngine.Services
{
    public class PhoneBookBusinessEngine : IPhoneBookBusinessEngine
    {
        private readonly IMapper _mapper;
        private readonly IUnitOfWork _unitOfWork;
        public PhoneBookBusinessEngine(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }
        public IDto AddContact(ContactBindingModel contact)
        {
            try
            {
                var contactEntity = _mapper.Map<Contacts>(contact);
                _unitOfWork.Contacts.Add(contactEntity);
                return new SuccessDto(true);
            }
            catch (Exception ex)
            {
                return new ErrorDto(ex.Message);
            }
        }

        public IDto AddContactInformation(ContactInformationBindingModel contactInformation)
        {
            try
            {
                var contactInformationEntity = _mapper.Map<ContactInformations>(contactInformation);
                _unitOfWork.ContactInformations.Add(contactInformationEntity);
                return new SuccessDto(true);
            }
            catch (Exception ex)
            {
                return new ErrorDto(ex.Message);
            }
        }

        public IDto DeleteContact(ContactBindingModel contact)
        {
            try
            {
                _unitOfWork.Contacts.Remove(_mapper.Map<Contacts>(contact));
                return new SuccessDto(true);
            }
            catch (Exception ex)
            {
                return new ErrorDto(ex.Message);
            }
        }

        public IDto DeleteContactInformation(ContactInformationBindingModel contactInformation)
        {
            try
            {
                _unitOfWork.ContactInformations.Remove(_mapper.Map<ContactInformations>(contactInformation));
                return new SuccessDto(true);
            }
            catch (Exception ex)
            {
                return new ErrorDto(ex.Message);
            }
        }

        public IDto ContactList()
        {
            try
            {
                var contactEntityList = _unitOfWork.Contacts.GetAll().ToList();
                var contactList = _mapper.Map<List<ContactResponseModel>>(contactEntityList);
                return new SuccessDto(contactList);
            }
            catch (Exception ex)
            {
                return new ErrorDto(ex.Message);
            }
        }

        public IDto UpdateContact(ContactBindingModel contact)
        {
            try
            {
                var contactEntity = _mapper.Map<Contacts>(contact);
                _unitOfWork.Contacts.Update(contactEntity);
                return new SuccessDto(true);
            }
            catch (Exception ex)
            {
                return new ErrorDto(ex.Message);
            }
        }

        public IDto UpdateContactInformation(ContactInformationBindingModel contactInformation)
        {
            try
            {
                var contactInformationEntity = _mapper.Map<ContactInformations>(contactInformation);
                _unitOfWork.ContactInformations.Update(contactInformationEntity);
                return new SuccessDto(true);
            }
            catch (Exception ex)
            {
                return new ErrorDto(ex.Message);
            }
        }

        public IDto ContactInformationList(Guid contactId)
        {
            try
            {
                var contactEntityList = _unitOfWork.ContactInformations.GetAll(x => x.ContactId == contactId).ToList();
                var contactList = _mapper.Map<List<ContactInformationResponseModel>>(contactEntityList);
                return new SuccessDto(contactList);
            }
            catch (Exception ex)
            {
                return new ErrorDto(ex.Message);
            }
        }
    }
}
