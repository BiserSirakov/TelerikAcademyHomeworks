namespace _01.StringBuilderSubstring
{
    using System;
    using System.Text;

    public static class StringBuilderSubstring
    {
        public static StringBuilder Substring(this StringBuilder sb, int index, int length)
        {
            StringBuilder result = new StringBuilder();

            for (int i = index; i < index + length; i++)
            {
                result.Append(sb[i]);
            }

            return result;
        }
    }
}
