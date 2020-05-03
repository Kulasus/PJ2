using System;

namespace TestPJ2
{
    class Program
    {
        static void Main(string[] args)
        {
            FireWall firewall = new FireWall("rules.txt");
            Console.WriteLine(firewall.Test("192.168.10.100"));
            Console.WriteLine(firewall.Test("192.168.11.100"));
            Console.WriteLine(firewall.Test("192.168.11.100"));
            firewall.Info();
        }
    }
}
