using ManagesCarPark;
using System.Collections;

namespace Collections
{
    internal class ProgramCollections
    {
        static void Main(string[] args)
        {
            ArrayList collection = new ArrayList()
            {

                    new Bus("Nissan", TypeCar.bus, "blue", "2011", "30",
                        new Engine(300, 3.5, TypeEnine.diesel, 4562121831),
                        new Transmission(TypeTransmission.automaticTransmission, 5, "Nissan"),
                        new Chassis(6, "656412", 15)),
                    new PassengerCar("Ford", TypeCar.passengerCar, BodyTypePassCar.jeep, "rad", "2006",
                        new Engine(160, 2.0, TypeEnine.gas, 798852123),
                        new Transmission(TypeTransmission.manualTransmission,6, "Renault"),
                        new Chassis(4, "985456", 2.5)),
                    new Truck("Renault", TypeCar.truck, TypeTruck.wagon, "blue", "2012",
                        new Engine(300, 3.0, TypeEnine.diesel, 89235487),
                        new Transmission(TypeTransmission.manualTransmission, 4, Manufacturer.nissan),
                        new Chassis(6, "8521347", 25)),
                    new Scooter("Renault", TypeCar.scuter, "Green", "2020",
                        new Engine(15, 0.4, TypeEnine.gas, 45716334),
                        new Transmission(TypeTransmission.variableTransmission, 0, Manufacturer.renault),
                        new Chassis(2, "545486156", 0.15))
            };
        }
    }
}
