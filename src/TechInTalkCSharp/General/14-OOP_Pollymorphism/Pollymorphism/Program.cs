using Pollymorphism.Entities;

namespace Pollymorphism
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Animal animal  = new Animal();
            animal.MakeSound();

            Animal cowObj = new Cow();
            cowObj.MakeSound();

            Animal sheepObj = new Sheep();
            sheepObj.MakeSound();
        }

    }
}