using Microsoft.VisualStudio.TestTools.UnitTesting;
using GeometricLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometricLib.Tests
{
    [TestClass()]
    public class CircleTests
    {
        [TestMethod()]
        public void Square_4_50d24()
        {
            // arrange
            double radius = 4;
            double expected = 16 * Math.PI;

            //act
            Circle circle = new Circle(radius);
            double act_result = circle.Square();

            //assert
            Assert.AreEqual(expected, act_result, "Площадь круга с радиусом {0} ожидается {1}; получилось {2}", radius, expected, act_result);
        }
    }
}