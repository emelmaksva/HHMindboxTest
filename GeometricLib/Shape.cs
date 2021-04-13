using System;

namespace GeometricLib
{
    // <summary>
    // Абстрактный класс фигур. Определяет общий функционал наследников -
    // нахождение площади, проверку на возможность существования фигуры
    // </summary>
    abstract public class Shape
    {
        public abstract double Square();
    }
}
