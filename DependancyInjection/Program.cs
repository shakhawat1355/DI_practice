

using DependancyInjectionPrac;

Wheels newWheel = new Wheels();

fourWheels newFourWheel = new fourWheels();


Car c = new Car(newWheel);

Car z = new Car(newFourWheel);


/*c.Printer();
*/
z.Printer();