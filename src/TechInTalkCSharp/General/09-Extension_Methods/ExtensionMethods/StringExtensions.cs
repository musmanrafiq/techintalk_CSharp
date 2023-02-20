using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethods
{
    public static class StringExtensions
    {
        public static string SayHello(this string myString)
        {
            return $"Hello {myString}";
        }
    }
}
