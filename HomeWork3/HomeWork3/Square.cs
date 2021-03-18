using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork3
{
    public class Square:Shape
    {
        private double side;

        public double Side
        {
            get { return side; }
            set
            {
                if (value <= 0)
                {
                    side = 0;
                }
                else
                {
                    side = value;
                }
            }
        }

        public Square(double s) {
            Side = s;
        }
        public Square(Random random)
        {
            Side = random.NextDouble() * 10;
        }

        public double Area()
        {
            return side * side;
        }
        
        public bool Judge()
        {
            if (side > 0)
                return true;
            return false;
        }
    }
}
