using System;

namespace ObjectOrientedDesignPrinciples
{
    public class AveragePriceAllCars : ICommand
    {
        private int amountPrice;
        private double averigePrice;

        public void ExecuteCom(Cars cars)
        {
            foreach (var car in cars.ArrayCars)
            {
                amountPrice += car.Price;
            }

            averigePrice = amountPrice / cars.ArrayCars.Count;
        }

        public void Print()
        {
            Console.WriteLine($"The average car's cost - {averigePrice}");
        }
    }
}