using PhoneBook.Contracts.BindingModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBook.Report.Queue.Interfaces.Events
{
    public interface ICreateReportEvent
    {
        public ReportBindingModel _reportBindingModel { get; set; }
    }
}
