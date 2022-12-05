using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartialMethods
{
    public partial class Car
    {
        public Car()
        {
            this.Id = 1;
            this.BrandName = "Honda";
        }
        public partial void GetDetails()
        {
            Console.WriteLine($"The car id is {Id} and its brand is {BrandName}");
        }
    }
}
