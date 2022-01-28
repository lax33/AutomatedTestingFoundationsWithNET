using ManagesCarPark;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml.Serialization;

namespace Collections
{
    internal class ProgramCollections
    {
        private static void Main(string[] args)
        {
            List<Car> collection = new List<Car>()
            {
                    new Bus("Nissan", TypeCar.bus, "blue", "2011", "30",
                        new Engine(300, 3.5, TypeEnine.diesel, 4562121831),
                        new Transmission(TypeTransmission.automaticTransmission, 5, "Nissan"),
                        new Chassis(6, "656412", 15)),
                    new PassengerCar("Ford", TypeCar.passengerCar, BodyTypePassCar.jeep, "White", "2006",
                        new Engine(160, 2.0, TypeEnine.gas, 798852123),
                        new Transmission(TypeTransmission.manualTransmission,6, "Renault"),
                        new Chassis(4, "985456", 2.5)),
                    new Truck("Renault", TypeCar.truck, TypeTruck.wagon, "blue", "2012",
                        new Engine(300, 3.0, TypeEnine.diesel, 89235487),
                        new Transmission(TypeTransmission.manualTransmission, 4, Manufacturer.nissan),
                        new Chassis(6, "8521347", 25)),
                    new Scooter("Minsk", TypeCar.scuter, "Green", "2020",
                        new Engine(15, 0.4, TypeEnine.gas, 45716334),
                        new Transmission(TypeTransmission.variableTransmission, 0, Manufacturer.renault),
                        new Chassis(2, "545486156", 0.15))
            };

            Bus bus1 = new Bus("Nissan", TypeCar.bus, "blue", "2011", "30",
                new Engine(300, 3.5, TypeEnine.diesel, 4562121831),
                new Transmission(TypeTransmission.automaticTransmission, 5, "Nissan"),
                new Chassis(6, "656412", 15));

            File.Delete("CapacityMore151.xml");
            File.Delete("CapacityMore15.xml");

            using (FileStream fl1 = new FileStream("CapacityMore151.xml", FileMode.OpenOrCreate))
            {
                using (FileStream fl = new FileStream("CapacityMore15.xml", FileMode.OpenOrCreate))
                {
                    foreach (Car car in collection)
                    {
                        if (car.engine.capacity > 1.5)
                        {
                            //XmlSerializer serializer = new XmlSerializer(car.GetType());
                            //serializer.Serialize(fl, car);
                        }

                    }
                }

                
                var busTruckConcat = from car in collection
                           where car.GetType() == typeof(Bus) || car.GetType() == typeof(Truck)
                           select new { car.automobileModel, car.engine.typeEngin, car.engine.capacity, car.engine.serialNumber };

                foreach (var car in busTruckConcat)
                {
                    XmlSerializer serializer = new XmlSerializer(car.GetType());
                    serializer.Serialize(fl1, car);
                }
                
            }


        }
    }
}