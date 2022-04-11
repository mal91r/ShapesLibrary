using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapesLibrary
{
    public class Triangle : Shape
    {
        private double _a;
        private double _b;
        private double _c;
        public Triangle(double a, double b, double c)
        {
            if (a >= b + c || b >= a + c || c >= b + a)
            {
                throw new ArgumentException("Incorrect sides");
            }
            _a = a;
            _b = b;
            _c = c;
        }
        public override double Perimeter => _a + _b + _c;
        private double p => Perimeter / 2;
        public override double Square => Math.Sqrt(p * (p - _a) * (p - _b) * (p - _c));
        public bool isRectangular => _a * _a + _b * _b == _c * _c;
    }
}
