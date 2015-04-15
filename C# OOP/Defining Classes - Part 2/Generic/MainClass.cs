namespace Generic
{
    using System;

    class MainClass
    {
        static void Main()
        {
            GenericList<int> list = new GenericList<int>(10);

            list.Add(100);
            list.InsertAt(0, 1);
            list.Add(5);
            list.Add(-123);

            list.RemoveAt(0);

            var max = list.Max();
            var min = list.Min();

            Console.WriteLine(list);
            Console.WriteLine("Count : " + list.Count);
            Console.WriteLine("Max : " + max);
            Console.WriteLine("Min : " + min);
            Console.WriteLine("At position 1 : " + list[1]);
            Console.WriteLine("Position of -123 : " + list.IndexOf(-123));

            list.Clear();

            Console.WriteLine("Cleared." + list);
            Console.WriteLine(list.Count);
        }
    }
}
