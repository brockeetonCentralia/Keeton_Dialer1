using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Keeton_Dialer1
{
    internal class CellPhone : Phone
    {
        protected string cellPhoneType { get; set; }

        public CellPhone(string phoneNumber, string name, string cellPhoneType = "2")
        {
            PhoneNumber = phoneNumber;
            CompanyName = name;
            PhoneType = cellPhoneType;
        }
        public override void Dial()
        {
            if (PhoneType == "2")
            {
                Console.WriteLine(CompanyName + " is being dialed using " + "1+ " + PhoneNumber + "...");
            }

        }
    }
}
