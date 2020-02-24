using System;
using cv1lib;

namespace cv1
{
    class Program
    {
        static void Main(string[] args)
        {
            String myName = "Lukas";
            Greeter greeter = new Greeter();
            greeter.greet(myName);
        }
    }
}
