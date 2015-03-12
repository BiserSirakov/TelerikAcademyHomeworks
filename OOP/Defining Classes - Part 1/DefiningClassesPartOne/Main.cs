using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefiningClassesPartOne
{
    class main
    {
        static void Main()
        {
            GSMTest.PrintList(GSMTest.listOfGSMs); // Problem 7. GSM test

            Console.WriteLine(new string('-', 50));

            GSMCallHistoryTest.CreateCalltestHistory(); // Problem 12. Call history test
            GSMCallHistoryTest.DisplayCalltestHistory(); 
            GSMCallHistoryTest.PrintTotalPrice();
            GSMCallHistoryTest.RemoveLongestCall();
            Console.WriteLine();
            Console.Write("Price without the longest call : ");
            GSMCallHistoryTest.PrintTotalPrice();
            GSMCallHistoryTest.gsm.ClearCalls();
            Console.WriteLine(); 
            GSMCallHistoryTest.DisplayCalltestHistory();
        }
    }
}
