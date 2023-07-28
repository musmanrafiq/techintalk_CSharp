using CsvHelper.Configuration;

namespace ConsoleApp.CsvHelper
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string pathToCsvFile = @"TestFiles\users.csv";
            var csvWrapper = new CsvWrapper();
            var list = csvWrapper.ReadWithMap<Foo, FooMap>(pathToCsvFile);
            foreach (var item in list)
            {
                Console.WriteLine(item.Username);
            }
        }

        public class Foo
        {
            public string Username { get; set; }
            public int Identifier { get; set; }
        }

        public sealed class FooMap : ClassMap<Foo> {
            public FooMap() {
                Map(m => m.Username);
                Map(m => m.Identifier).Name("Identifier User");
            }
        }

    }
}