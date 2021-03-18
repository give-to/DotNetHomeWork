using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork3
{
    public class Triangle : Shape {
        private double a;
        private double b;
        private double c;
        public double A
        { 
            set
            { 
                if(value<=0)
                {
                    a = 0;
                }
                else
                {
                    a = value;
                }
            }
            get 
            {
                return a;
            }
        }
        public double B
        {
            set
            {
                if (value <= 0)
                {
                    b = 0;
                }
                else
                {
                    b = value;
                }
            }
            get
            {
                return b;
            }
        }

        public double C
        {
            set
            {
                if (value <= 0)
                {
                    c = 0;
                }
                else
                {
                    c = value;
                }
            }
            get
            {
                return c;
            }
        }
        public Triangle(double a,double b,double c)
        {
            A = a;
            B = b;
            C = c;
        }
        public Triangle(Random random)
        {
            A = random.NextDouble()*10;
            B = random.NextDouble() * 10;
            C = random.NextDouble() * 10;
        }
        public double Area()
        {
            double p = (a + b + c) / 2;
            return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
        }

        public bool Judge()
        {
            if(a+b>c && a+c>b && b+c>a && a>0 && b>0 && c>0)
            {
                return true;
            }
            return false;
        }
    
    }
}
