using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBSimulation
{
    class PC
    {
        
        public string spare_part_name { get; set; }
        public string car_name{ get; set; }

        private double _graduation_year;
        public double graduation_year
        {
            get
            {
                return _graduation_year;
            }
            set
            {
                if (value >= 0)
                    _graduation_year = value;
                else
                    throw new Exception("Рік випуску не може бути відємним");
            }
        }

        private double _horsepower;
        public double horsepower
        {
            get
            {
                return _horsepower;
            }
            set
            {
                if (value >= 0)
                    _horsepower = value;
                else
                    throw new Exception("Домашній номер телефону не може бути відємним");
            }
        }

      

        public PC(string spare_part_name, string car_name, double graduation_year, double horsepower)
        {
            this.spare_part_name = spare_part_name;
            this.car_name = car_name;
            this.graduation_year = graduation_year;
            this.horsepower = horsepower;

        }

    }
}
