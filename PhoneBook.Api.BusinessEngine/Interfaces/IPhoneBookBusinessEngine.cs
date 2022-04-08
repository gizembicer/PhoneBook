using PhoneBook.Contracts.BindingModels;
using PhoneBook.Contracts.Dtos.Interfaces;

namespace PhoneBook.Api.BusinessEngine.Interfaces
{
    public interface IPhoneBookBusinessEngine
    {
        IDto AddContact(ContactBindingModel contact);
        IDto UpdateContact(ContactBindingModel contact);
        IDto AddContactInformation(ContactInformationBindingModel contactInformation);
        IDto UpdateContactInformation(ContactInformationBindingModel contactInformation);
        IDto ContactList();
        IDto DeleteContact(ContactBindingModel contact);
        IDto DeleteContactInformation(ContactInformationBindingModel contactInformation);
        IDto ContactInformationList(Guid contactId);
    }
}
