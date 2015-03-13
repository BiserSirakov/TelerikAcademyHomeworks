namespace DefiningClassesPartOne
{
    using System;
    using System.Linq;

    public class GSMCallHistoryTest
    {
        public static GSM gsm = new GSM();

        public static DateTime date1 = DateTime.Parse("12.3.2015 0:48:12");
        public static DateTime date2 = DateTime.Parse("10.1.2005 10:28:52");
        public static DateTime date3 = DateTime.Parse("3.3.1878 20:15:22");

        public static Call call1 = new Call(date1, "0888888888", 123);
        public static Call call2 = new Call(date2, "0888888887", 234);
        public static Call call3 = new Call(date3, "0888888882", 345);

        public static void CreateCalltestHistory()
        {
            gsm.AddCalls(call1);
            gsm.AddCalls(call2);
            gsm.AddCalls(call3);
        }

        public static void DisplayCalltestHistory()
        {
            Console.WriteLine(gsm.PrintCallHistory());
        }

        //public static void PrintCalls()
        //{
        //    Console.WriteLine(call1);
        //    Console.WriteLine(call2);
        //    Console.WriteLine(call3);
        //}

        public static void PrintTotalPrice()
        {
            Console.WriteLine("Total price = {0}", gsm.CalculateAndPrintTotalPrice(0.37M));
        }

        public static void RemoveLongestCall()
        {
            var sortedList = gsm.CallHistory.OrderBy(x => x.Duration).ToArray();
            var longestCall = sortedList[gsm.CallHistory.Count - 1];
            gsm.DeleteCalls(longestCall);
        }
    }
}
