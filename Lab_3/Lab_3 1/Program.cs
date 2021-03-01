using System;

namespace Lab_3_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введіть кількість елементів: ");
            int n = Convert.ToInt32(Console.ReadLine());
            double[] arr = new double[n];
            double max = 0;
            for (int i = 0; i < n; i++)
            {
                arr[i] = double.Parse(Console.ReadLine());
            }
            for (int i = 0; i < n; i += 2)
                
            {
                if (max < arr[i])
                {
                    max = arr[i];
                }
            }
            for (int i = 0; i < n; i++)
            {
                Console.Write("{0},", arr[i]);
               
            }
            Console.WriteLine("Найбільше значення:{0}", max);
        }
    }
}
