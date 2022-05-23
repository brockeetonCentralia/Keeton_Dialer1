using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Broc Keeton
//IT112
//NOTES: 
//BEHAVIORS NOT IMPLIMENTED AND WHY: All should be implemented.
namespace Keeton_Dialer1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var a = new Phone();
            List<Phone> dialList = a.DialingList();

            foreach (Phone dialed in dialList)
            {
                dialed.Dial();
            }

        }

    }
}

