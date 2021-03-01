using System;

namespace Lab_2_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("n=");
            int n = Convert.ToInt32(Console.ReadLine());
            int i = 0;
            while (n > 0)
            {
                i++;
                n /= 10;
            }
            Console.WriteLine(i);
            

            }
            
        }
    }
}
