using System;

namespace ObjectOrientedDesignPrinciples
{
    public class CountTypes : ICommand
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
                Console.WriteLine($"The count of type - {typeC.Amount}");
            }
        }
    }
}