using System;
using System.Collections.Generic;
using System.Text;

namespace ManagesCarPark
{
    public class PrintCar
    {
        public readonly string automobileModel;

        public PrintCar(string automobileModel)
        {
            this.automobileModel = automobileModel;
        }
        public void PrintC()
        {
            Console.WriteLine(automobileModel);
        }
    }
}
