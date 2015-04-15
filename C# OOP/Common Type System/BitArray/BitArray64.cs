using System;

namespace BitArray
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Text;

    public class BitArray64 : IEnumerable<int>
    {
        private ulong number;

        public BitArray64(ulong num)
        {
            this.Number = num;
        }

        public ulong Number
        {
            get
            {
                return this.number;
            }
            private set
            {
                this.number = value;
            }
        }

        public int this[int position]
        {
            get
            {
                if (position < 0 || position >= 64)
                {
                    throw new IndexOutOfRangeException("Invalid position.");
                }

                return ((int)(this.Number >> position) & 1);
            }
            set
            {
                if (position < 0 || position >= 64)
                {
                    throw new IndexOutOfRangeException("Invalid position.");
                }

                if (value < 0 || value > 1)
                {
                    throw new ArgumentException("Invalid bit value.");
                }

                if (((int)(this.Number >> position) & 1) != value)
                {
                    this.Number ^= (1ul << position);
                }
            }
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();

            for (int i = 0; i < 64; i++)
            {
                result.Insert(0, ((this.Number >> i) & 1));
            }

            return result.ToString();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }

        public IEnumerator<int> GetEnumerator()
        {
            for (int i = 0; i < 64; i++)
            {
                yield return this[i];
            }
        }

        public override int GetHashCode()
        {
            unchecked
            {
                int result = 17;
                result = result * 23 + this.number.GetHashCode();
                return result;
            }
        }

        public bool Equals(BitArray64 other)
        {
            if (ReferenceEquals(null, other))
            {
                return false;
            }

            if (ReferenceEquals(this, other))
            {
                return true;
            }

            return this.number == other.number;
        }

        public override bool Equals(object obj)
        {
            BitArray64 temp = obj as BitArray64;

            if (temp == null)
            {
                return false;
            }

            return this.Equals(temp);
        }

        public static bool operator ==(BitArray64 a, BitArray64 b)
        {
            return a.Equals(b);
        }

        public static bool operator !=(BitArray64 a, BitArray64 b)
        {
            return !a.Equals(b);
        }
    }
}
