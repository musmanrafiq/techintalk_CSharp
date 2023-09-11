namespace TypesOfMethods
{
    public class Student
    {
        public string Name { get; set; }
        public static string City { get; set; }

        public void MyName()
        {
            Console.WriteLine($"My name is : {Name}");
        }

        public static void MyCity()
        {
            Console.WriteLine($"My city name is : {City}");
        }

        public (string name, string city) GetUserDetails()
        {
            return (this.Name, this.Name);
        }
    }
}
