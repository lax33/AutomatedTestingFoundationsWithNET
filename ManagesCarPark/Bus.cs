﻿using System;

namespace ManagesCarPark
{
    class Bus : Car
    {
        private readonly string numberOfSeats;

        public Bus(string automobileModel,
            string carType,
            string automobileColor,
            string automobileYear,
            string numberOfSeats,
            Engine engine,
            Transmission transmission,
            Chassis chassis) : base(automobileModel, carType,
                                            automobileColor, automobileYear,
                                            engine, transmission, chassis)
        {
            this.numberOfSeats = numberOfSeats;
        }

        public override void Print()
        {
            Console.WriteLine("Automobile model - " + automobileModel);
            Console.WriteLine("Car type - " + carType);
            Console.WriteLine("Color - " + automobileColor);
            Console.WriteLine("Automobile Year - " + automobileYear);
            Console.WriteLine("Number of seats - " + numberOfSeats);
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
