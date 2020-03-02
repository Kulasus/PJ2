using System;
using MojeAdt;

namespace cv2
{
    
    class Program
    {
        static void Main(string[] args)
        {
            MojeFronta fronta = new MojeAdt.MojeFronta();
            fronta.Add(1);
            fronta.Add(2);
            fronta.Add(1);
            fronta.Add(2);
            fronta.Add(1);
            fronta.Add(2);
            fronta.Add(1);
            fronta.Add(2);
            fronta.Add(1);
            fronta.Add(2);
            fronta.Add(1);
            fronta.Add(1);
            fronta.Add(2);
            fronta.Add(2);
            fronta.toString();
            fronta.Clear();
            fronta.Add(3);
            fronta.Get();
            fronta.toString();

        }
    }
}
