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
            
            Console.WriteLine($"The count of type - {feature.typeCar_amountCarType_averigePrice.Count}");
            
        }
    }
}