using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Shape
    {
        public double Area(double length,double breadth)
        {
            return length*breadth;
        }

        public double Area(double radius)
        {
            return 3.14*radius*radius;
        }
        public double Area(double baseLength,double height,bool isTriangle)
        {
            return 0.5*baseLength*height;
        }
    }
}
