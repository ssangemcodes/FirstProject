using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings
{
    internal class Program
    {

        static void Main(string[] args)
        {
            //var input = Console.ReadLine();
            //Console.WriteLine(input);

            var charExample = 'C';//characted is initialized using single quote
            var studentName = " John Doe"; // string is initialized using double quotes
                                          //doublequoted strings are also string literals
            Console.WriteLine(studentName);
            Console.WriteLine(studentName.Substring(1,2)); ///C# arrays are 0 based

            var string1 = "test string";
            var string2 = "test string";
            var isEqual = string1.Equals(string2);
            //var isEqual = (string1 == string2);

            

            if (isEqual)
            {
                Console.WriteLine("both strings are same");
            }
            else
            {
                Console.WriteLine("not equal");
            }

            Console.WriteLine(studentName.Length);
            Console.WriteLine(studentName.Substring(studentName.Length-2,2));

            var studentNameCharArray = studentName.ToCharArray(); //converting string to character array
            foreach (var item in studentNameCharArray)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("-------------------------------------------------------");

            for (int i = 0; i < studentNameCharArray.Length; i++)
            {
                Console.WriteLine(studentNameCharArray[i]);
            }

            //Console.WriteLine(studentName.Reverse().ToArray());
            Console.WriteLine("--------------------String Reversal-----------------------------------");
            for (int i = studentNameCharArray.Length-1; i >=0; i--)
            {
                Console.Write(studentNameCharArray[i]);
            }

            Console.WriteLine(1);

            Console.WriteLine(studentName.Replace(" ", ""));

            Console.ReadLine();
        }
    }
}
