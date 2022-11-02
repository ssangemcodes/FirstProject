using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterations
{
    public class PrimeNumber
    {
        public void ShowPrimeNumbers()
        {
            Console.WriteLine("ShowPrimeNumbers execution started");
            Console.WriteLine("Enter a number");
            var inputNum = Convert.ToInt32(Console.ReadLine());

            //prime number: its divisible by 1 and itself
            var isPrime = true; //lets start with assumption that the number user enters is prime;

            if (inputNum <= 2)
            {
                Console.WriteLine("Program only for numbers greater than 2");
                //return;
            }
            else
            {
                for (int i = 2; i < inputNum; i++)//3
                {
                    if(inputNum % i == 0)
                    {
                        isPrime = false; //if reminder is 0 for other divisors, the number is not prime, so setting isPrime to false
                        break;
                    }
                }

                if (isPrime) Console.WriteLine(inputNum + " is a prime number");
                else Console.WriteLine(inputNum + " is not a prime number");
            }


            Console.Read();
        }
    }
}
