using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_creating_exceptions
{
    internal class Circle
    {
        private double radius;

        public Circle(double radius)
        {
            this.radius = radius;
        }

        public double SetRadius()
        {
            if (radius <= 0)
            {
                throw new InvalidRadiusException(radius);
            }
            return radius;
        }

        public override string ToString()
        {
            return "The radius is " + radius + ".";
        }
    }
}
