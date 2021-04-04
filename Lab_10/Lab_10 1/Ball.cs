using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_10_1
{
    class Ball : Circle
    {
        double z;
        double z1;
        double r;
        public Ball()
        {

        }
        public Ball(double z, double z1, double r)
        {
            this.z = z;
            this.z1 = z1;
            this.r = r;
        }
        public double V()
        {
            double v = (4 / 3) * Math.PI * Math.Pow(r, 3);
            return v;
        }
        public string TDistanse()
        {
            string d = "";
            double a = Math.Sqrt(Math.Pow(x1 - x, 2) + Math.Pow(y1 - y, 2)+Math.Pow(z1-z,2));
            if (a <= r)
            {
                d = $"Точка належить колу";
            }
            else
            {
                d = $"Точка не належить колу";
            }
            return d;
        }
    }
}
