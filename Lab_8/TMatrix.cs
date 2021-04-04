using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_8
{
    class TMatrix : Matrix
    {
        int[,] matrix = new int[n, n];

        public TMatrix(int[,] matrix )
        {
            this.matrix = matrix;
        }
        public int[,] Print()
        {
            return matrix;
        }
        public int Max()
        {
            int a = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (a < matrix[i, j] )
                    {
                        a = matrix[i, j];
                    }
                }
            }
            return a;
        }
        public int Min()
        {
            int a = matrix[0,0];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (matrix[i, j] < a)
                    {
                        a = matrix[i, j];
                    }
                }
            }
            return a;
        }
        public int Sum()
        {
            int sum = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {                                    
                     sum += matrix[i, j];
                }
            }
            return sum;
        }
    }
}
