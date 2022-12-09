using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Functions
{
    //increase reusability of code
    internal class Program
    {
        static void Main(string[] args)
        {
            //sum of two numbers
            Console.WriteLine("enter first number");
            var num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("enter second number");
            var num2 = Convert.ToInt32(Console.ReadLine());

            //var sum = num1 + num2;
            var sum = Sum(num1, num2);  // we are calling a method called Sum,with aruguments num1 and num2
            Console.WriteLine(sum);

            Console.ReadLine();
        }

        public static int Sum(int x, int y) // method definition, name of the method, arguments (inputs to the method), return (Output) type
        {
            var sum = x + y;
            return sum;
        }

        public static int Sum(int x, float y) // Method overloading
        {
            var sum = x + y;
            return Convert.ToInt32(sum);

        }

        public static int CalculateInterest(double principle, float interestRate) // method definition, name of the method, arguments, return type
        {
            //calculate interest
            //return the interest value
            return 0;
        }
    }

    public class Test
    {
        //public void TestSum()
        //{
        //    Program.
        //}
    }
}
