using System;

namespace ManagesCarPark
{
    public class ProgramCarPark
    {
        static void Main(string[] args)
        {
            // Car Ford
            Engine engineFord = new Engine(110, 1.6, TypeEnine.gas, 45625665489);
            Transmission transmissionFord = new Transmission(TypeTransmission.automaticTransmission,
                5, Manufacturer.ford);
            Chassis chassisFord = new Chassis(4, "85214", 1.5);
            PassengerCar passengerCarFord = new PassengerCar("Ford", TypeCar.passengerCar,
                BodyTypePassCar.sedan, "red", "1969", engineFord, transmissionFord, chassisFord);

            // Truck Renault
            Engine engineTruckRenault = new Engine(300, 3.0, TypeEnine.diesel, 89235487);
            Transmission transmissionRenault = new Transmission(TypeTransmission.manualTransmission,
                4, Manufacturer.nissan);
            Chassis chassisRenault = new Chassis(6, "8521347", 25);
            Truck truckRenault = new Truck("Renault", TypeCar.truck, TypeTruck.wagon, "blue",
                "2012", engineTruckRenault, transmissionRenault, chassisRenault);


            // Bus Nissan
            Engine engineNissan = new Engine(220, 2.5, TypeEnine.diesel, 52348736915);
            Transmission transmissionNissan = new Transmission(TypeTransmission.roboticTransmission,
                6, Manufacturer.nissan);
            Chassis chassisBus = new Chassis(6, "8215479325", 10);
            Bus busNissan = new Bus("Nissan", TypeCar.bus,
                "Yellow", "2006", "30", engineNissan, transmissionNissan, chassisBus);


            // Scuter Renault
            Engine engineScuterRenault = new Engine(15, 0.4, TypeEnine.gas, 45716334);
            Transmission transmissionScuterRenault = new Transmission(TypeTransmission.variableTransmission, 0, Manufacturer.renault);
            Chassis chassisScuter = new Chassis(2, "545486156", 0.15);
            Scooter scooterRenault = new Scooter("Renault", TypeCar.scuter, "Green", "2020",
                                                engineScuterRenault, transmissionScuterRenault, chassisScuter);

            passengerCarFord.Print();
            truckRenault.Print();
            busNissan.Print();
            scooterRenault.Print();

            Console.ReadLine();
        }
    }
}
