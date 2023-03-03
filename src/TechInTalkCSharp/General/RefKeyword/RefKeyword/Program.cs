namespace RefKeyword
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            int salary = 1000;
            Person person = new Person();
            person.Salary = 2000;

            Console.WriteLine($"The salary of the person is {person.Salary}");

            ApplyTax(person);
            salary = ApplyTax(salary);

            Console.WriteLine($"The salary of the person is {person.Salary}");


        }

        public static int ApplyTax(int salary)
        {
            salary = salary - (100);
            Console.WriteLine(salary);
            return salary;
        }
        public static void ApplyTax( Person person)
        {
            person.Salary = person.Salary - (100);
            Console.WriteLine(person.Salary);
        }
    }

    // structs are value types in nature
    public class Person
    {
        public string Name { get; set; }
        public int Salary { get; set; }
    }
}