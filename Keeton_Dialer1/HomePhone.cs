using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Keeton_Dialer1
{
    internal class HomePhone : Phone
    {
        protected string homePhoneType { get; set; }
        public HomePhone(string phoneNumber, string name, string homePhoneType = "1")
        {
            PhoneNumber = phoneNumber;
            CompanyName = name;
            PhoneType = homePhoneType;
        }

    }
}
