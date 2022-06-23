using System;

namespace ObjectOrientedDesignPrinciples
{
    public class AveragePriceTypes : ICommand
    {

        private readonly TypeAvPriceAmount feature = new();

        public void ExecuteCom(Cars cars)
        {
            feature.Execute(cars);
        }

        public void Print()
        {
            foreach (var typeC in feature.typeCar_amountCarType_averigePrice)
            {
                Console.WriteLine($"The average cost of '{typeC.Type}' - {typeC.AverigePrice}");
            }
        }
    }
}