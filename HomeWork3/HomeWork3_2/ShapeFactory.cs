using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HomeWork3;
namespace HomeWork3_2
{
    enum ShapeName
    {
        triangle,
        rectangle,
        square
    }
    class ShapeFactory
    {
        public static Shape Manufacture(ShapeName sn)
        {
            Random random = new Random();
            switch(sn)
            {
                case ShapeName.rectangle:
                    return new Rectangle(random);
                case ShapeName.square:
                    return new Square(random);
                case ShapeName.triangle:
                    return new Triangle(random);
                default:
                    return null;
            }
        }
    }
}
