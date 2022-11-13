using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhileLoopPrime
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("ShowPrimeNumbers execution started");

            ////prime number: its divisible by 1 and itself
            //var isPrime = true; //lets start with assumption that the number user enters is prime;

            //var userWantsToContinue = true;

            //while (userWantsToContinue) //run the program until the user exits... while usernotexits keep running
            //{
            //    isPrime = true;
            //    Console.WriteLine("Enter a number");
            //    var inputNum = Convert.ToInt32(Console.ReadLine());

            //    if (inputNum <= 2)
            //    {
            //        Console.WriteLine("Program only for numbers greater than 2");
            //    }
            //    else
            //    {
            //        for (int i = 2; i < inputNum; i++)//3
            //        {
            //            if (inputNum % i == 0)
            //            {
            //                isPrime = false; //if reminder is 0 for other divisors, the number is not prime, so setting isPrime to false
            //                break;
            //            }
            //        }

            //        if (isPrime) Console.WriteLine(inputNum + " is a prime number");
            //        else Console.WriteLine(inputNum + " is not a prime number");
            //    }

            //    Console.WriteLine("Do you want to continue. Please enter Y/N");
            //    var userChoice = Console.ReadLine();
            //    if (userChoice.Equals("N"))
            //    {
            //        userWantsToContinue = false;
            //    }
            //}

            //int i = 1000;
            //int counter = 0;
            //while(counter < i)
            //{
            //    Console.WriteLine(counter);
            //    counter++;
            //}

            //Console.WriteLine("For loop starts");

            //for (int j = 0; j < 1000; j++)
            //{
            //    Console.WriteLine(j);
            //}

            //do while
            //foreach


            Console.WriteLine("ShowPrimeNumbers execution started");

            //prime number: its divisible by 1 and itself
            var isPrime = true; //lets start with assumption that the number user enters is prime;

            var userWantsToContinue = false;

            do
            {
                isPrime = true;
                Console.WriteLine("Enter a number");
                var inputNum = Convert.ToInt32(Console.ReadLine());

                if (inputNum <= 2)
                {
                    Console.WriteLine("Program only for numbers greater than 2");
                }
                else
                {
                    for (int i = 2; i < inputNum; i++)//3
                    {
                        if (inputNum % i == 0)
                        {
                            isPrime = false; //if reminder is 0 for other divisors, the number is not prime, so setting isPrime to false
                            break;
                        }
                    }

                    if (isPrime) Console.WriteLine(inputNum + " is a prime number");
                    else Console.WriteLine(inputNum + " is not a prime number");
                }

                Console.WriteLine("Do you want to continue. Please enter Y/N");
                var userChoice = Console.ReadLine();
                if (userChoice.Equals("Y"))
                {
                    userWantsToContinue = true;
                }
                else
                {
                    userWantsToContinue = false;
                }

            } while (userWantsToContinue);


            Console.ReadLine();
        }
    }
}
