using System;

namespace Lab_4_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введіть кількість рядків:");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Введіть кількість стовпців:");
            int b = int.Parse(Console.ReadLine());           
            Random rand = new Random(DateTime.Now.Millisecond);
            int namber = 1;
            double []fh = new double[a];

            double[,] matrix = new double[a, b];
            for (int i = 0; i < a; i++)
            {
                for (int j = 0; j < b; j++)
                {
                    matrix[i, j] = rand.Next(-100, 100);
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
            for (int i = 0; i < a; i++)
            {
                fh[i] = matrix[i,(b-namber)];
                namber++;
            }
            for (int i = 0; i < a; i++)
            {
               Console.Write("{0},", fh[i]);                             
            }
            Array.Sort(fh);
            Array.Reverse(fh);
            Console.WriteLine();
            for (int i = 0; i < a; i++)
            {
                Console.Write("{0},", fh[i]);
            }

        }
    }
}
