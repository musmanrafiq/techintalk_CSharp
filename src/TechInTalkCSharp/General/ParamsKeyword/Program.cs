namespace ParamsKeyword
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person();
            p.Bio("Usman","Rafiq");
        }

        public class Person
        {
            public void Bio(params string[] information)
            {
                Console.WriteLine(information[0] + " " + information[1]);
            }
        }
    }
}