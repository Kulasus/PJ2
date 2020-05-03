using System;
using System.Collections.Generic;
using System.Text;

namespace TestPJ2
{
    class Rule
    {
        public IPAddress Network { get; set; }
        public Access Type { get; set; }
        public Rule(IPAddress network, Access type)
        {
            this.Network = network;
            this.Type = type;
        }

        public override string ToString()
        {
            return Network.ToString() + Type.ToString();
        }
    }
}
