using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M1
{
    class Interval2D
    {
       public double x1;
        public double y1;
        public double x2;
        public double y2;
        public Interval2D()
        {

            double x1 = 0;
            double y1 = 0;
            double x2 = 0;
            double y2 = 0;
        }
        public Interval2D(double x1, double y1, double x2, double y2)
        {
            this.x1 = x1;
            this.y1 = y1;
            this.x2 = x2;
            this.y2 = y2;
        }
        public string Print()
        {
            return $"Координати першої точки({x1},{y1}) Координати другої точки({x2},{y2})";
        }
        public double Length()
        {
            return Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
        }
        public string Middle()
        {
            double x = (x1 + x2 / 2);
            double y = (y1 + y2 / 2);
            return $"({x},{y})";
        }


    }
}
