using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tempConsole
{
    public class Car
    {

        public Car(Wheels w) {

            w.WheelPrinter();
        }
        public void CarPrinter()
        {
            Console.WriteLine("This is from Car Class");
        }
    }
}
