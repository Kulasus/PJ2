using System;
using MojeAdt;

namespace cv2
{
    
    class Program
    {
        static void Main(string[] args)
        {
            MujZasobnik myStack = new MujZasobnik();
            myStack.Push(1);
            myStack.Push(2);
            int x = myStack.Pop();
            int y = myStack.Pop();
            myStack.toString();
            myStack.Push(3);
            myStack.toString();
            Console.WriteLine(x + " " + y);

        }
    }
}
