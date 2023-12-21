using System.Text.Json;

namespace ConsoleApp.InterfaceHierarchies
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Drived impement object
            IDerived value = new DerivedImplement { Base = 0, Derived = 1 };
            // serializing the object
            var serializedObject = JsonSerializer.Serialize(value);
            // output on the console
            Console.WriteLine(serializedObject);
        }
    }

    public interface IBase
    {
        public int Base { get; set; }
    }

    public interface IDerived : IBase
    {
        public int Derived { get; set; }
    }

    public class DerivedImplement : IDerived
    {
        public int Base { get; set; }
        public int Derived { get; set; }
    }
}