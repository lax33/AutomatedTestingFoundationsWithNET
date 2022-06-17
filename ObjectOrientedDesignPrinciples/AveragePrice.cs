using System;

namespace ObjectOrientedDesignPrinciples
{
    public class AveragePrice : ICommand
    {
        private int amountPrice;

        public void ExecuteCom(Cars cars)
        {
            foreach (var car in cars.ArrayCars)
            {
                amountPrice += car.Price;
            }

            Console.WriteLine($"The average car's cost - {amountPrice / cars.ArrayCars.Count}");
        }
    }
}