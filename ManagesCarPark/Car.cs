using System;

namespace ManagesCarPark
{
    public class Car
    {
        public string carModel;
        public string typeCar;
        public string automobileColor;
        public string automobileYear;
        public string vin;
        public Engine engine;
        public Transmission transmission;
        public Chassis chassis;

        public Car()
        { }

        public Car(string carModel, string typeCar, string automobileColor, string automobileYear,
                        Engine engine, Transmission transmission, Chassis chassis)
        {
            this.carModel = carModel;
            this.typeCar = typeCar;
            this.automobileColor = automobileColor;
            this.automobileYear = automobileYear;
            this.engine = engine;
            this.transmission = transmission;
            this.chassis = chassis;
        }

        public virtual void Print()
        {
            Console.WriteLine("Automobile model - " + carModel);
            Console.WriteLine("Car type - " + typeCar);
            Console.WriteLine("Color - " + automobileColor);
            Console.WriteLine("Automobile Year - " + automobileYear);
            Console.WriteLine("Engine power - " + engine.power + " HP");
            Console.WriteLine("Engine capacity - " + engine.capacity + " l");
            Console.WriteLine("Engine serial number - " + engine.serialNumber);
            Console.WriteLine("Type transmission - " + transmission.typeTransmission);
            Console.WriteLine("Manufacturer of transmission - " + transmission.manufacturer);
            Console.WriteLine("Number of gears - " + transmission.numberOfGears);
            Console.WriteLine("Wheels number - " + chassis.wheelsNumber);
            Console.WriteLine("Number Chassis - " + chassis.numberChassis);
            Console.WriteLine("Permissible load - " + chassis.permissibleLoad + " t");
            Console.WriteLine();
        }
    }
}