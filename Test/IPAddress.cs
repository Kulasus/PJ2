using System;
using System.Collections.Generic;
using System.Text;

namespace TestPJ2
{
    class IPAddress
    {
        public String Address;
        public String Mask;

        public IPAddress(String address, String mask)
        {
            this.Address = address;
            this.Mask = mask;
        }
        public bool IsInNetwork(String ip)
        {
            String[] addressAr = ip.Split('.');
            String[] maskAr = Mask.Split('.');
            String[] netAr = Address.Split('.');
            for (int i = 0; i < addressAr.Length; i++)
            {
                if(Int32.Parse(maskAr[i]) == 255 &&  Int32.Parse(addressAr[i]) != Int32.Parse(netAr[i]))
                {
                    return false;
                }
            }
            return true;
        }

        public override string ToString()
        {
            return "IPAddress: " + this.Address + " | Mask: " + this.Mask;
        }
    }
}
