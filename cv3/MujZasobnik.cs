using System;
using System.Collections.Generic;
using System.Text;

namespace MojeAdt
{
    public class MujZasobnik<T> : IZasobnik<T>
    {
        private T[] zasobnik;
        private int index;
        private const int sizeIncrease = 10;

        public MujZasobnik()
        {
            this.index = 0;
            this.zasobnik = new T[sizeIncrease];
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

        public T Pop()
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

        public void Push(T value)
        {
            if (IsFull())
            {
                T[] biggerZasobnik = new T[zasobnik.Length + sizeIncrease];
                int copyIndex = 0;
                foreach (T i in zasobnik) {
                    biggerZasobnik[copyIndex] = zasobnik[copyIndex];
                    copyIndex++;
                }
                zasobnik = biggerZasobnik;
                Push(value);
            }
            else
            {
                zasobnik[index] = value;
                index++;
            }
        }

        public T Top()
        {
            return IsEmpty() ? throw new ApplicationException("Stack is empty.") : zasobnik[index - 1]; 
        }

        public void toString() { 
            foreach(T i in zasobnik){
                Console.Write(i.ToString() + " - ");
            }
            Console.WriteLine();
        }
    }
}
