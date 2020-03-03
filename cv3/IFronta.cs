using System;
using System.Collections.Generic;
using System.Text;

namespace MojeAdt
{
    interface IFronta<T> : IADT<T>
    {
        public void Add(T number);
        public T Get();

    }
}
