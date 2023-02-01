using System.Data.SqlClient;

namespace _17ConnectToSqlServer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // setting connection string to access sql server database
            string connectionString = "Data Source=localhost;Database=ConnectToSql; Integrated Security=SSPI;";
            // creation connection object
            using SqlConnection connection = new SqlConnection(connectionString);
            // creating command object to fetch users from users table
            SqlCommand sqlCommand = new SqlCommand("select * from Users", connection);
            
            connection.Open();
            // preparing reader to loop through the table
            using (SqlDataReader reader = sqlCommand.ExecuteReader())
            {
                // getting each row one by one
                while (reader.Read())
                {
                    // we are printing the user name here
                    Console.WriteLine(reader.GetString(1));
                }
            }
            // insert operation
            string id = "1";
            string name = "usman";
            string inserUserQuery = "INSERT INTO Users VALUES("+ id+ ",'" + name+"')";
            SqlCommand insertCommad = new SqlCommand(inserUserQuery, connection);
            int recordsAdded = insertCommad.ExecuteNonQuery();
            Console.WriteLine($"{recordsAdded} no of records added");
            /*
             * string inserUserQuery = "INSERT INTO Users (Id,Name) VALUES(@Id,@Name)";
            SqlCommand insertCommad = new SqlCommand(inserUserQuery, connection);
            insertCommad.Parameters.AddWithValue("@Id", 3);
            insertCommad.Parameters.AddWithValue("@Name", "Hamza");
            int recordsAdded = insertCommad.ExecuteNonQuery();
            Console.WriteLine($"{recordsAdded} no of records added");
             * 
            // update operation
            string updateQuery = "UPDATE Users SET Name=@Name WHERE Id=@Id";
            SqlCommand updateCommand = new SqlCommand(updateQuery, connection);
            updateCommand.Parameters.AddWithValue("@Name", "Bilal");
            updateCommand.Parameters.AddWithValue("@Id", "3");
            int recordsUpdated = updateCommand.ExecuteNonQuery();
            Console.WriteLine($"{recordsUpdated} no of records updated");

            // delete operation
            string deleteQuery = "DELETE from Users WHERE Id=@Id";
            SqlCommand deleteCommand = new SqlCommand(deleteQuery, connection);
            deleteCommand.Parameters.AddWithValue("@Id", "3");
            int recordsDeleted = deleteCommand.ExecuteNonQuery();
            Console.WriteLine($"{recordsUpdated} no of records deleted");
            */
            Console.WriteLine("Program ends here.");
        }
    }
}