using System;

namespace ManagesCarPark
{
    public class Car
    {
        protected readonly string automobileModel;
        protected readonly string carType;
        protected readonly string automobileColor;
        protected readonly string automobileYear;
        protected readonly string vin;
        protected readonly Engine engine;
        protected readonly Transmission transmission;
        protected readonly Chassis chassis;

        protected Car(string automobileModel, string carType, string automobileColor, string automobileYear,
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
            Console.WriteLine("Engine power - " + engine.power);
            Console.WriteLine("Engine capacity - " + engine.capacity);
            Console.WriteLine("Engine serial number - " + engine.serialNumber);
            Console.WriteLine("Type transmission - " + transmission.typeTransmission);
            Console.WriteLine("Manufacturer of transmission - " + transmission.manufacturer);
            Console.WriteLine("Number of gears - " + transmission.numberOfGears);
            Console.WriteLine("Wheels number - " + chassis.wheelsNumber);
            Console.WriteLine("Number Chassis - " + chassis.numberChassis);
            Console.WriteLine("Permissible load - " + chassis.permissibleLoad);
            Console.WriteLine();
        }
    }
}
