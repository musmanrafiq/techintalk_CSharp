namespace ConsoleApp.BestPracticesAndTips
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DictionaryUtil dictionaryUtil= new DictionaryUtil();
            dictionaryUtil.KeyExistsWithIgnoreCase();
            dictionaryUtil.FindAndGet();
        }
    }
}