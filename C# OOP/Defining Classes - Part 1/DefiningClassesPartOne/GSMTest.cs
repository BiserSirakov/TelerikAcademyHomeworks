namespace DefiningClassesPartOne
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class GSMTest
    {
        public static List<GSM> listOfGSMs = new List<GSM> {
        new GSM("iPhone5", "Apple", 1200, "Me", new Battery("bestBatteryModel", 200, 100, BatteryTypes.NiCd), new Display(10, 12000), new List<Call>()),
        new GSM("Galaxy s5", "Samsung", 1000, "Pesho", new Battery("badModel", 100, 50, BatteryTypes.LiIon), new Display(14, 62000), new List<Call>()),
        new GSM("Lumia", "Microsoft", 500, "Gosho", new Battery("goodModel", 100, 70, BatteryTypes.NiMH), new Display(11, 20000), new List<Call>()) };

        public static void PrintList (List<GSM> list)
        {
            Console.WriteLine(GSM.IPhone4S);

            foreach (var item in list)
            {
                Console.Write(item + "\n");
            }
        }
    }
}
