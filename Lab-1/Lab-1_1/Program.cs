using System;

namespace Lab_1_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("x1=");
            int x1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("y1=");
            int y1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("x2=");
            int x2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("y2=");
            int y2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("x3=");
            int x3 = Convert.ToInt32(Console.ReadLine());
            Console.Write("y3=");
            int y3 = Convert.ToInt32(Console.ReadLine());
            int AC = ((x3 - x1) ^ 2 + (y3 - y1) ^ 2) ^ (1 / 2);
            int BC = ((x3 - x2) ^ 2 + (y3 - y2) ^ 2) ^ (1 / 2);
            int AB = ((x2 - x1) ^ 2 + (y2 - y1) ^ 2) ^ (1 / 2);
            int p = AC + BC + AB;
            Console.WriteLine(p);
        }
    }
}
