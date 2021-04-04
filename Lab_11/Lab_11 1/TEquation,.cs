using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_11_1
{
    class TEquation_
    {
        double b;
        double c;
        double n;
        public TEquation_()
        {

        }
        public TEquation_(double b,double c, double n)
        {
            this.b = b;
            this.c = c;
            this.n = n;
        }
        public string Solution()
        {
            string v = "";
            if (b == 0 && c == 0)
            {
                v = "Рівняння має безліч коркнів";
            }
            else if (b == 0)
            {
                v = "Рівняння немає коренів";
            }
            else if (b != 0)
            {
                double f = (c / b);
                v = $"{f}";
            }
            return v;
        }
        public string Comparison()
        {
            string v = "";
            double f = (c / b);
            if (n == f)
            {
                v = "Беде коренем рівняння";
            }
            else
            {
                v = "Не буде коренем рівнянням";
            }
            return v;
        }
        public double Equ()
        {
            int n = 5;
            double sum = 0;
            Random rand = new Random(DateTime.Now.Millisecond);
            double[] A = new double[n];
            double[] B = new double[n];
            for (int i = 0; i < n; i++)
            {
                A[i] = rand.Next(-100, 100);
                B[i] = rand.Next(-100, 100);               
            }
            for (int i = 0; i < n; i++)
            {
                double f = A[i] / B[i];
                sum += f;
            }
            return sum;
        }
    }
}
