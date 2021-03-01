using System;

namespace Lab_5_3
{
    class Program
    {
        static double Rec(double n)
        {
            if (n == 0)
            {
                return 0;
            }
            if(n==1||n==2||n==3)
            {
                return 7;
            }
            else
            {
                return Rec(n-1)*(1+Rec(n-2)+Rec(n-3)/Rec(n-4));
            }
        }
        static void Main(string[] args)
        {
            Console.Write("n=");
            double n = Convert.ToDouble(Console.ReadLine());
            double s = Rec(n);
            Console.WriteLine(s);
            
        }
    }
}
