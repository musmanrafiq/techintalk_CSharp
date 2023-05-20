namespace IQ_Console_Project
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Q1: Swap two values without using third variable
            // A: 
            // Swap();


            string input = "_Hi, I am a programmer! .?";
            var chars =
                new char[] { '_', '?', '.', ' ' };
            input = input.Trim(chars);
            Console.WriteLine(input);
        }

        static void Swap()
        {
            // initializing variables
            int a = 10, b = 20;
            // printing initial values
            Console.WriteLine($"{a} {b}");
            // swap login # 1
            a = a + b;
            b = a - b;
            a = a - b;
            // printing values after first swap
            Console.WriteLine($"{a} {b}");
            // swap logic # 2
            (a, b) = (b, a);
            // printing values after second swap
            Console.WriteLine($"{a} {b}");
        }
    }
}