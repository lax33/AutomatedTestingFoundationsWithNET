using System;
using System.Xml.Serialization;

namespace ManagesCarPark
{
    //[XmlInclude(typeof(Bus))]
    public class Car
    {
        public string automobileModel;
        public string carType;
        public string automobileColor;
        public string automobileYear;
        public string vin;
        public Engine engine;
        public Transmission transmission;
        public Chassis chassis;

        public Car(){}
        public Car(string automobileModel, string carType, string automobileColor, string automobileYear,
                        Engine engine, Transmission transmission, Chassis chassis)
        {
            this.automobileModel = automobileModel;
            this.carType = carType;
            this.automobileColor = automobileColor;
            this.automobileYear = automobileYear;
            this.engine = engine;
            this.transmission = transmission;
            this.chassis = chassis;
        }
        public virtual void Print()
        {
            Console.WriteLine("Automobile model - " + automobileModel);
            Console.WriteLine("Car type - " + carType);
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
