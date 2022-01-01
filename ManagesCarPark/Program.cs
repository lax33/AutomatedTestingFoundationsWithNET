using System;

namespace ManagesCarPark
{
    class Program
    {
        static void Main(string[] args)
        {
            PassengerCar passengerCar = new PassengerCar("ford", "red",
                1969, 90, 1458789, "B", 2.0);

            Console.WriteLine(passengerCar.automobileModel, passengerCar.automobileColor,
                passengerCar.automobileYear, passengerCar.engine.power,
                passengerCar.engine.serialNumber, passengerCar.engine.type,
                passengerCar.engine.capacity);
        }
    }
}
