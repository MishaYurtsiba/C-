using System;

namespace lab_4_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введіть кількість рядків:");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Введіть кількість стовпців:");
            int b = int.Parse(Console.ReadLine());
            int c = 0;
            Random rand = new Random(DateTime.Now.Millisecond);

            double[,] matrix = new double[a,b];
            for(int i = 0; i < a; i++)
            {
                for(int j = 0; j < b; j++)
                {
                    matrix[i, j] = rand.Next(-100, 100);
                }
            }
            for (int i = 0; i < a; i++)
            {
                for (int j = 0; j < b; j++)
                {
                    if (i % 2 == 0 && j % 2 != 0 && matrix [i,j] > 0)
                    {
                        c++;
                    }
                }
            }
            for (int i = 0; i < a; i++)
            {
                for (int j = 0; j < b; j++)
                {
                    Console.Write("{0,8:f}", matrix[i,j]);
                }
                Console.WriteLine();
            }
            Console.WriteLine("Результат={0}", c);

        }
    }
}
