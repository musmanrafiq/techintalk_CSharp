using MyConsoleLibrary;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer();
            customer.age += 5;
            Console.WriteLine($"Hello, your age is: {customer.age}");
        }
    }
}