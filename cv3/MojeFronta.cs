using System;
using System.Collections.Generic;
using System.Text;

namespace MojeAdt
{
    public class MojeFronta<T> : IFronta<T>
    {
        private T[] fronta;
        private int indexLast;
        private int indexFirst;
        private const int sizeIncrease = 10;

        public MojeFronta()
        {
            this.fronta = new T[sizeIncrease];
            this.indexFirst = 0;
            this.indexLast = 0;
        }
        public void Add(T value)
        {
            if (IsFull())
            {
                T[] biggerFronta = new T[fronta.Length + sizeIncrease];
                int copyIndex = 0;
                foreach (T i in fronta)
                {
                    biggerFronta[copyIndex] = fronta[copyIndex];
                    copyIndex++;
                }
                fronta = biggerFronta;
                Add(value);
            }
            else
            {
                fronta[indexLast] = value;
                indexLast++;
            }
        }

        public void Clear()
        {
            indexLast = 0;
        }

        public T Get()
        {
            if (IsEmpty())
            {
                throw new ApplicationException("Queue is empty.");
            }
            else {
                T value = fronta[indexFirst];
                for (int i = 0; i < fronta.Length; i++)
                {
                    if (i + 1 < fronta.Length) {
                        fronta[i] = fronta[i + 1];
                    }
                }
                indexLast--;
                return value;
            }
        }
        public bool IsEmpty()
        {
            return indexFirst == 0 && indexLast == 0;
        }

        public bool IsFull()
        {
            return indexLast == fronta.Length;
        }

        public void toString()
        {
            foreach (T i in fronta) {
                Console.Write(i.ToString() + " - ");
            }
            Console.WriteLine();
        }
    }
}
