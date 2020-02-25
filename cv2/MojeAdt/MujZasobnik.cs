using System;
using System.Collections.Generic;
using System.Text;

namespace MojeAdt
{
    public class MujZasobnik : IZasobnik
    {
        private int[] zasobnik;
        int index;

        public MujZasobnik(int size)
        {
            this.index = 0;
            this.zasobnik = new int[size];
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
                throw new ApplicationException("Stack is full.");
            }
            else
            {
                index++;
                zasobnik[index] = number;
            }
        }

        public int Top()
        {
            return zasobnik[index];
        }
    }
}
