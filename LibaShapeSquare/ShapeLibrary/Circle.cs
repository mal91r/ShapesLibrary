using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapesLibrary
{
    public class Circle : Shape
    {
        private double _radius;
        public Circle(double radius)
        {
            _radius = radius;
        }
        public override double Perimeter => 2 * Math.PI * _radius;
        public override double Square => Math.PI * Math.Pow(_radius, 2);
    }
}
