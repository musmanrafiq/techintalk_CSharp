namespace ParamsKeyword
{
    internal class Program
    {
        // the params keyword will only be used with array
        // params type of argument should be last in the list or argument
        // We cannot pass default value

        static void Main(string[] args)
        {
            Person p = new Person();
            p.Bio(1,2,3,4,5,6,7,8);
        }

        public class Person
        {
            public void Bio(params int[] information)
            {
                Console.WriteLine(information[0] + " " + information[1]);
            }
        }
    }
}