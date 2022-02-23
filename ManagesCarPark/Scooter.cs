using System;

namespace ManagesCarPark
{
    [Serializable]
    public class Scooter : Car
    {
        public Scooter()
        { }

        public Scooter(string carModel,
            string typeCar,
            string automobileColor,
            string automobileYear,
            Engine engine,
            Transmission transmission,
            Chassis chassis) : base(carModel, typeCar, automobileColor, automobileYear,
            engine, transmission, chassis)
        {
        }
    }
}