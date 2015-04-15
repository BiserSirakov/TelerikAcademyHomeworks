namespace _02.IEnumerableExtensions
{
    using System.Collections.Generic;
    using System.Linq;

    public static class IEnumerableExtensions
    {
        public static T Sum<T>(this IEnumerable<T> collection)
        {
            T result = (dynamic)0;

            foreach (var item in collection)
            {
                result += (dynamic)item;
            }

            return result;
        }

        public static T Product<T>(this IEnumerable<T> collection)
        {
            T result = (dynamic)1;

            foreach (var item in collection)
            {
                result *= (dynamic)item;
            }

            return result;
        }

        public static T MinElement<T>(this IEnumerable<T> collection)
        {
            return collection.Min();
        }

        public static T MaxElement<T>(this IEnumerable<T> collection)
        {
            return collection.Max();
        }

        public static T AverageValue<T>(this IEnumerable<T> collection)
        {
            return (dynamic)(collection.Sum())/(collection.Count());
        }
    }
}
