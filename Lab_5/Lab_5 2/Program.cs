using System;

namespace Lab_5_2
{
    class Program
    {
        static int Progresion(int x1,int x2,int x3,int x4)
        {
            if (x2 / x1 == x3 / x2 && x3 / x2 == x4 / x3)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }
        static void Main(string[] args)
        {
            Console.Write("n=");
            int n = Convert.ToInt32(Console.ReadLine());
            int s = 0;
            int sum = 0;
            int[] arr = new int[n];
            for (int i = 0; i < n; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            for(int i = 0; i < n - 3; i++)
            {
                s = Progresion(arr[i], arr[i + 1], arr[i + 2], arr[i + 3]);
                sum += s;
            }
            Console.WriteLine(sum);

        }
    }
}
