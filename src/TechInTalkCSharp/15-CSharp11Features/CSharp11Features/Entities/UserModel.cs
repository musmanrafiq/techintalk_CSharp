using System.Diagnostics.CodeAnalysis;

namespace CSharp11Features.Entities
{
    public class UserModel
    {
        public int Id { get; set; }
        public required string Name { get; set; }

        [SetsRequiredMembers]
        public UserModel()
        {
            Name = "Zaan";
        }

        public void Introduce()
        {
            string temp = $"User id is {Id} and name is {Name
                .ToString()}";
            Console.WriteLine(temp);
        }
    }

    public class MyCustomAttribute<T> : Attribute
    {
        public T Value { get; set; }
    }
}
