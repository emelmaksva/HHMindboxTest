using System;

namespace GeometricLib
{
    public class Triangle : Shape
    {
        private double side1 { get; set; }
        private double side2 { get; set; }
        private double side3 { get; set; }

        public Triangle (double s1, double s2, double s3) {
            if (IsValid(s1, s2, s3))
            {
                side1 = s1;
                side2 = s2;
                side3 = s3;
            }
        }

        public override double Square()
        {
            double HalfPerim = Perimeter()/2d;
            return Math.Sqrt(HalfPerim * (HalfPerim - side1) * (HalfPerim - side2) * (HalfPerim - side3) );
        }

        public double Perimeter()
        {
            return side1 + side2 + side3;
        }

        public bool IsRightAngle()
        {
            double s1_sq = side1 * side1;
            double s2_sq = side2 * side2;
            double s3_sq = side3 * side3;
            if (s1_sq == s2_sq + s3_sq || s2_sq == s1_sq + s3_sq || s3_sq == s1_sq + s2_sq)
                return true;

            return false;
        }

        private static bool IsValid(double s1, double s2, double s3)
        {
            if (s1 <= 0 || s2 <= 0 || s3 <= 0)
                throw new Exception("Длина сторон треугольника должна быть больше 0");
            if(s1+s2 <= s3 || s2 + s3 <= s1 || s3 + s1 <= s2)
                throw new Exception("Длина двух сторон треугольника должна быть больше третей");
            return true;
        }
    }
}
