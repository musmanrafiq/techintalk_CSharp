﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypesOfMethods
{
    public class Student
    {
        public string Name { get; set; }
        public static string City { get; set; }

        public void MyName()
        {
            Console.WriteLine($"My name is : {Name}");
        }

        public static void MyCity()
        {
            Console.WriteLine($"My city name is : {City}");
        }
    }
}
