using System;

namespace Lab_1_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("x=");
            double x= double.Parse(Console.ReadLine());
            if (1<=x && x<=3)
            {
                double z = Math.Log(x) - Math.Tan(x);
                Console.WriteLine("z={0}", z);
            }
            else if (3 <= x && x <= 4)
            {
                double z = Math.Tan(x);
                Console.WriteLine("z={0}",z);
            }
            else
            {
                double z = 0;
                Console.WriteLine("z={0}", z);
            }
        }
    }
}
