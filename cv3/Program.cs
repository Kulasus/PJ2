using System;
using MojeAdt;
using DynamicArray;

namespace cv2
{
    
    class Program
    {
        static void Main(string[] args)
        {
            DynamicArrayClass myArray = new DynamicArrayClass();
            myArray[1] = 1;
            myArray[2] = 2;
            myArray[15] = 15;
            Console.WriteLine(myArray.ToString());
            myArray.Length = 10;
        }
    }
}
