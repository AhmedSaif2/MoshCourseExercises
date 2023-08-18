using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoshCourseExercises.Exercises.Intermediate
{
    public abstract class DbConnection
    {
        private string  _connectionString;
        private TimeSpan _timeout;
        public DbConnection(string connectionString)
        {
            if (connectionString == null)
            {
                throw new InvalidOperationException();
            }
            _connectionString = connectionString;
        }
        public abstract void OpenConnection();
        public abstract void CloseConnection();
    }
    public class SqlConnection:DbConnection
    {
        public SqlConnection(string connectionString): base(connectionString)
        {
            
        }
        public override void OpenConnection()
        {
            Console.WriteLine("Sql Connection opened Successfully");
        }

        public override void CloseConnection()
        {
            Console.WriteLine("Sql Connection closed Successfully");
        }

    }
    public class OracleConnection : DbConnection
    {
        public OracleConnection(string connectionString): base(connectionString)
        {

        }
        public override void OpenConnection()
        {
            Console.WriteLine("Oracle Connection opened Successfully");
        }

        public override void CloseConnection()
        {
            Console.WriteLine("Oracle Connection closed Successfully");
        }

    }

}
