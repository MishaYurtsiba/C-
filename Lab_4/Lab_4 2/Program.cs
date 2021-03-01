using System;

namespace Lab_4_2
{
    class Program
    {
        static long Factorial(int n)
        {
            if (n == 0)
                return 1;
            return Factorial(n - 1) * n;
        }
        static void Main(string[] args)
        {
            Console.Write("Введіть кількість рядків:");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Введіть кількість стовпців:");
            int b = int.Parse(Console.ReadLine());          
            double[,] matrix = new double[a, b];
            for (int i = 0; i < a; i++)
            {
                for (int j = 0; j < b; j++)
                {
                   
                     
                    matrix[i, j] = Factorial(i) - Factorial(j);
                }
                
            }
            for (int i = 0; i < a; i++)
            {
                for (int j = 0; j < b; j++)
                {
                    Console.Write("{0,8:f}", matrix[i, j]);
                }
                Console.WriteLine();
            }
        }
    }
}
