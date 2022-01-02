namespace ManagesCarPark
{

    class PassengerCar : PrintCar
    {
        public readonly string automobileModel;
        public readonly string automobileColor;
        public readonly int automobileYear;
        //public readonly string typeTransmission;
        public readonly Engine engine;
        public readonly Transmission transmission;


        public PassengerCar(string automobileModel,
            string automobileColor,
            int automobileYear,
            Engine engine,
            Transmission transmission) : base( automobileModel)

        {
            this.automobileModel = automobileModel;
            this.automobileColor = automobileColor;
            this.automobileYear = automobileYear;
            this.transmission = transmission;
            this.engine = engine;

        }


    }
}
