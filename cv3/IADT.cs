using System;
using System.Collections.Generic;
using System.Text;

namespace MojeAdt
{
    interface IADT<T>
    {
        public bool IsEmpty();
        public bool IsFull();
        public void Clear();
        public void toString();
    }
}
