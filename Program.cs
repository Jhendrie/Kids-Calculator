using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Project_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                bool endApp = false;
                // Display title as the C# kids calculator app.
                Console.WriteLine("Kids Calculator in C#\r");
                Console.WriteLine("    +       +            +        +++++++  +    +        ++++      +   +    +       ++++    +++      I");
                Console.WriteLine("   +  +   +  +         +   +         +     +    +        +   +     +   +    +       +      +         I");
                Console.WriteLine("  +    + +    +       +++++++        +     ++++++        ++++      +   +    +       ++++    +++      I");
                Console.WriteLine(" +      +      +     +       +       +     +    +        +  +      +   +    +       +          +       ");
                Console.WriteLine("+               +   +         +      +     +    +        +   +     +++++    ++++    ++++    +++      I");

                while (!endApp)
                {
                    // Declare variables and set to empty.
                    string numInput1 = "";
                    string numInput2 = "";
                    double result = 0;

                    // Ask the user to type the first number.
                    Console.Write("\t1st number, Enter: ");
                    numInput1 = Console.ReadLine();

                    double cleanNum1 = 0;
                    while (!double.TryParse(numInput1, out cleanNum1))
                    {
                        Console.Write("Try Again, Enter A Number: ");
                        numInput1 = Console.ReadLine();
                    }

                    // Ask the user to type the second number.
                    Console.Write("\t2nd number, Enter: ");
                    numInput2 = Console.ReadLine();

                    double cleanNum2 = 0;
                    while (!double.TryParse(numInput2, out cleanNum2))
                    {
                        Console.Write("Try Again, Enter A Number: ");
                        numInput2 = Console.ReadLine();
                    }

                    // Ask the user to choose an operator.
                    Console.WriteLine("\tChoose an operation from the following list:");
                    Console.WriteLine("\t1 - Add");
                    Console.WriteLine("\t2 - Subtract");
                    Console.WriteLine("\t3 - Multiply");
                    Console.WriteLine("\t4 - Divide");
                    Console.WriteLine("\t5 - Exponent\n");
                    
                    Console.WriteLine("\tChoose an area operation from the following list:");

                    Console.WriteLine("\tNote: Square and Circle use Number 1 only");
                    Console.WriteLine("\tNote: Rectangle is Number 1  = Length and Number 2 is = width\n\n\n");
                    Console.WriteLine("\t6 - Square ");
                    Console.WriteLine("\t7 - Circle");
                    Console.WriteLine("\t8 - Rectangle");
                    Console.WriteLine("\t9 - Triangle\n");
                    

                    Console.WriteLine("\tTimes tables out to 15 for review");
                    Console.WriteLine("\tNote: Number 1 is the result of the times table\n");
                    Console.WriteLine("\t10 - Times Table");
                    Console.WriteLine("\tChoose something dude? ");
                    string op = Console.ReadLine();

                    try
                    {
                        result = BasicMath.DoOperation(cleanNum1, cleanNum2, op);
                        if (double.IsNaN(result))
                        {//deleted this due to issue with the the second number having issues in the area operations
                           // Console.WriteLine("This operation will result in a mathematical error.\n");
                        }
                        else Console.WriteLine("= {0:0.##}\n",result);
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("Oh no! An exception occurred trying to do the math.\n - Details: " + e.Message);
                    }

                    Console.WriteLine("------------------------\n");

                    // Wait for the user to respond before closing.
                    Console.Write("Press 'n' and Enter to close the app, or press any other key and Enter to continue: ");
                    if (Console.ReadLine() == "n") endApp = true;

                    Console.WriteLine("\n"); 
                }
                return;
            }
        }
    }
}
    









