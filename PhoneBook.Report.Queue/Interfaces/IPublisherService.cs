using PhoneBook.Contracts.BindingModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBook.Report.Queue.Interfaces
{
    public interface IPublisherService
    {
        Task CreateLocationReport(ReportBindingModel reportBindingModel);
    }
}
