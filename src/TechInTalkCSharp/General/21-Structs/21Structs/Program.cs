namespace _21Structs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Difference between struc and a class
            // -1 Struct cannot have emptry constructor
            // 2 - Struct cannot be inherited from a class or another struct
            // 3- It can implement interfaces
            // 4- Can initialize with and without new keyword
            // 5- Struct can have emptry static constructor

            // Lets create Point reference
            Point point = new Point();
            Point point2;
            point2.x = 20;
            point2.y = 30;

            Console.WriteLine(point2.x);
        }
    }


    public interface Shape
    {

    }
    public struct Point : Shape
    {
        public int x = 0;
        public int y = 0;

        public Point()
        {
        }
    }
}