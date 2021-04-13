using System;

namespace GeometricLib
{
    public class Circle : Shape
    {
        private double Radius { get; set; }

        public Circle(double radius) {
            if (IsValid(radius))
                Radius = radius;
        }

        public override double Square()
        {
            return Math.PI * Radius * Radius;
        }

        private static bool IsValid(double radius)
        {
            if (radius > 0)
                return true;
            else
                throw new Exception("Длина окружности должна быть больше 0");
        }
    }
}
