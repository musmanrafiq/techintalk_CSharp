namespace TypesOfMethods
{
    // Instance Methods <--
    // static Methdos <--
    // Extenstion Methods
    // Partial Methods
    // Abstract Methods
    // Virtual Methods

    internal class Program
    {

        static void Main(string[] args)
        {
            // Example of an instance method
            Student student = new Student();
            student.Name = "Salman";
            student.MyName();

            Student student1 = new Student();
            student1.Name = "Usman";
            student1.MyName();
            // end

            // Example of static methods
            Student.City = "Islamabad";
            Student.City = "Karachi";

            Student.MyCity();
            Student.MyCity();
            // end
        }
    }
}