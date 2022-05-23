using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Keeton_Dialer1
{
    internal class Phone
    {
        public string PhoneNumber { get; set; }
        public string CompanyName { get; set; }
        public string PhoneType { get; set; }

        public Phone()
        {
            PhoneNumber = "(XXX) XXX-XXXX";
            CompanyName = "Company Name";
            PhoneType = "0";
        }

        public Phone(string phoneNumber, string name, string type)
        {
            PhoneNumber = phoneNumber;
            CompanyName = name;
            PhoneType = type;
        }
        public virtual void Dial()
        {
            if (PhoneType == "2")
            {
                Console.WriteLine(CompanyName + " is being dialed using " + "1+ " + PhoneNumber + "...");
            }
            else
            {
                Console.WriteLine(CompanyName + " is being dialed using " + PhoneNumber + "...");
            }


        }
        public List<Phone> DialingList()
        {
            List<Phone> phoneList = new List<Phone>();
            phoneList.Add(new Phone { CompanyName = "CompuTest", PhoneNumber = "(303) 985-5060", PhoneType = "1" });
            phoneList.Add(new Phone { CompanyName = "Curtis Manufacturing", PhoneNumber = "(603) 532-4123", PhoneType = "2" });
            phoneList.Add(new Phone { CompanyName = "Data Functions", PhoneNumber = "(800) 876-2524", PhoneType = "1" });
            phoneList.Add(new Phone { CompanyName = "Donnay Repair", PhoneNumber = "(708) 397-3330", PhoneType = "1" });
            phoneList.Add(new Phone { CompanyName = "ErgoNomic Inc", PhoneNumber = "(360) 434-3894", PhoneType = "1" });
            phoneList.Add(new Phone { CompanyName = "ErgoSource", PhoneNumber = "(800) 969-4374", PhoneType = "1" });
            phoneList.Add(new Phone { CompanyName = "Fox Bay Industries", PhoneNumber = "(800) 874-8527", PhoneType = "2" });
            phoneList.Add(new Phone { CompanyName = "Glare-Gaurd", PhoneNumber = "(800) 545-6254", PhoneType = "2" });
            phoneList.Add(new Phone { CompanyName = "Hazard Comm Specialists", PhoneNumber = "(407) 783-6641", PhoneType = "2" });
            phoneList.Add(new Phone { CompanyName = "Komfort Support", PhoneNumber = "(714) 472-4409", PhoneType = "2" });

            return phoneList;
        }
    }
}
