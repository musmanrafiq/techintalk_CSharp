namespace ConsoleApp1
{
    internal class Program
    {
        static int age = 30;
        static string fullName = "Usman Rafiq";
        static double salary = 100.5;


        static void Main(string[] args)
        {
            age += 5;
            Console.WriteLine($"Hello, { fullName}, and your age is: {age}, and salary is : {salary}");
        }
    }
}