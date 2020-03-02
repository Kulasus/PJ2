using System;
using System.Collections.Generic;
using System.Text;

namespace MojeAdt
{
    interface IADT
    {
        public bool IsEmpty();
        public bool IsFull();
        public void Clear();
        public string toString();
    }
}
