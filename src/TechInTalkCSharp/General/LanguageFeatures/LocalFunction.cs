namespace LanguageFeatures
{
    public class LocalFunction
    {
        public void Example()
        {
            var list1 = new List<string>()
            {
                "Emp1", "Emp2", "Emp3"
            };
            var list2 = new List<string>()
            {
                "Emp4", "Emp5", "Emp6"
            };

            PrintList(list1);
            PrintList(list2);

            static void PrintList(List<string> list)
            {
                //list2.Add("Invalid addition");
                foreach (var item in list)
                {
                    var newItem = item.Replace("Emp", string.Empty);
                    Console.WriteLine(newItem);
                }
            }
        }
    }
}
