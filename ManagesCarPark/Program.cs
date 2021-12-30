using System;

namespace ManagesCarPark
{
    class Program
    {
        static void Main(string[] args)
        {
            PassengerCar passenger = new PassengerCar("ford", "red", 
                1969, 90, 1458789, "B", 2.0);
           
            Console.WriteLine(passenger.automobileModel, passenger.automobileColor,
                passenger.automobileYear, passenger.engine.power,
                passenger.engine.serialNumber, passenger.engine.type,
                passenger.engine.volume);
        }
    }
}
