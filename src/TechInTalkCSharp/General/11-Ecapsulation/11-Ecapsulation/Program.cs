namespace _11_Ecapsulation
{
    // OOP ( aka object oriented programming ) has four pillers
    // Ecapsulation <--
    // Abstraction
    // Inheritance
    // Pllymorphism


    public class Program
    {

        static void Main(string[] args)
        {
            Animal animal = new Animal();
            Console.WriteLine(animal.NoOfLegs);
        }
    }
}