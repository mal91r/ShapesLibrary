using Microsoft.VisualStudio.TestTools.UnitTesting;
using ShapesLibrary;
using System;

namespace ShapesLibraryTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Random()
        {
            Random rand = new Random();
            Shape? shape;
            double expected ;
            switch (rand.Next(2))
            {
                case 0:
                    shape = new Triangle(3, 4, 5);
                    expected = 6;
                    break;
                case 1:
                    shape = new Circle(2);
                    expected = 4 * Math.PI;
                    break;
                default:
                    shape = null;
                    expected = 0;
                    break;
            }
            double result = shape.Square;
            Assert.AreEqual(expected, result);
        }
        [TestMethod]
        public void Circle()
        {
            Shape circle = new Circle(2);
            double expected = 4 * Math.PI;
            Assert.AreEqual(expected, circle.Square);
        }
        [TestMethod]
        public void Triangle()
        {
            Shape triangle = new Triangle(6, 5, 5);
            double expected = 12;
            Assert.AreEqual(expected, triangle.Square);
        }
        [TestMethod]
        public void IsTriangleRectangled()
        {
            Shape triangle = new Triangle(3, 4, 5);
            bool expected = true;
            Assert.AreEqual(expected, (triangle as Triangle).isRectangular);
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentException),
            "Incorrect sides")]
        public void IncorrectTriangle()
        {
            Shape triangle = new Triangle(6, 1, 1);
            double result = triangle.Square;
        }
    }
}