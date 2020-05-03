using System;
using System.Collections.Generic;
using System.Text;

namespace TestPJ2
{
    class FirewallException : Exception
    {
        //private IPAddress IP;
        public FirewallException(IPAddress ip) : base(ip.ToString()) { }
    }
}
