using System;

namespace ManagesCarPark
{
    class Program
    {
        static void Main(string[] args)
        {
            // Car Ford
            Engine engineFord = new Engine(110, 1.6, EnineType.gas, 45625665489);
            Transmission transmissionFord = new Transmission(TransmissionType.automaticTransmission,
                5, Manufacturer.ford);
            Chassis chassisFord = new Chassis(4, "85214", 1.5);
            PassengerCar passengerCarFord = new PassengerCar("Ford", CarType.passengerCar,
                BodyTypePassCar.sedan, "red", "1969", engineFord, transmissionFord, chassisFord);

            // Truck Renault
            Engine engineTruckRenault = new Engine(300, 3.0, EnineType.diesel, 89235487);
            Transmission transmissionRenault = new Transmission(TransmissionType.manualTransmission,
                4, Manufacturer.nissan);
            Chassis chassisRenault = new Chassis(6, "8521347", 25);
            Truck truckRenault = new Truck("Renault", CarType.truck, TypeTruck.wagon, "blue",
                "2012", engineTruckRenault, transmissionRenault, chassisRenault);


            // Bus Nissan
            Engine engineNissan = new Engine(220, 2.5, EnineType.diesel, 52348736915);
            Transmission transmissionNissan = new Transmission(TransmissionType.roboticTransmission,
                6, Manufacturer.nissan);
            Chassis chassisBus = new Chassis(6, "8215479325", 10);
            Bus busNissan = new Bus("Nissan", CarType.bus,
                "Yellow", "2006", "30", engineNissan, transmissionNissan, chassisBus);


            // Scuter Renault
            Engine engineScuterRenault = new Engine(15, 0.4, EnineType.gas, 45716334);
            Transmission transmissionScuterRenault = new Transmission(TransmissionType.variableTransmission, 0, Manufacturer.renault);
            Chassis chassisScuter = new Chassis(2, "545486156", 0.15);
            Scooter scooterRenault = new Scooter("Renault", CarType.scuter, "Green", "2020",
                                                engineScuterRenault, transmissionScuterRenault, chassisScuter);

            passengerCarFord.Print();
            truckRenault.Print();
            busNissan.Print();
            scooterRenault.Print();

            Console.ReadLine();
        }
    }
}
