using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_9_2
{
    class Bus
    {
        public string mark { get; set; }
        public int mas { get; set; }
        public int SeatsNamber { get; set; }
        public int PassengerNaber { get; set; }

        public Bus(string mark, int mas, int SeatsNamber, int PassengerNaber)
        {
            this.mark = mark;
            this.mas = mas;
            this.SeatsNamber = SeatsNamber;
            this.PassengerNaber = PassengerNaber;
        }
        public int Mmas()
        {
            return mas + (PassengerNaber * 62);
        }
    }
}
