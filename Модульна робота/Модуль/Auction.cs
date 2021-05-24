using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Модуль
{
    class Auction
        
    {
        public string name;
        public int start_date;
        public int end_date;
        public int start_price;
        public int end_prise;

        public Auction(string name,int start_date,int end_date,int start_price, int end_prise)
        {
            this.name = name;
            this.start_date = start_date;
            this.end_date = end_date;
            this.start_price = start_price;
            this.end_prise = end_prise;



        }
    }
}
