using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Project_Calculator
{
    class BasicMath
    {
        public static double DoOperation(double num1, double num2, string op)
        {
            double result = double.NaN; // Default value is "not-a-number" which we use if an operation, such as division, could result in an error.

            // Use a switch statement to do the math.
            switch (op)
            {
                case "1":
                    Console.Write($"{num1} + {num2} "); result = num1 + num2;
                    break;
                case "2":
                    Console.Write($"{num1} - {num2}"); result = num1 - num2;
                    break;
                case "3":
                    Console.Write($"{num1} x {num2}"); result = num1 * num2;
                    break;
                case "4":
                    // Ask the user to enter a non-zero divisor.
                    if (num2 != 0)
                    {
                        Console.Write($"{num1}/{num2}"); result = num1 / num2;
                    }
                    break;

                case "5"://Make it iterate the number with a loop
                    {
                        Console.WriteLine($"{num1}^{num2}"); result = Math.Pow(num1, num2);
                    }


                    break;


                case "6"://accepts one number
                    Shape[] square = { new Square(num1) };
                    foreach (var shape in square)

                        Console.WriteLine($"\n\n\n\nArea of Square is {num1} x {num1} = {shape.Area()}\n\n");

                    Console.WriteLine($"                     {num1}                ");
                    Console.WriteLine("              ----------------           ");
                    Console.WriteLine("              |              |           ");
                    Console.WriteLine($"       {num1}     |              |  {num1}    ");
                    Console.WriteLine("              |              |           ");
                    Console.WriteLine($"              |              |           ");
                    Console.WriteLine($"              ----------------           ");
                    Console.WriteLine($"                     {num1}              ");
                    break;

                case "7"://accepts one number
                    Shape[] circle = { new Circle(num1) };
                    foreach (var shape in circle)

                        Console.WriteLine($"Area of Circle : {Shape.GetArea(shape)}");
                    break;
                case "8":
                    Shape[] rectangle = { new Rectangle(num1, num2) };
                    foreach (var shape in rectangle)

                        Console.WriteLine($"Area of Rectangle : {Shape.GetArea(shape)}");

                    Console.WriteLine($"                     {num1}                ");
                    Console.WriteLine("              ---------------------           ");
                    Console.WriteLine("              |                   |           ");
                    Console.WriteLine($"       {num2}     |                   |  {num2}    ");
                    Console.WriteLine("              |                   |           ");
                    Console.WriteLine($"              |                   |           ");
                    Console.WriteLine($"              ---------------------           ");
                    Console.WriteLine($"                     {num1}              ");
                    break;
                    
                case "9":
                    Shape[] Triangle = { new Triangle(num1, num2) };
                    foreach (var shape in Triangle)

                        Console.WriteLine($"Area of Triangle : {Shape.GetArea(shape)}");
                    break;

                case "10"://loop for times tables accepts one number
                    {
                        Console.WriteLine("\n\n\n\n");
                        for (int i = 1; i <= num1; i++)
                        {
                            for (int j = 1; j <= num1; j++)
                            {
                                
                                Console.Write(j * i + "\t");
                            }
                            Console.WriteLine("");
                        }
                    }
                            break;

                        
                    







                // Return text for an incorrect option entry.
                default:

                    break;

            }
            return result;
        }
    }
}








