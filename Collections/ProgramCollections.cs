using ManagesCarPark;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Sockets;
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

            File.Delete("CapacityMore15.xml");
            File.Delete("EngineBusAndTruc.xml");
            File.Delete("Transmition.xml");

            //
            using (FileStream fileCapacityMore15 = new FileStream("CapacityMore15.xml", FileMode.OpenOrCreate))
            {
                var capacityMore15 = from car in collection
                                     where car.engine.capacity > 1.5
                                     select car;
                foreach (var car in capacityMore15)
                {
                    XmlSerializer serializer = new XmlSerializer(car.GetType());
                    serializer.Serialize(fileCapacityMore15, car);
                }
            };

            //
            //using (FileStream fileEngineBusAndTruc = new FileStream("EngineBusAndTruc.xml", FileMode.OpenOrCreate))
            //{
            //    var engineBusAndTruck = from car1 in collection
            //                            where car1.GetType() == typeof(Bus) || car1.GetType() == typeof(Truck)
            //                            select new { car1.automobileModel, car1.engine.typeEngin, car1.engine.capacity, car1.engine.serialNumber };
            //    foreach (var car2 in engineBusAndTruck)
            //    {
            //        EngineBusAndTruc helper = new EngineBusAndTruc(car2.automobileModel, car2.typeEngin,
            //            car2.capacity, car2.serialNumber);
            //        XmlSerializer serializer = new XmlSerializer(typeof(EngineBusAndTruc));
            //        serializer.Serialize(fileEngineBusAndTruc, helper);
            //    }
            //}

            using (FileStream fileEngineBusAndTruc = new FileStream("EngineBusAndTruc.xml", FileMode.OpenOrCreate))
            {
                var engineBusAndTruck = from car in collection
                                        where car.GetType() == typeof(Bus) || car.GetType() == typeof(Truck)
                                        select car.engine;
                foreach (var car in engineBusAndTruck)
                {
                    XmlSerializer serializer = new XmlSerializer(typeof(Engine));
                    serializer.Serialize(fileEngineBusAndTruc, car);
                }
            }

            //
            using (FileStream fileTransmition = new FileStream("Transmition.xml", FileMode.OpenOrCreate))
            {
                var transmitionAuto = from car in collection
                                      where car.transmission.typeTransmission == TypeTransmission.automaticTransmission
                                      select car.transmission;
                foreach (var car in transmitionAuto)
                {
                    XmlSerializer serializer = new XmlSerializer(typeof(Transmission));
                    serializer.Serialize(fileTransmition, car);
                }

                var transmitionManual = from car in collection
                                        where car.transmission.typeTransmission == TypeTransmission.manualTransmission
                                        select car.transmission;
                foreach (var car in transmitionManual)
                {
                    XmlSerializer serializer = new XmlSerializer(typeof(Transmission));
                    serializer.Serialize(fileTransmition, car);
                }

                var transmitionRobotic = from car in collection
                                         where car.transmission.typeTransmission == TypeTransmission.roboticTransmission
                                         select car.transmission;
                foreach (var car in transmitionRobotic)
                {
                    XmlSerializer serializer = new XmlSerializer(typeof(Transmission));
                    serializer.Serialize(fileTransmition, car);
                }

                var transmitionVariable = from car in collection
                                          where car.transmission.typeTransmission == TypeTransmission.variableTransmission
                                          select car.transmission;
                foreach (var car in transmitionVariable)
                {
                    XmlSerializer serializer = new XmlSerializer(typeof(Transmission));
                    serializer.Serialize(fileTransmition, car);
                }
            };
        }
    }
}