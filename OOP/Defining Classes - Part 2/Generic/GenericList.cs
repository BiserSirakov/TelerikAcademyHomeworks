namespace Generic
{
    using System;

    public class GenericList<T>
        where T : IComparable // Problem 7
    {
        private T[] arr;
        private int lastIndex;
        
        public GenericList(int capacity)
        {
            this.arr = new T[capacity];
            this.lastIndex = -1;
        }

        public int Count
        {
            get
            {
                return this.lastIndex + 1;
            }
        }

        public T this[int index]
        {
            get
            {
                return this.arr[index];
            }
            private set
            {
                this.arr[index] = value;
            }
        }

        public void Add(T element)
        {
            if (this.lastIndex + 1 == this.arr.Length)
            {
                DoubleSize();
            }

            this.arr[++lastIndex] = element;
        }

        public void InsertAt(int index, T element)
        {
            CheckRange(index);

            if (this.lastIndex + 1 == this.arr.Length)
            {
                DoubleSize();
            }

            for (int i = this.lastIndex + 1; i > index; i--)
            {
                this.arr[i] = this.arr[i - 1];
            }

            this.arr[index] = element;
            ++lastIndex;
        }

        public void RemoveAt(int index)
        {
            CheckRange(index);

            for (int i = index + 1; i <= this.lastIndex; i++)
            {
                this.arr[i - 1] = this.arr[i];
            }

            this.arr[this.lastIndex--] = default(T);
        }

        public int IndexOf(T element)
        {
            int index = -1;

            for (int i = 0; i <= this.lastIndex; i++)
            {
                if (this.arr[i].Equals(element))
                {
                    index = i;
                    break;
                }
            }

            return index;
        }

        public void Clear()
        {
            for (int ind = 0; ind <= this.lastIndex; ind++)
            {
                this.arr[ind] = default(T);
            }

            this.lastIndex = -1;
        }

        private void CheckRange(int index)
        {
            if (index < 0 || index > this.lastIndex)
            {
                throw new ArgumentOutOfRangeException();
            }
        }

        private void DoubleSize()
        {
            T[] newArr = new T[this.arr.Length * 2];

            for (int i = 0; i <= this.lastIndex; i++)
            {
                newArr[i] = this.arr[i];
            }

            this.arr = newArr;
        }

        public T Max()
        {
            T result = this.arr[0];

            if (Count > 0)
            {
                for (int i = 1; i <= this.lastIndex; i++)
                {
                    if (this.arr[i].CompareTo(result) > 0)
                    {
                        result = arr[i];
                    }
                }
            }

            return result;
        } 

        public T Min()
        {
            T result = this.arr[0];

            if (Count > 0)
            {
                for (int i = 1; i <= this.lastIndex; i++)
                {
                    if (this.arr[i].CompareTo(result) < 0)
                    {
                        result = arr[i];
                    }
                }
            }

            return result;
        }

        public override string ToString()
        {
            string result = string.Empty;

            for (int i = 0; i <= this.lastIndex; i++)
            {
                result += this.arr[i] + " ";
            }

            return result;
        }
    }
}
