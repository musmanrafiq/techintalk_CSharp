using System;
using System.Diagnostics.CodeAnalysis;

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
        public Program()
        {

        }
        static void Main(string[] args)
        {
            foreach(var tempValue in Enum.GetValues(typeof(WeekDays)))
            {
                Console.WriteLine($"Today is {(int)tempValue}");
            }
            
        }
    }
}