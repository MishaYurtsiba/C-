using System;

namespace Lab_2_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("a=");
            double a= double.Parse( Console.ReadLine());
            Console.Write("n=");
            int n = int.Parse(Console.ReadLine());
            double sum = 0;
            double add = 1;
            
            for (int i = 0; i < n; i++)
            {
                sum += add;
                add *= 1 / (a + 1);
            }
            Console.WriteLine("Sum={0}", sum);


        }
    }
}
