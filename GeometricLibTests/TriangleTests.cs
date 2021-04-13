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
    public class TriangleTests
    {
        [TestMethod()]
        public void Square_3and4and5_6()
        {
            // arrange
            double s1 = 3;
            double s2 = 4;
            double s3 = 5;
            double expected = 6;

            //act
            Triangle triangle = new Triangle(s1, s2, s3);
            double act_result = triangle.Square();

            //assert
            Assert.AreEqual(expected, act_result, "Площадь треугольника со сторонами {0}, {1}, {2} ожидается {3}; получилось {4}", s1, s2, s3, expected, act_result);
        }

        [TestMethod()]
        public void IsRightAngleTest_3and4and5_true()
        {
            // arrange
            double s1 = 3;
            double s2 = 4;
            double s3 = 5;
            bool expected = true;

            //act
            Triangle triangle = new Triangle(s1, s2, s3);
            bool act_result = triangle.IsRightAngle();

            //assert
            Assert.AreEqual(expected, act_result, "Треугольник со сторонами {0}, {1}, {2} должен быть прямоугольным", s1, s2, s3);
        }

        [TestMethod()]
        public void IsRightAngleTest_4and8and5_false()
        {
            // arrange
            double s1 = 4;
            double s2 = 8;
            double s3 = 5;
            bool expected = false;

            //act
            Triangle triangle = new Triangle(s1, s2, s3);
            bool act_result = triangle.IsRightAngle();

            //assert
            Assert.AreEqual(expected, act_result, "Треугольник со сторонами {0}, {1}, {2} должен быть  прямоугольным", s1,s2,s3);
        }
    }
}