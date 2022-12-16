using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSExtended
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var student1 = new Student(); // student1 is one instance of the class, as called an object
            student1.Name = "Suraj";
            student1.AddAddress("Texas");

            var student2 = new Student(); // student2 is another instance of the class, as called an object
            student2.Name = "Akhil";
            student2.AddAddress("Illinois");

            Console.WriteLine(student1.Name);

            Console.WriteLine(Student.StudentCount);

            Console.ReadLine();


            //var absStu = new AbsStudent(); // this will throw an error also
            var absStu = new GradeStudent();
        }
    }

    public struct StructStudent // struct is a lightweight class, Struct is a value type, if you have more than 3-4 properties start using classes
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
    }

    public class Student : IStudent //my class student implements interface IStudent
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Grades { get; set; }
        public static int StudentCount { get; set; } //this is a static class level variable

        public Student()
        {
            StudentCount++;
        }

        public void AddAddress(string address)
        {
            this.Address = address;
        }

        public string GetGrades()
        {
            return this.Grades;
        }
    }

    public abstract class AbsStudent : IStudent //abstract: when you only have part of the implementation of an interface you can declare an abstract class
                                                //derived classes are expected to complete the implementation
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }

        public void AddAddress(string address)
        {
            this.Address = address;
        }

        public abstract string GetGrades();
    }

    public class GradeStudent : AbsStudent
    {
        public string Grades { get; set; }

        public override string GetGrades()
        {
            return Grades;
        }
    }

    public sealed class SealedStudent
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }

    }

    //below code throws error because we cannot derive from a sealed class
    //public class ChildOfSealedStudent : SealedStudent
    //{

    //}
}
