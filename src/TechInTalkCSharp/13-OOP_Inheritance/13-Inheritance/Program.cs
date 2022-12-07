namespace _13_Inheritance
{
    public class Program
    {
        static void Main(string[] args)
        {
            Teacher teacher = new()
            { 
                Salary = 50000,
                Name = "Ali"
            };
           
            teacher.Introduce();

            Student student = new()
            {
                Name = "Umar",
                Age = 22
            };
            
            student.Introduce();
        }
    }
}