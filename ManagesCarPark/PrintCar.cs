using System;
using System.Collections.Generic;
using System.Text;

namespace ManagesCarPark
{
    public class PrintCar
    {
        public readonly string automobileModel;
        public readonly string automobileColor;
        public readonly string automobileYear;
        public readonly string vin;
        public readonly Engine engine;
        public readonly Transmission transmission;

        public PrintCar(string automobileModel, string automobileColor, string automobileYear,
                        string vin, Engine engine, Transmission transmission)
        {
            this.automobileModel = automobileModel;
            this.automobileColor = automobileColor;
            this.automobileYear = automobileYear;
            this.vin = vin;
            this.engine = engine;
            this.transmission = transmission;
        }
        public void PrintC()
        {
            Console.WriteLine("Automobile model - " + automobileModel);
            Console.WriteLine("Color - " + automobileColor);
            Console.WriteLine("VIN - " + vin);
            Console.WriteLine("Engine power - " + engine.power);
            Console.WriteLine("Engine capacity - " + engine.capacity + "cm^3");
            Console.WriteLine("Engine serial number - " + engine.serialNumber);
            Console.WriteLine("Type transmission - " + transmission.typeTransmission);
            Console.WriteLine("Manufacturer - " + transmission.manufacturer);
            Console.WriteLine("Number of gears - " + transmission.numberOfGears);
            Console.WriteLine();
        }
    }
}
