using System;

namespace ManagesCarPark
{
    class Program
    {
        static void Main(string[] args)
        {
            Engine engineFord = new Engine(110, 1.6, TypeEnine.gas, 45625665489);
            Transmission transmissionFord = new Transmission(TypeTransmission.automaticTransmission,
                5, Manufacturer.ford);
            PassengerCar passengerCarFord = new PassengerCar("ford", "red",
                1969, engineFord, transmissionFord);


            passengerCarFord.PrintC();
        }
    }
}
