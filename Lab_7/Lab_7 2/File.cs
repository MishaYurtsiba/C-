using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_7_2
{
    class File
    {
        string name;
        string expansion;
        int color;
        int height;
        int width;
        public File(string name,string expansion,int color,int height,int width)
        {
            this.name = name;
            this.expansion = expansion;
            this.color = color;
            this.height = height;
            this.width = width;
        }
        public int Size()
        {
            int s = height * width * color;
            return s;
        }
        public int Namber_of_color()
        {
            int r = 0;
            if (color == 8)
            {
                r = 258;
            }
            else if (color == 12)
            {
                r = 4096;
            }
            else if (color == 16)
            {
                r = 65536;
            }
            else if (color == 18)
            {
                r = 262144;
            }
            else if (color == 24)
            {
                r = 16700000;
            }
            return r;
        }
      
    
    }
}
