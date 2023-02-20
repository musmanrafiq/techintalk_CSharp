using CSharp11Features.Entities;

namespace CSharp11Features
{
    // 1- required keyword in properties
    // 2- line breaks in interpulated strings
    // 3- Generic Type Attribute
    
    internal class Program
    {
        static void Main(string[] args)
        {
            UserModel model = new UserModel();
            model.Introduce();
        }
    }
}