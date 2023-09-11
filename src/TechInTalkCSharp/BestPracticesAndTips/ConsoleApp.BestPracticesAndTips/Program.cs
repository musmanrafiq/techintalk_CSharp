using System.Collections;

namespace ConsoleApp.BestPracticesAndTips
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var first = new[] { new User("u1", 1), new User("u2", 2) };
            var second = new[] { new User("u1", 1), new User("u2", 2) };

            Console.WriteLine(AreEqualArrays(first, second));
        }

        public static bool AreEqualArrays(object first, object second)
        {
            IStructuralEquatable? firstArray = first as IStructuralEquatable;
            IStructuralEquatable? secondArray = second as IStructuralEquatable;

            if (firstArray is not null && secondArray is not null)
            {
                return firstArray.Equals(secondArray, EqualityComparer<object>.Default);
            }
            return false;
        }
    }

    public record User(string name, int id);
}