using System;

namespace Lab_2_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введіть точність:");
            double epsilon = double.Parse(Console.ReadLine());
            Console.Write("x=");
            double x = double.Parse(Console.ReadLine());
            double sum = 0;
            int f = 1;
            double add = 1;
           


            for (int i = 0; add> epsilon; i++)  
            {
                if (i > 0)
                {
                    f *= i;
                    add = Math.Pow(x, i) / f;
                    sum += add;
                    
                }
                else
                {
                    sum = 1;
                    
                }

            } 
            Console.WriteLine("Sum={0}", sum);
        }
    }
}
