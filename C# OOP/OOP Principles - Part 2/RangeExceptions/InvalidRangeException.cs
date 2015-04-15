namespace RangeExceptions
{
    using System;

    public class InvalidRangeException<T> : ApplicationException
    {
        private readonly T start;
        private readonly T end;

        public InvalidRangeException(string msg, T start, T end)
            : base(msg)
        {
            this.start = start;
            this.end = end;
        }
    }
}
