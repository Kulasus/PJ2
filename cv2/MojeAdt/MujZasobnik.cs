using System;
using System.Collections.Generic;
using System.Text;

namespace MojeAdt
{
    public class MujZasobnik : IZasobnik
    {
        private int[] zasobnik;
        private int index;
        private const int sizeIncrease = 10;

        public MujZasobnik()
        {
            this.index = 0;
            this.zasobnik = new int[10];
        }
        public void Clear()
        {
            index = 0;
        }

        public bool IsEmpty()
        {
            return index == 0;
        }

        public bool IsFull()
        {
            return index == zasobnik.Length;
        }

        public int Pop()
        {
            if (IsEmpty())
            {
                throw new ApplicationException("Stack is empty.");
            }
            else
            {
                index--;
                return zasobnik[index];
            }
        }

        public void Push(int number)
        {
            if (IsFull())
            {
                int[] biggerZasobnik = new int[zasobnik.Length + sizeIncrease];
                int copyIndex = 0;
                foreach (int i in zasobnik) {
                    biggerZasobnik[copyIndex] = zasobnik[copyIndex];
                    copyIndex++;
                }
                zasobnik = biggerZasobnik;
                Push(number);
            }
            else
            {
                zasobnik[index] = number;
                index++;
            }
        }

        public int Top()
        {
            return IsEmpty() ? null : zasobnik[index - 1]; 
        }

        public string toString() { 
            foreach(int i in zasobnik){
                Console.write(i + " - ");
            }
            Console.WriteLine();
        }
    }
}
