using CsvHelper;
using System.Globalization;

namespace ConsoleApp.CsvHelper
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string pathToCsvFile = @"TestFiles\users.csv";
            using var reader = new StreamReader(pathToCsvFile);
            using var csv = new CsvReader(reader, CultureInfo.InvariantCulture);
            var list = csv.GetRecords<UserModel>();

            foreach (var item in list)
            {
                Console.WriteLine($"Hi {item.Username} , your identifier is {item.Identifier}");
            }

        }

        public class UserModel
        {
            public string Username { get; set; }
            public int Identifier { get; set; }
        }

    }
}