using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace FileIO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Sap\"tha");
            //Console.WriteLine(@"C:\Projects\Training\FileIO");
            //Console.WriteLine("C:\\Projects\\Training\\FileIO");
            StreamWriter writer = null;
            try
            {
                #region readingfromfile

                //StreamReader reader = new StreamReader(@"C:\Projects\Training\FileIO" + @"\Input.txt"); // backslash is an escape charater
                //do
                //{
                //    var stringFromFile = reader.ReadLine(); //I am reading the file one line at a time... first I will read the first line no matter what... then I will check if more lines exist
                //    //Console.WriteLine(stringFromFile);
                //}
                //while (reader.Peek() != -1); //this is where we are checking if there is more lines to read

                #endregion

                #region writingToAfile

                //writer = new StreamWriter(@"C:\Projects\Training\FileIO" + @"\Output.txt");
                //Console.WriteLine("Please enter a string");
                //var stringFromUser = Console.ReadLine();

                //writer.WriteLine(stringFromUser);
                #endregion

                StreamReader reader = new StreamReader(@"C:\Projects\Training\FileIO" + @"\Input.txt"); // backslash is an escape charater
                writer = new StreamWriter(@"C:\Projects\Training\FileIO" + @"\Output.txt");
                do
                {
                    var stringFromFile = reader.ReadLine(); //I am reading the file one line at a time... first I will read the first line no matter what... then I will check if more lines exist
                    writer.WriteLine(stringFromFile);
                }
                while (reader.Peek() != -1); //this is where we are checking if there is more lines to read


            }
            catch (FileNotFoundException fex)
            {
                Console.WriteLine(fex.Message);
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                writer.Close();
            }

            Console.ReadLine();
        }
    }
}
