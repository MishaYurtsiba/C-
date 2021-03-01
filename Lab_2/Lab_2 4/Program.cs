using System;

namespace Lab_2_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("n=");
            int n = int.Parse(Console.ReadLine());
            double x0 = 1;
            double x1 = 1;
            for(int i = 2; n > i; i++)
            {
                double x2 = (Math.Sin(x1) + x0) / Math.Cos(x1);
                x0 = x1;
                x1 = x2;
            }
            Console.WriteLine("Xn={0}", x1);
        }
    }
}
