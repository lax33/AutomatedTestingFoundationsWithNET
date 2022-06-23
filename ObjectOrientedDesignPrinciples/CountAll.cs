using System;

namespace ObjectOrientedDesignPrinciples
{
    public class CountAll : ICommand
    {
        private int amount;

        public void ExecuteCom(Cars cars)
        {
            foreach (var car in cars.ArrayCars)
            {
                amount += car.Amount;
            }
        }

        public void Print()
        {
            Console.WriteLine($"Total number of cars {amount}");
        }
    }
}