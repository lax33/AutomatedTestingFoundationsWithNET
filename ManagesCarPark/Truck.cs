using System;

namespace ManagesCarPark
{
    class Truck : Car
    {

        public Truck(string automobileModel,
            string carType,
            string automobileColor,
            string automobileYear,
            string vin,
            Engine engine,
            Transmission transmission,
            Chassis chassis) : base(automobileModel, carType,
                                        automobileColor, automobileYear,
                                        vin, engine, transmission, chassis )
        {
        }

    }
}
