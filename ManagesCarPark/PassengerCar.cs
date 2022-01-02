namespace ManagesCarPark
{

    class PassengerCar : PrintCar
    {
        public readonly string automobileModel;
        public readonly string automobileColor;
        public readonly string automobileYear;
        public readonly string vin;
        public readonly Engine engine;
        public readonly Transmission transmission;


        public PassengerCar(string automobileModel,
            string automobileColor,
            string automobileYear,
            string vin,
            Engine engine,
            Transmission transmission) : base( automobileModel, automobileColor, automobileYear,
                                               vin, engine, transmission )

        {
            this.automobileModel = automobileModel;
            this.automobileColor = automobileColor;
            this.automobileYear = automobileYear;
            this.transmission = transmission;
            this.engine = engine;
        }


    }
}
