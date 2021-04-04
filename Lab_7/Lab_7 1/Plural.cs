using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_7_1
{
    class Plural
    {
             
        int[] arr = new int[5];
        public Plural(int[]arr)
        {
            this.arr = arr;
            
        }
       

        public int[] Print()
        {
            return arr;
        }
        public int Sum()
        {
            int sum = 0;
            for(int i = 0; i < 5; i++)
            {
                sum += arr[i];
            }
            return sum;
        }
        public int Max()
        {
            int a = 0;
            for(int i = 0; i < 5; i++)
            {
                if (a < arr[i])
                {
                    a = arr[i];
                }
            }
            return a;
        }

    }
    

     

    


    
}
