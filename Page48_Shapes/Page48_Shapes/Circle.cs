using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Page48_Shapes
{
    public class Circle
    {
        double radius;
        public Circle()
        {
            radius = 0;
        }
        public Circle(double radius)
        {
            this.radius = radius;
        }
        public double Area()
        {
            return Math.PI * (radius * radius);
        }
    }
}
