using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_Inheritance
{
    public class Teacher : Person
    {
        public double Salary { get; set; }

        public void Introduce()
        {
            Console.WriteLine($"Hi, this is {Name} and my salary is {Salary}");
        }
    }
}
