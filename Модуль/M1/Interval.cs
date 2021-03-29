using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M1
{
    class Interval:Interval2D
    {
        double x3;
        double y3;
        double x4;
        double y4;
        double n;
        public Interval(double n)
        {
            this.n = 0;
        }
        public Interval(double x3, double y3, double x4, double y4,double n)
        {
            this.x3 = x3;
            this.y3 = y3;
            this.x4 = x4;
            this.y4 = y4;
            this.n = n;
        }
        public double Sum()
        {
            return Math.Sqrt(Math.Pow(x4 - x1, 2) + Math.Pow(y4 - y1, 2));
        }
        public double Add()
        {
            return Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(n*y2 - n*y1, 2));

        }
    }

}
