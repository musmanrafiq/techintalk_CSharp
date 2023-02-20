namespace Pollymorphism.Entities
{
    public class Animal
    {
        public string Color { get; set; } = string.Empty;

        public virtual void MakeSound()
        {
            Console.WriteLine("This is animal class sound");
        }
    }
}
