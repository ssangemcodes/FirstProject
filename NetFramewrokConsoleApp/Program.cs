using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace NetFramewrokConsoleApp
{
    internal class Program
    {
        static void Main(string[] args) //entry point to the program
        {
            /*Console.WriteLine("Addition Program Start point");
            Console.WriteLine("Addition Program Start point");
            Console.WriteLine("args count: " + args.Length);
            if (args.Length > 0)
            {
                Console.WriteLine("args: " + args[0]);
                Console.WriteLine("args: " + args[1]);
                Console.WriteLine("args: " + args[2]);
            }*/

            //int num1;
            //int num2;
            //int result;

            //Console.WriteLine("enter first number"); //appending welcome message to the name of the user and showing on the screen

            //string num1input = Console.ReadLine();
            //num1 = Convert.ToInt32(num1input); //converting string value to integer

            //Console.WriteLine("enter second number"); //appending welcome message to the name of the user and showing on the screen
            //num2 = Convert.ToInt32(Console.ReadLine()); //converting user input value to integer, this is a short cut for line 20 and 21

            //result = num1 + num2;//num1 and num2 are operands and + is an operator

            //Console.WriteLine(result);
            //Console.ReadLine();

            int num1;
            long lnum1;
            short snum1; 
            
            Console.WriteLine("enter a number");
            string num1input = Console.ReadLine(); //= assignment operator
            num1 = Convert.ToInt32(num1input); //converting string value to integer

            decimal quotient0;
            float quotient;
            double quotient1;

            var reminder = num1 % 2; // % symbol, mod operator, its dividing two number and returning reminder
                                     // I do not want to guess the type of variable... declare the variable based on expression on the right side

            //if(reminder == 0) //== comparision operator, if reminder equals 0, the result is true... when its true the execution goes inside the if condition
            //{
            //    Console.WriteLine("It is an even number");
            //}

            //if(reminder == 1)
            //{
            //    Console.WriteLine("It is an odd number");
            //}

            //if (reminder == 0) //== comparision operator, if reminder equals 0, the result is true... when its true the execution goes inside the if condition
            //{
            //    Console.WriteLine("It is an even number");
            //}
            //else
            //{
            //    Console.WriteLine("It is an odd number");
            //}

            //if (reminder == 0) //== comparision operator, if reminder equals 0, the result is true... when its true the execution goes inside the if condition
            //{
            //    Console.WriteLine("It is an even number");
            //}
            //else if(reminder == 1)
            //{
            //    Console.WriteLine("It is an odd number");
            //}

            //I want to show numbers from 1-10 and display if they are even or odd

            
            //for is iteration statement... it repeats an operation a few times... few times is  defined by the condition inside the operator
            for (int i = 0; i < 10; i++) //++ is nothing but incremental operator its same as (i=i+1)
            {
                reminder = i % 2;
                if (reminder == 0) //== comparision operator, if reminder equals 0, the result is true... when its true the execution goes inside the if condition
                {
                    Console.WriteLine(i + " is an even number");
                }
                else
                {
                    Console.WriteLine(i + " is an odd number");
                }
            }

            Console.ReadLine();
        }
    }
}
