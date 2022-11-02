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
            PrimeNumber pnClass = new PrimeNumber(); // here I am creating an object of the class 
                                                     //we organize code(Business Logic) into related classes and methods
                                                     // OOPS concepts Object oriented programming
                                                     //Encapsulation, Inheritance

            pnClass.ShowPrimeNumbers();

        }


    }
}
