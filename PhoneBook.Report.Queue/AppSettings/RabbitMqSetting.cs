using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBook.Report.Queue.AppSettings
{
    public class RabbitMqSetting
    {
        public string Uri { get; set; }
        public string ReportQueue { get; set; }
    }
}
