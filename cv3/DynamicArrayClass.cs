using System;

namespace DynamicArray
{
    public class DynamicArrayClass
    {
        public enum Info
        {
            Empty,
            SomeData,
            Full
        }
        private int?[] array;
        private const int defaultSizeIncrease = 10;
        public int Length
        {
            get
            {
                return array.Length;
            }
            set
            {
                if (value < array.Length)
                {
                    throw new ApplicationException("Invalid array length.");
                }
                else
                {
                    increaseArraySize(value);
                }
            }
        }
        public int? this[int i]
        {
            get
            {
                if (i > array.Length)
                {
                    return null;
                }
                return array[i];
            }
            set
            {
                if (i > array.Length)
                {
                    increaseArraySize(defaultSizeIncrease);
                }
                array[i] = value;
            }
        }

        public DynamicArrayClass(int lenght = 10)
        {
            this.array = new int?[lenght];

        }

        private void increaseArraySize(int sizeIncrease)
        {
            int?[] biggerArray = new int?[array.Length + sizeIncrease];
            int copyIndex = 0;
            foreach (int? i in array)
            {
                biggerArray[copyIndex] = array[copyIndex];
                copyIndex++;
            }
            array = biggerArray;
        }

        public override string ToString()
        {
            String resultString = "";
            foreach (int? i in array)
            {
                if (i.HasValue)
                {
                    resultString += i.ToString() + " ";
                }
                else
                {
                    resultString += "null" + " ";
                }
            }
            return resultString;
        }

        public void Sum(out int? sum)
        {
            sum = 0;
            foreach (int? i in array)
            {
                if (i.HasValue)
                {
                    sum += i;
                }
            }
        }

        public void Add(ref int? num, int index)
        {
            num += array[index];
        }

        public Info DataInfo
        {
            get
            {
                return DynamicArrayClass.Info.Full;
            }
        }
    }
}
