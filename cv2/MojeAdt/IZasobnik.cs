using System;
using System.Collections.Generic;
using System.Text;

namespace MojeAdt
{
    interface IZasobnik : IADT
    {
        public void Push(int number);
        public int Pop();
        public int Top();

    }
}
