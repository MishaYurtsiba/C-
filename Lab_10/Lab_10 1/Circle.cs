using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_10_1
{
    class Circle
    {
        public double x;
        public double y;
        public double r;
        public double x1;
        public double y1;
        public Circle()
        {

        }
        public Circle(double x,double y,double r, double x1, double y1)
        {
            this.x = x;
            this.y = y;
            this.r = r;
            this.x1 = x1;
            this.y1 = y1;

        }
        public double S()
        {
            double s = Math.PI * Math.Pow(r, 2);
            return s;
        }
        public string Distanse()
        {
            string d = "";
            double a = Math.Sqrt(Math.Pow(x1 - x, 2) + Math.Pow(y1 - y, 2));
            if (a <= r)
            {
                d=$"Точка належить кругу";
            }
            else
            {
                d= $"Точка не належить кругу";
            }
            return d;
        }



    }
}
