using System;
using System.Collections.Generic;
using System.Text;

namespace MojeAdt
{
    public class MojeFronta : IFronta
    {
        private int[] fronta;
        private int indexLast;
        private int indexFirst;
        private const int sizeIncrease = 10;

        public MojeFronta()
        {
            this.fronta = new int[sizeIncrease];
            this.indexFirst = 0;
            this.indexLast = 0;
        }
        public void Add(int number)
        {
            if (IsFull())
            {
                int[] biggerFronta = new int[fronta.Length + sizeIncrease];
                int copyIndex = 0;
                foreach (int i in fronta)
                {
                    biggerFronta[copyIndex] = fronta[copyIndex];
                    copyIndex++;
                }
                fronta = biggerFronta;
                Add(number);
            }
            else
            {
                fronta[indexLast] = number;
                indexLast++;
            }
        }

        public void Clear()
        {
            indexLast = 0;
        }

        public int Get()
        {
            if (IsEmpty())
            {
                throw new ApplicationException("Queue is empty.");
            }
            else {
                int number = fronta[indexFirst];
                for (int i = 0; i < fronta.Length; i++)
                {
                    if (i + 1 < fronta.Length) {
                        fronta[i] = fronta[i + 1];
                    }
                }
                indexLast--;
                return number;
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
            foreach (int i in fronta) {
                Console.Write(i + " - ");
            }
            Console.WriteLine();
        }
    }
}
