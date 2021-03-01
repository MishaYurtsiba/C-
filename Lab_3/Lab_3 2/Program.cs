using System;

namespace Lab_3_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("n=");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.Write("x=");
            double x = Convert.ToDouble(Console.ReadLine());
            double NewElement = 0;
            double MaxElement = 0;
            double[] arr = new double[n];
            for(int i = 0; i < n; i++)
            {
                double add = (i+1) * (Math.Sin(x*(i+1)) + Math.Cos(x*(i+1)));
                NewElement+= add;
                arr[i] = NewElement;
            }
            for (int i = 0; i < n; i++)
            {
                if (MaxElement < arr[i])
                {
                    MaxElement = arr[i];
                }
                
            }
            for (int i = 0; i < n; i++)
            {
                Console.Write("{0},", arr[i]);
            }
            Console.WriteLine();
            Console.WriteLine("max element:{0}", MaxElement);

        }
    }
}
