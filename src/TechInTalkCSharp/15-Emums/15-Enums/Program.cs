using System;

namespace _15_Enums
{
    public enum WeekDays{
        Monday = 2,
        Tuesday = 4,
        Wednesday,
        Thursday,
        Friday
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            //int todaysValue = WeekDays.Monday;

            foreach(var tempValue in Enum.GetValues(typeof(WeekDays)))
            {
                Console.WriteLine($"Today is {(int)tempValue}");
            }
            
        }
    }
}