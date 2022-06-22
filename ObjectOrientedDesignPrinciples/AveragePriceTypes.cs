using System;
using System.Collections.Generic;

namespace ObjectOrientedDesignPrinciples
{
    public class AveragePriceTypes : ICommand
    {
        //private List<TypeAvPriceAmount> typeCar_amountCarType_averigePrice;

        //private double amountPriceType;

        //public AveragePriceTypes(List<Car> cars)
        //{
        //    this.cars = cars;
        //}
        //private readonly TypeAvPriceAmount feature = new();
        private TypeAvPriceAmount feature;

        public void ExecuteCom(Cars cars)
        {
            feature = TypeAvPriceAmount.Execute(cars);
        }

        public void Print()
        {
            foreach (var typeC in feature)
            {
                Console.WriteLine($"The average cost of '{typeC.Type}' - {typeC.AverigePrice}");
            }
        }
    }
}