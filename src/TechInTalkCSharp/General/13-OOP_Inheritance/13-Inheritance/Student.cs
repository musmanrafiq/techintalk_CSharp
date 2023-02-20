namespace _13_Inheritance
{
    public class Student : Person
    {
        public int Age { get; set; }
        public string Section { get; set; }

        public void Introduce()
        {
            Console.WriteLine($"Hi, this is {Name} and my age is {Age}");
        }
    }
}
