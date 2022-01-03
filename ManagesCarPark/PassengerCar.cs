namespace ManagesCarPark
{

    class PassengerCar : Car
    {

        public PassengerCar(string automobileModel,
            string carType,
            string automobileColor,
            string automobileYear,
            string vin,
            Engine engine,
            Transmission transmission,
            Chassis chassis) : base(automobileModel, carType, automobileColor, automobileYear,
                                                vin, engine, transmission, chassis)
        {
        }

    }
}
