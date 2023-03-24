using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependancyInjectionPrac
{
    public class fourWheels : IWheels
    {
        public void printer2()
        {
            Console.WriteLine("This is from four Wheel Class");
        }
    }
}
