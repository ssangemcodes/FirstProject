using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Training.DataAccess;

namespace DatabaseCalls
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first name to be searched:");
            var firstNameForSearch = Console.ReadLine();
            var advWorksDA = new AdventureWorksDataAccess();
            var students = advWorksDA.GetStudentByFirstName(firstNameForSearch);

            foreach (var item in students)
            {
                Console.WriteLine(item.FirstName + " " + item.LastName + " " + item.StudentId);

            }

            Console.ReadLine();
        }
    }
}
