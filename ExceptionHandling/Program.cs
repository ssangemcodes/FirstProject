using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var handler = new ExceptionHandling();
                handler.Demo();
            }
            catch (Exception)
            {
                Console.WriteLine("Exception happened in the code. Handled in the Main method.");
            }
            Console.ReadLine();
        }
    }

    public class ExceptionHandling
    {
        public void Demo()
        {
            //try, catch, Finally
            //can we have multiple catch blocks. Yes.
            try
            {
                Console.WriteLine("enter a number");

                var num1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("enter a divisor");

                var divisor = Convert.ToInt32(Console.ReadLine());

                var quotient = num1 / divisor;

                Console.WriteLine(quotient);

                //We have made a connection to the file and some exception happened. We need clean up the connection. We need to destroy the connection.

            }
            catch (FileNotFoundException fnnex)
            {
                Console.WriteLine(fnnex.Message);
            }
            catch (SqlException sqlex)
            {
                Console.WriteLine(sqlex.Message);
            }
            catch (DivideByZeroException ex) //super class of all .Net exceptions is Exception. Specific exceptions are FileNotFoundException, DivideByZeroException, SqlExecption, IndexOutofRangeException
            {
                Console.WriteLine("DivideByZeroException happened in the code"); //writing to console for our information, in real world we write it to error logs
                Console.WriteLine(ex.Message + " " + ex.InnerException);
                Console.WriteLine(ex.GetType());
                throw ex; //throw keyword throws exception to the calling method
            }
            catch (Exception ex) //Generic exception handler, catch all
            {
                Console.WriteLine("Generic Exception happened in the code"); //writing to console for our information, in real world we write it to error logs
                Console.WriteLine(ex.Message + " " + ex.InnerException);
                Console.WriteLine(ex.GetType());
            }
            finally
            {
                Console.WriteLine("You are in finally block. This is used in general to release any resources");
                Console.WriteLine("This will be executed even if there is no exception.");

                //even when there is no exception finally block is executed. Because even in the case of no exception you have to close connections, release file locks etc.
                //in general you have to release resources
            }

            Console.ReadLine();
        }
    }
}
