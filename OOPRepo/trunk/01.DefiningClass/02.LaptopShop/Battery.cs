using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.LaptopShop
{
    public class Battery
    {
        private string type;

        private double hours;

        public Battery(string type, double hours)
        {
            this.Type = type;
            this.Hours = hours;
        }

        public string Type
        {
            get
            {
                return this.type;
            }

            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Invalid type of battery");
                }

                this.type = value;
            }
        }

        public double Hours
        {
            get
            {
                return this.hours;
            }

            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Battery hours cannot be a negative");
                }

                this.hours = value;
            }
        }
    }
}
