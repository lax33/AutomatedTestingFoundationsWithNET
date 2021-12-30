using System;
using System.Collections.Generic;
using System.Text;

namespace ManagesCarPark
{
    
    class PassengerCar
    {
        public readonly string automobileModel;
        public readonly string automobileColor;
        public readonly int automobileYear;
        public readonly Engine engine = new Engine();
       
        public PassengerCar(string automobileModel,
            string automobileColor, 
            int automobileYear,
            int enginePower,
            int engineSerialNumber, 
            string engineType,
            double engineVolume)
        {
            this.automobileModel = automobileModel;
            this.automobileColor = automobileColor;
            this.automobileYear = automobileYear;
            if (engine == null) return;
            engine.power = enginePower;
            engine.serialNumber = engineSerialNumber;
            engine.type = engineType;
            engine.volume = engineVolume;
        }
        

    }
}
