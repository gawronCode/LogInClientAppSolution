using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogInClientApp.Models
{
    public class AppClientChangeCredentials
    {
        public string Nick { get; set; }
        public string PassCode { get; set; }
        public string NewPassCode { get; set; }
        public string NewEmailAddress { get; set; }
    }
}
