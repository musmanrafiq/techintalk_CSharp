namespace Methods_introduction
{
    // Topic: method an introduction
    // Elements of a method
        // - access specifier
        // - return type
        // - name
        // - parameters
        // - body

    internal class Program
    {
        static void Main(string[] args)
        {
            SayHelow("Usman");
        }

        static void SayHelow(string userName)
        {
            Console.WriteLine($"Hi, {userName}");
        }
    }
}