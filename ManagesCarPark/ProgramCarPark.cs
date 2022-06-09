using System;

namespace ManagesCarPark
{
    public class ProgramCarPark
    {
        private static void Main(string[] args)
        {
            // Car Ford
            PassengerCar passengerCarFord = new PassengerCar(CarModel.ford, TypeCar.passengerCar, BodyTypePassCar.sedan, "red", "1969",
                    new Engine(110, 1.6, TypeEnine.gas, 45625665489),
                    new Transmission(TypeTransmission.automaticTransmission, 5, Manufacturer.ford),
                    new Chassis(4, "85214", 1.5));

            // Truck Renault
            TruckCar truckRenault = new TruckCar(CarModel.renault, TypeCar.truck, TypeTruck.wagon, "blue", "2012",
                new Engine(300, 3.0, TypeEnine.diesel, 89235487),
                new Transmission(TypeTransmission.manualTransmission, 4, Manufacturer.nissan),
                new Chassis(6, "8521347", 25));

            // Bus Nissan
            Bus busNissan = new Bus(CarModel.nissan, TypeCar.bus, "Yellow", "2006", "30",
                new Engine(220, 2.5, TypeEnine.diesel, 52348736915),
                new Transmission(TypeTransmission.roboticTransmission, 6, Manufacturer.nissan),
                new Chassis(6, "8215479325", 10));

            // Scuter Renault
            Scooter scooterRenault = new Scooter(CarModel.renault, TypeCar.scuter, "Green", "2020",
                new Engine(15, 0.4, TypeEnine.gas, 45716334),
                new Transmission(TypeTransmission.variableTransmission, 0, Manufacturer.renault),
                new Chassis(2, "545486156", 0.15));

            passengerCarFord.Print();
            truckRenault.Print();
            busNissan.Print();
            scooterRenault.Print();

            Console.ReadLine();
        }
    }
}