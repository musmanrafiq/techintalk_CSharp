namespace MethodOverloading
{
    // what is method overloading
    // why is  that useful
    // how we will implement it
    internal class Program
    {
        static void Main(string[] args)
        {
            FileSystem fs = new FileSystem();
            //fs.Create()
        }
    }

    public class FileSystem
    {
        public void Create()
        {

        }
        public void Create(string fileName)
        {

        }
        public string Create(int fileName)
        {
            return string.Empty;
        }
        public void Create(string fileName, string directory)
        {

        }
        public string Create(string fileName, int priority)
        {
            return string.Empty;
        }
        public string Create(string fileName, int priority, string permissions)
        {
            return string.Empty;
        }
    }
}