using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysCollections
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //var input = Console.ReadLine();//input is one string value
                                           // what if we want to hold number of values... we use an array or a list or a collection
                                           // System.Collections.Generic; is the namespace that provides these functionalities

            //Arrays

            var studentArray = new Student[3]; // we have to initialize the number of elements at the time of declaration
            studentArray[0] = new Student { StudentId = 1, StudentName = "Akhil", StudentSSN ="12345" }; //I can initialize the properties of object like this also
            studentArray[1] = new Student { StudentId = 2, StudentName = "Jay", StudentSSN = "12346" }; //I can initialize the properties of object like this also
            studentArray[2] = new Student { StudentId = 3, StudentName = "Suraj", StudentSSN = "12347" }; //I can initialize the properties of object like this also

            Console.WriteLine("Display elements in student array");
            Console.WriteLine(studentArray.Length);
            foreach (var item in studentArray)
            {
                if (item != null)
                {
                    Console.WriteLine(item);
                }
            }
            Console.WriteLine("----------------------------------------------------------------");
            


            var studentList = new List<Student>(); //we do not have to specify a capacity at the time of declaration
            var student1 = new Student { StudentId = 1, StudentName = "Akhil", StudentSSN = "12345" };
            studentList.Add(student1);
            var student2 = new Student { StudentId = 2, StudentName = "Jay", StudentSSN = "12346" };
            studentList.Add(student2);
            //if(!studentList.Contains(student2)) //! it negates... if the student item is not existing then only add it
                studentList.Add(new Student { StudentId = 12, StudentName = "Jay", StudentSSN = "8887778888" });
            studentList.Add(new Student { StudentId = 3, StudentName = "Suraj", StudentSSN = "12347" });
            studentList.Add(new Student { StudentId = 4, StudentName = "Ram", StudentSSN = "12348" });
            studentList.Add(new Student { StudentId = 5, StudentName = "John", StudentSSN = "12349" });
            studentList.Add(new Student { StudentId = 6, StudentName = "Sam", StudentSSN = "12390" });
            Console.WriteLine("Display elements in student List");

            Console.WriteLine(studentList.Count);
            foreach (var item in studentList)
            {
                if (item != null)
                {
                    Console.WriteLine(item);
                }
            }
            Console.WriteLine("----------------------------------------------------------------");

            //LINQ - Language integrated query... linq to sql using entity framework
            //today we are taking about LINQ to objects

            Console.WriteLine("Which student you want to find");
            var studentNameForQuery = Console.ReadLine(); //studentNameForQuery this type of naming variables is called camel case

            var foundStudent = studentList.Where(x => x.StudentName == studentNameForQuery).ToList(); // "x => x.StudentName == studentNameForQuery" this is an example of lambda expression

            ////var firstStudent = studentList.First(x => x.StudentName == studentNameForQuery);
            //var firstStudent = studentList.Where(x => x.StudentName == studentNameForQuery).First(); //throws an exception when we cannot find the element

            var firstStudent = studentList.FirstOrDefault(x => x.StudentName == studentNameForQuery);
            //var firstStudent = studentList.Where(x => x.StudentName == studentNameForQuery).FirstOrDefault();

            //what LINQ methods have you used - Where, First, FirstOrDefault.. Select, All, Any
            //what is the difference between First and FirstOrDefault


            foreach (var item in foundStudent)
            {
                Console.WriteLine(item);
            }

            if(firstStudent == null)
            {
                Console.WriteLine("we cannot find the student");
            }

            Console.WriteLine(studentList.All(x=> !string.IsNullOrWhiteSpace(x.StudentName)));
            Console.WriteLine(studentList.Any(x=> x.StudentId > 13));

            Console.ReadLine();

        }


    }

    public class Student //Encapsulation - grouping related data together
    {
        public int StudentId { get; set; }
        public string StudentName { get; set; }
        public string StudentSSN { get; set; }

        public override string ToString()
        {
            return string.Format("{0} {1} {2}", StudentId, StudentName, StudentSSN);
        }
    }
}
