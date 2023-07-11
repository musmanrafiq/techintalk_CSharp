using Microsoft.Data.SqlClient;
using System.Data;

namespace Dapper.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insert and return data using dapper!");

            string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=F:\\Development\\DotNet\\Techintalk-Csharp\\src\\TechInTalkCSharp\\DatabaseAccess\\DapperORM\\Dapper.ConsoleApp\\DapperConsoleApp.mdf;Integrated Security=True";

            using IDbConnection connection = new 
                SqlConnection(connectionString);

            string sql = @"INSERT INTO dbo.[Users](Name)
                            OUTPUT INSERTED.*
                            VALUES(@Name);"; 

            User user = connection.QuerySingle<User>(sql, new { Name = "TechInTalk" });

            Console.WriteLine(user.Id + " and "+user.Name);
        }
    }

    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}