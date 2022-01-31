using System;

namespace ManagesCarPark
{
    [Serializable]
    public class Truck : Car
    {
        public string typeTruck;

        public Truck()
        { }

        public Truck(string automobileModel,
            string carType,
            string typeTruck,
            string automobileColor,
            string automobileYear,
            Engine engine,
            Transmission transmission,
            Chassis chassis) : base(automobileModel, carType,
                                    automobileColor, automobileYear,
                                    engine, transmission, chassis)
        {
            this.typeTruck = typeTruck;
        }

        public override void Print()
        {
            Console.WriteLine("Automobile model - " + automobileModel);
            Console.WriteLine("Car type - " + carType);
            Console.WriteLine("Type truck - " + typeTruck);
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