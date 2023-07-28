using System.Reflection.Metadata;

namespace ConsoleApp.BestPracticesAndTips
{
    public class DictionaryUtil
    {
        public void KeyExistsWithIgnoreCase()
        {
            var dictionary = new Dictionary<string, int>(StringComparer.CurrentCultureIgnoreCase)
            {
                { "foo", 1 },
                { "bar", 2 }
            };

            var exists = dictionary.ContainsKey("FOO"); 
            Console.WriteLine(exists);
        }

        public void FindAndGet()
        {
            var dictionary = new Dictionary<string, int>(StringComparer.CurrentCultureIgnoreCase)
            {
                { "foo", 1 },
                { "bar", 2 }
            };

            if (dictionary.ContainsKey("Foo"))
            {
                var val = dictionary["Foo"];

            }
            if (dictionary.TryGetValue("fOo", out var value))
            {
                Console.WriteLine(value);
            }
        }
    }
}
