using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyConsoleLibrary
{
    internal class FullTimeEmployee
    {
        private Customer Customer;

        public FullTimeEmployee()
        {
            Customer = new Customer();
        }
        public void GetAge()
        {
            Customer.age += 1;
        }
    }
}
