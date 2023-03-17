namespace Conversions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string? amount = "1000";
            int convertedValue;
            // by using int.parse
            //int firstConversion = Int32.Parse(amount);

            // by using convert.ToInt32
            //int secondConversion = Convert.ToInt32(amount);

            //Console.WriteLine(secondConversion);

            // by using int.parse
            int firstConversion = Int32.Parse(amount);

            // by using int.TryParse
            bool withTryParse = int.TryParse(amount, out convertedValue);
        }
    }
}