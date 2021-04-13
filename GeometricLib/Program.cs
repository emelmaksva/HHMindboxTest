using System;

namespace GeometricLib
{
    class Program
    {
        static void Main(string[] args)
        {
            //Пример использования 
            Shape shape1 = new Circle(5);
            Shape shape2 = new Triangle(5,7,6);
            Console.WriteLine("Прощадь фигуры 1 = {0}; площадь фигуры 2 = {1}", shape1.Square(), shape2.Square());
            Console.WriteLine("Треугольник (фигура 2) прямоугольный - {0}", (shape2 as Triangle).IsRightAngle());
        }
    }
}
