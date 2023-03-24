using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependancyInjectionPrac
{
    public class Wheels : IWheels
    {
        public void printer2()
        {
            Console.WriteLine("This is from Wheel Class");
        }
    }
}
