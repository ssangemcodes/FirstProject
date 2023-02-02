using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Configuration;

namespace Training.DataAccess
{
    public class AdventureWorksDataAccess
    {
        public List<Student> GetStudentByFirstName(string firstName)
        {
            var students = new List<Student>();

            //ADO.Net .Net frameworks mechanism for us to call databases
            //Entity framework

            //1) step 1 for any SQL operation u need a connection
            var connString = "data source=CRESTSOFTSANGEM\\SQLEXPRESS;Initial Catalog=AdventureWorks2019;Integrated Security=True;";// ConfigurationManager.ConnectionStrings["AdventureWorks"].ConnectionString;
            using (var conn = new SqlConnection(connString)) //using removes the connection from memory once data operation complete 
            {
                SqlCommand cmd = conn.CreateCommand();//2
                cmd.CommandText = "GetPersonByFirstName";//3
                cmd.CommandType = System.Data.CommandType.StoredProcedure;//4
                
                cmd.Parameters.Add(new SqlParameter("FirstName",firstName));//5 add any parameters

                //cmd.CommandText = "select top 1000 * from Person.Person where FirstName=@FirstName";
                //cmd.CommandType = System.Data.CommandType.Text;

                if (conn.State != System.Data.ConnectionState.Open)
                {
                    conn.Open();//6 if connection is not open then open sql connection
                }
                var reader = cmd.ExecuteReader(); //7
                while (reader.Read()) //8
                {
                    var student = new  Student();
                    student.FirstName = reader["FirstName"].ToString();
                    student.LastName = reader["LastName"].ToString();
                    student.StudentId = Convert.ToInt32(reader["BusinessEntityId"]);
                    students.Add(student);
                }
            }

            return students;
        }

    }
}
