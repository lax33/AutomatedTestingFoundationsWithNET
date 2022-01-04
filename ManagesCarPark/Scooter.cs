namespace ManagesCarPark
{
    class Scooter : Car
    {
        public Scooter(string automobileModel,
            string carType,
            string automobileColor,
            string automobileYear,
            Engine engine,
            Transmission transmission,
            Chassis chassis) : base(automobileModel, carType, automobileColor, automobileYear,
            engine, transmission, chassis)
        {
        }
    }
}
