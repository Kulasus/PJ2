using System;
using System.Collections.Generic;
using System.Text;

namespace MojeAdt
{
    interface IZasobnik<T> : IADT<T>
    {
        public void Push(T value);
        public T Pop();
        public T Top();

    }
}
