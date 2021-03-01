using System;

namespace Lab_1_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("a=");
            float a = float.Parse(Console.ReadLine());
            Console.Write("b=");
            float b = float.Parse(Console.ReadLine());
            Console.Write("c=");
            float c = float.Parse(Console.ReadLine());
            if (a < b && b < c)
            {
                double min = Math.Pow(a, 2);
                Console.WriteLine(min);
            }
            else if (b < a && a < c)
            {
                double min = Math.Pow(b, 2);
                Console.WriteLine(min);
            }
            else if (c < b && b < a)
            {
                double min = Math.Pow(c, 2);
                Console.WriteLine(min);
            }

        }
    }
}
