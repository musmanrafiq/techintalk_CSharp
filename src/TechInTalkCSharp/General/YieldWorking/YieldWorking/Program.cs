using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace YieldWorking
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] ints = { 1, 2, 3,4,5,6,7,8,9,10, 11,12,13,14 };

            var eventNumbers = GetEvenNumbers(ints);

            foreach(int i in eventNumbers)
            {
                Console.WriteLine(i);
            }
        }

        private static IEnumerable<int> GetEvenNumbers(int[] ints)
        {
            foreach (int i in ints)
            {
                if(i == 10)
                {
                    yield break;
                }
                if (i % 2 == 0) {

                    yield return i;
                }
            }
        }
    }
}