using System;

namespace Lab_3_4
{
    class Program
    {
        static void Main(string[] args)
        {
            //            Console.Write("n=");
            //            int n = Convert.ToInt32(Console.ReadLine());
            //           double[] a = new double[n];
            //            double[] b = new double[n];
            //            double[] c = new double[n];
            //           for (int i = 0; i < n; i++)
            //           {
            //              a[i] = Convert.ToDouble(Console.ReadLine());
            //           }
            //           for(int i = 0; i < n; i++)
            //          {
            //              if (a[i] % 2 == 0)
            //               {
            //                   b[i] = a[i];
            //               }
            //               else
            //               {
            //                   c[i] = a[i];
            //              }
            //          }
            //           for (int i = 0; i < n; i++)
            //           {
            //               a[i] = b[i];
            //                a[i*n] = c[i];
            //           }
            //            for (int i = 0; i < n; i++)
            //           {
            //               Console.Write("{0},", a[i]);
            //           }
            Console.Write("n=");
            int n = int.Parse(Console.ReadLine());
            double[] arr = new double[n];
            double New = 0;
            for(int i = 0; i < n; i++)
            {
                arr[i] = double.Parse(Console.ReadLine());
            }
            for(int i = 0; i <(n/2); i++)
            {
                if (i % 2 == 0)
                {
                    
                }
                else
                {
                    New = arr[i];
                    arr[i] = arr[(n / 2) + i];
                    arr[(n / 2) + i] = New;
                }
                
            }
            for (int i = 0; i < n; i++)
            {
                Console.Write("{0},", arr[i]);
            }



        }
    }
}
