using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region comments
            //PrimeNumber pnClass = new PrimeNumber(); // here I am creating an object of the class 
            //we organize code(Business Logic) into related classes and methods
            // OOPS concepts Object oriented programming
            //Encapsulation, Inheritance

            //pnClass.ShowPrimeNumbers();

            //Console.WriteLine("enter 3 char day");
            //var dayOfWeek = Convert.ToInt32(Console.ReadLine());

            //if(dayOfWeek.Equals("Mon"))
            //{
            //    Console.WriteLine("First day of work week");
            //}
            //else if (dayOfWeek.Equals("Tue"))
            //{
            //    Console.WriteLine("Second day of work week");
            //}
            //else if (dayOfWeek.Equals("Wed"))
            //{
            //    Console.WriteLine("Hump day of work week");
            //}
            //else if (dayOfWeek.Equals("Thu"))
            //{
            //    Console.WriteLine("Weekend is almost here");
            //}
            //else if (dayOfWeek.Equals("Fri"))
            //{
            //    Console.WriteLine("Its weekend. Not really but. Drinks at 5.");

            //}
            //else if (dayOfWeek.Equals("Sat"))
            //{
            //    Console.WriteLine("Do house chores");

            //}
            //else if (dayOfWeek.Equals("Sun"))
            //{
            //    Console.WriteLine("Watch football and get ready for Monday");

            //}

            //switch (dayOfWeek.ToUpper())
            //{
            //    case "MON":
            //        Console.WriteLine("First day of work week");
            //        break;
            //    case "TUE":
            //        Console.WriteLine("Second day of work week");
            //        break;
            //    case "WED":
            //        Console.WriteLine("Hump day of work week");
            //        break;
            //    case "THU":
            //        Console.WriteLine("Weekend is almost here");
            //        break;
            //    case "FRI":
            //        Console.WriteLine("Its weekend. Not really but. Drinks at 5.");
            //        break;
            //    case "SAT":
            //        Console.WriteLine("Do house chores");
            //        break;
            //    case "SUN":
            //        Console.WriteLine("Watch football and get ready for Monday");
            //        break;
            //    default:
            //        Console.WriteLine("I do not understand what you entered");
            //        break;
            //}

            //switch (dayOfWeek)
            //{
            //    case 1:
            //        Console.WriteLine("First day of work week");
            //        break;
            //    case 2:
            //        Console.WriteLine("Second day of work week");
            //        break;
            //    case 3:
            //        Console.WriteLine("Hump day of work week");
            //        break;
            //    case 4:
            //        Console.WriteLine("Weekend is almost here");
            //        break;
            //    case 5:
            //        Console.WriteLine("Its weekend. Not really but. Drinks at 5.");
            //        break;
            //    case 6:
            //        Console.WriteLine("Do house chores");
            //        break;
            //    case 7:
            //        Console.WriteLine("Watch football and get ready for Monday");
            //        break;
            //    default:
            //        Console.WriteLine("I do not understand what you entered");
            //        break;
            //}

            #endregion

            Console.WriteLine("enter an input");
            var input1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("enter another input");
            var input2 = Console.ReadLine();

            var output = input1.ToString() + input2; // when you do a + on strings what happens, should you do a +

            Console.WriteLine(output);


            Console.Read();
            //String vs StringBuilder

        }


    }
}
