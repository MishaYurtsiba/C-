using System;

namespace Lab_3_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("n=");
            int n = Convert.ToInt32(Console.ReadLine());
            double[] a = new double[n];
            double[] b = new double[n];
            double[] c = new double[n];
            Console.WriteLine("Введіть елементи вектору:A");
            for (int i = 0; i < n; i++)
            {
                a[i] = Convert.ToDouble(Console.ReadLine());
            }
            Console.WriteLine("Введіть елементи вектору:B");
            for (int i = 0; i < n; i++)
            {
                b[i] = Convert.ToDouble(Console.ReadLine());
            }
            Console.WriteLine("Введіть елементи вектору:C");
            for (int i = 0; i < n; i++)
            {
                c[i] = Convert.ToDouble(Console.ReadLine());
            }
            for(int i = 0; i < n; i++)
            {
                c[i] = (2 * (a[i] + c[i])) - b[i];
            }
            for (int i = 0; i < n; i++)
            {
                Console.Write("{0},", c[i]);
            }
        }
    }
}
