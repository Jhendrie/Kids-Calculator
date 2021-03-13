using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Project_Calculator
{
    public abstract class Shape
    {
        public abstract double Area();
        public static double GetArea(Shape shape)
        {
            return shape.Area();
        }
    }

    public class Square : Shape
    {
        private double size;
        public Square(double length)
        {
            this.size = length;
        }
        public override double Area()
        {
            return Math.Pow(size, 2);
        }
    }

    public class Circle : Shape
    {
        private double radius;
        public Circle(double radius)
        {
            this.radius = radius;
        }
        public override double Area()
        {
            return Math.Round(Math.PI * Math.Pow(radius, 2), 2);

        }
    }
    public class Rectangle : Shape 
    {
        private double length;
        private double width;
        public Rectangle(double length, double width)
        {
            this.length = length;
            this.width = width;
        }
        public override double Area()
        {
            return length * width;
        }
    }
    public class Triangle : Shape
    {
        private double Base;
        private double Height;
        public Triangle(double Base, double Height)
        {
            this.Base = Base;
            this.Height = Height;
        }

        public override double Area()
        {
            return Height * (Base / 2);
        }
    }
}
