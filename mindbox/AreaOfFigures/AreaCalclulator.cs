using System;
using System.Collections.Generic;
using System.Text;
using AreaOfFigures.Figures;

namespace AreaOfFigures
{
    public static class AreaCalculator
    {
        // Определяет фигуру по количеству сторон и возвращает её площадь
        public static double FigureAreaCalculating(Side[] sides)
        {
            switch (sides.Length)
            {
                case 0:
                    throw new FigureDefinitionException("Can't define figure with 0 sides.");
                case 1: //круг
                    Circle circle;
                    circle = new Circle(sides);

                    return circle.CalculateArea();

                case 3: //треугольник
                    Triangle triangle;
                    triangle = new Triangle(sides);

                    return triangle.CalculateArea();

                default:
                    throw new FigureDefinitionException("Can't define figure with " + sides.Length + " sides.");
            }
        }


    }
    
    // Если метод не может определить фигуру, выбрасывает FigureDefinitionException
    public class FigureDefinitionException : Exception
    {
        public FigureDefinitionException(string message)
            : base(message) { }
    }

}

