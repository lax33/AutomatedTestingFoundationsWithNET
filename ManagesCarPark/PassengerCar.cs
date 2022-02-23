using System;

namespace ManagesCarPark
{
    [Serializable]
    public class PassengerCar : Car
    {
        public string bodyTypePassCar;

        public PassengerCar()
        { }

        public PassengerCar(string carModel,
            string typeCar,
            string bodyTypePassCar,
            string automobileColor,
            string automobileYear,
            Engine engine,
            Transmission transmission,
            Chassis chassis) : base(carModel, typeCar, automobileColor, automobileYear,
                                    engine, transmission, chassis)
        {

            this.bodyTypePassCar = bodyTypePassCar;
        }

        public override void Print()
        {
            Console.WriteLine("Automobile model - " + carModel);
            Console.WriteLine("Car type - " + typeCar);
            Console.WriteLine("Body type - " + bodyTypePassCar);
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