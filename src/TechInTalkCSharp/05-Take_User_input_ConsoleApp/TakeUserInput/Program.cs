namespace TakeUserInput
{
    // There are two types of input in console application
    // 1- when we start a program
    // 2- while running an application, get input from console
    //    2.1 - Read char from user input
    
    internal class Program
    {
        static void Main(string[] args)
        {
            
            // Console.WriteLine($"Hello, World! {args[2]}");

            Console.WriteLine("Please enter you name"+ m.PI);

            string userInput = Console.ReadLine();

            

            Console.WriteLine($"Welcome to c# tutorial series {userInput}");
            
            ConsoleKeyInfo userInputChar = Console.ReadKey();
            Console.WriteLine(userInputChar.KeyChar);
            
        }
    }
}