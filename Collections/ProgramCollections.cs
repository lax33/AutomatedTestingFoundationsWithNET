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
            List<Car> collectionCars = new List<Car>()
            {
                    new Bus(CarModel.nissan, TypeCar.bus, "blue", "2011", "30",
                        new Engine(300, 3.5, TypeEnine.diesel, 4562121831),
                        new Transmission(TypeTransmission.automaticTransmission, 5, "Nissan"),
                        new Chassis(6, "656412", 15)),
                    new Bus(CarModel.mazda, TypeCar.bus, "Yellow", "2006", "35",
                        new Engine(220, 2.5, TypeEnine.diesel, 52348736915),
                        new Transmission(TypeTransmission.roboticTransmission, 6, Manufacturer.nissan),
                        new Chassis(6, "8215479325", 10)),
                    new PassengerCar(CarModel.ford, TypeCar.passengerCar, BodyTypePassCar.jeep, "White", "2006",
                        new Engine(160, 2.0, TypeEnine.gas, 798852123),
                        new Transmission(TypeTransmission.manualTransmission,6, "Renault"),
                        new Chassis(4, "985456", 2.5)),
                    new TruckCar(CarModel.renault, TypeCar.truck, TypeTruck.wagon, "blue", "2012",
                        new Engine(300, 3.0, TypeEnine.diesel, 89235487),
                        new Transmission(TypeTransmission.manualTransmission, 4, Manufacturer.nissan),
                        new Chassis(6, "8521347", 25)),
                    new Scooter(CarModel.minsk, TypeCar.scuter, "Brown", "2020",
                        new Engine(15, 0.4, TypeEnine.gas, 45716334),
                        new Transmission(TypeTransmission.variableTransmission, 0, Manufacturer.renault),
                        new Chassis(2, "545486156", 0.15)),
                    new Scooter(CarModel.renault, TypeCar.scuter, "Green", "2020",
                        new Engine(25, 0.6, TypeEnine.gas, 45716334),
                        new Transmission(TypeTransmission.variableTransmission, 0, Manufacturer.renault),
                        new Chassis(2, "545486156", 0.18))
            };

            File.Delete("CapacityMore15.xml");
            File.Delete("EngineBusAndTruc.xml");
            File.Delete("Transmition.xml");

            // car with engine capacity greater than 1.5 liters
            using (FileStream fileCapacityMore15 = new FileStream("CapacityMore15.xml", FileMode.OpenOrCreate))
            {
                var capacityMore15 = from car in collectionCars
                                     where car.engine.capacity > 1.5
                                     select car;
                foreach (var car in capacityMore15)
                {
                    XmlSerializer serializer = new XmlSerializer(car.GetType());
                    serializer.Serialize(fileCapacityMore15, car);
                }
            };

            // engines of bus and truck
            using (FileStream fileEngineBusAndTruc = new FileStream("EngineBusAndTruc.xml", FileMode.OpenOrCreate))
            {
                var engineBusAndTruck = from car in collectionCars
                                        where car.GetType() == typeof(Bus) || car.GetType() == typeof(TruckCar)
                                        select car.engine;
                foreach (var car in engineBusAndTruck)
                {
                    XmlSerializer serializer = new XmlSerializer(typeof(Engine));
                    serializer.Serialize(fileEngineBusAndTruc, car);
                }
            }

            // sorting by transmission type
            using (FileStream fileTransmition = new FileStream("Transmition.xml", FileMode.OpenOrCreate))
            {
                var transmitionAuto = from car in collectionCars
                                      where car.transmission.typeTransmission == TypeTransmission.automaticTransmission
                                      select car;
                foreach (var car in transmitionAuto)
                {
                    XmlSerializer serializer = new XmlSerializer(car.GetType());
                    serializer.Serialize(fileTransmition, car);
                }

                var transmitionManual = from car in collectionCars
                                        where car.transmission.typeTransmission == TypeTransmission.manualTransmission
                                        select car;
                foreach (var car in transmitionManual)
                {
                    XmlSerializer serializer = new XmlSerializer(car.GetType());
                    serializer.Serialize(fileTransmition, car);
                }

                var transmitionRobotic = from car in collectionCars
                                         where car.transmission.typeTransmission == TypeTransmission.roboticTransmission
                                         select car;
                foreach (var car in transmitionRobotic)
                {
                    XmlSerializer serializer = new XmlSerializer(car.GetType());
                    serializer.Serialize(fileTransmition, car);
                }

                var transmitionVariable = from car in collectionCars
                                          where car.transmission.typeTransmission == TypeTransmission.variableTransmission
                                          select car;
                foreach (var car in transmitionVariable)
                {
                    XmlSerializer serializer = new XmlSerializer(car.GetType());
                    serializer.Serialize(fileTransmition, car);
                }
            };
        }
    }
}