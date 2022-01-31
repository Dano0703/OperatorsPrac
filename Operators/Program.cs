using System;

namespace Operators
{
   
    internal class Comparison
    {
        //Main method begins the execution of the C# app
        static void Main()
        {
            //Prompt user and reads the first number
            Console.WriteLine("Enter first integer: ");
            int number1 = int.Parse(Console.ReadLine());

            //Prompt user and read the second integer
            Console.WriteLine("Enter second intenger: ");
            int number2 = int.Parse(Console.ReadLine());

            if (number1 == number2)
            {
                Console.WriteLine($"{number1} == {number2}");
            }
            
            if (number1 != number2)
            {
                Console.WriteLine($"{number1} != {number2}");
            }
            
            if (number1 < number2)
            {
                Console.WriteLine($"{number1}<{number2}");
            }
            
            if (number1 > number2)
            {
                Console.WriteLine($"{number1} > {number2}");
            }
 
            if (number1 <= number2)
            {
                Console.WriteLine($"{number1} <= {number2}");
            }
 
            if (number1 >= number2)
            {
                Console.WriteLine($"{number1} >= {number2}");
            }
        }//end Main
    }//end Class Comparsion
}
