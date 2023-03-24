using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependancyInjectionPrac
{
    public class Car
    {

        private readonly IWheels _wheels;

        public Car(IWheels wheels)
        {
            _wheels = wheels;
            _wheels.printer2();
        }

        public void Printer()
        {
            Console.WriteLine("This is from Car Class");
        }


    }
}
