﻿using MyConsoleLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class FullTimeEmployee : Customer
    {
        public void GetAge()
        {
            this.age += 1;
        }
    }
}
