using System;

namespace Lab_5_1
{
    class Program
    {
        static int Nsd(int a,int b)
        {
            while (b != 0)
                b = a % (a=b );
            return a;
        }
        static void Main(string[] args)
        {
            Console.Write("a=");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("b=");
            int b = Convert.ToInt32(Console.ReadLine());
            int s = Nsd(a, b) + Nsd(a, 4) + Nsd(24, b);
            Console.WriteLine("s={0}", s);

        }
    }
}
