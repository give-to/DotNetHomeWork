using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork3
{
    public class Rectangle:Shape
    {
        protected double length;
        protected double wide;

        public Rectangle(double length,double wide)
        {
            Length = length;
            Wide = wide;
        }
        public Rectangle(Random random)
        {
            Length = random.NextDouble() * 10;
            Wide = random.NextDouble() * 10;
        }

        public double Length
        {
            get { return length; }
            set
            {
                if(value<=0)
                {
                    length = 0;
                }
                else
                {
                    length = value;
                }
            }
        }

        public double Wide
        {
            get { return wide; }
            set
            {
                if (value <= 0)
                {
                    wide = 0;
                }
                else
                {
                    wide = value;
                }
            }
        }
        
        public double Area()
        {
            return wide * length;
        }
        public bool Judge()
        {
            if(wide>0 && length>0)
            {
                return true;
            }
            return false;
        }
    }
}
