using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_11_1
{
    class SEquation: TEquation_
    {
        public double Arr()
        {


            int n = 5;
            double sum = 0;
            Random rand = new Random(DateTime.Now.Millisecond);
            double[] A = new double[n];
            double[] B = new double[n];
            double[] C = new double[n];
            for(int i = 0; i < n; i++)
            {
                A[i] = rand.Next(-100, 100);
                B[i] = rand.Next(-100, 100);
                C[i] = rand.Next(-100, 100);
            }
            for (int i = 0; i < n; i++)
            {
                double d = Math.Pow(B[i], 2) - 4 * A[i] * C[i];
                if (d > 0)
                {
                    double x1 = (-B[i] - d) / 2 * A[i];
                    double x2 = (-B[i] + d) / 2 * A[i];
                    sum += x1 + x2;
                }
                else if (d == 0)
                {
                    double x = -B[i] / 2 * A[i];
                    sum += x;
                }
            }
            return sum;

        }
    }
}
