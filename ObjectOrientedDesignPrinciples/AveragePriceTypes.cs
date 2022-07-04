using System;
using System.Collections.Generic;
using System.Linq;

namespace ObjectOrientedDesignPrinciples
{
    public class AveragePriceTypes : ICommand
    {
        private readonly List<double> prices = new();
        private double averagePrice;
        private readonly string carType;

        public AveragePriceTypes(string carType)
        {
            this.carType = carType;
        }

        public void ExecuteCom(Cars cars)
        {
            foreach (var car in (from car in cars.ArrayCars where car.Type.ToLower() == carType select car)) // the search of cars the needing type.
            {
                prices.Add(car.Price);
            }

            averagePrice = prices.Sum() / prices.Count;
        }

        public void Print()
        {
            Console.WriteLine($"The average cost of '{carType}' - {averagePrice}");
        }
    }
}